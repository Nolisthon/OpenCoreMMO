﻿using NeoServer.Game.Creatures.Npcs;
using NeoServer.Server.Contracts.Network;
using NeoServer.Server.Model.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoServer.Networking.Packets.Outgoing.Npc
{
    public class SaleItemListPacket : OutgoingPacket
    {
        public SaleItemListPacket(IPlayer player, IEnumerable<ShopItem> shopItem)
        {
            Player = player;
            ShopItems = shopItem;
        }

        public IPlayer Player { get; }
        public IEnumerable<ShopItem> ShopItems { get; }
      
        public override void WriteToMessage(INetworkMessage message)
        {
            if (Player is null) return;

            var map = Player.Inventory.Map;
            var totalMoney = Player.Inventory.GetTotalMoney(map);

            message.AddByte((byte)GameOutgoingPacketType.SaleItemList);
            message.AddUInt32(Math.Min(totalMoney, uint.MaxValue));

            byte itemsToSend = 0;

            var temp = new List<byte>();
            foreach (var shopItem in ShopItems)
            {
                if (shopItem.SellPrice == 0) continue;

                var index = (int)shopItem.Item.TypeId;
                //if (Item::items[shopInfo.itemId].isFluidContainer()) //todo
                //{
                //    index |= (static_cast<uint32_t>(shopInfo.subType) << 16);
                //}

                if (!map.TryGetValue(shopItem.Item.TypeId, out var itemAmount)) continue;

                temp.AddRange(BitConverter.GetBytes(shopItem.Item.ClientId));
                temp.Add((byte)Math.Min(itemAmount, byte.MaxValue));

                if (++itemsToSend >= byte.MaxValue) break;
            }

            message.AddByte(itemsToSend);
            message.AddBytes(temp.ToArray());
        }
    }
}
