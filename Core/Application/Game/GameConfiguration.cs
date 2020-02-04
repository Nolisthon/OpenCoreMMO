using System;

public class GameConfiguration
{
    public bool BindOnlyGlobalAddress { get; private set; }
    public bool StartupDatabaseOptimization { get; private set; }
    public string Ip { get; private set; }
    public string MapName { get; private set; }
    public string MapAuthor { get; private set; }
    public string HouseRentPeriod { get; private set; }



    public string MysqlHost { get; private set; }
    public string MysqlUser { get; private set; }
    public string MysqlPass { get; private set; }
    public string MysqlDatabase { get; private set; }
    public string MysqlSock { get; private set; }
    public int MysqlPort { get; private set; }
    public int GameProtocolPort { get; private set; }
    public int LoginProtocolPort { get; private set; }
    public int StatusProtocolPort { get; private set; }
    public int MarketOfferDuration { get; private set; }
    public bool AllowChangeOutfit { get; private set; }
    public bool OnePlayerOnlinePerAccount { get; private set; }
    public bool HotkeyAimbotEnabled { get; private set; }
    public bool RemoveChargesFromRunes { get; private set; }
    public bool ExperienceByKillingPlayers { get; private set; }
    public bool FreePremium { get; private set; }
    public bool ReplaceKickOnLogin { get; private set; }
    public bool AllowClones { get; private set; }
    public bool PremiumToCreateMarketOffer { get; private set; }
    public bool EmoteSpells { get; private set; }
    public bool StaminaSystem { get; private set; }
    public bool WarnUnsafeScripts { get; private set; }
    public bool ConvertUnsafeScripts { get; private set; }
    public bool ClassicEquipmentSlots { get; private set; }
    public bool ClassicAttackSpeed { get; private set; }
    public bool ShowScriptsLogInConsole { get; private set; }
    public bool ServerSaveNotifyMessage { get; private set; }
    public bool ServerSaveCleanMap { get; private set; }
    public bool ServerSaveClose { get; private set; }
    public bool ServerSaveShutdown { get; private set; }
    public string ShowOnlineStatusInCharlist { get; private set; }
    public string DefaultPriority { get; private set; }
    public string ServerName { get; private set; }
    public string OwnerName { get; private set; }
    public string OwnerEmail { get; private set; }
    public string Url { get; private set; }
    public string Location { get; private set; }
    public string Motd { get; private set; }
    public string WorldType { get; private set; }
    public int MaxPlayers { get; private set; }
    public int PzLocked { get; private set; }
    public int DeSpawnRange { get; private set; }
    public int DeSpawnRadius { get; private set; }
    public int RateExp { get; private set; }
    public int RateSkill { get; private set; }
    public int RateLoot { get; private set; }
    public int RateMagic { get; private set; }
    public int RateSpawn { get; private set; }
    public int HousePriceEachSQM { get; private set; }
    public int KillsToRedSkull { get; private set; }
    public int KillsToBlackSkull { get; private set; }
    public int TimeBetweenActions { get; private set; }
    public int TimeBetweenExActions { get; private set; }
    public int KickIdlePlayerAfterMinutes { get; private set; }
    public int ProtectionLevel { get; private set; }
    public int DeathLosePercent { get; private set; }
    public int StatusTimeout { get; private set; }
    public int TimeToDecreaseFrags { get; private set; }
    public int WhiteSkullTime { get; private set; }
    public int StairJumpExhaustion { get; private set; }
    public int ExpFromPlayersLevelRange { get; private set; }
    public int CheckExpiredMarketOffersEachMinutes { get; private set; }
    public int MaxMarketOffersAtATimePerPlayer { get; private set; }
    public int MaxPacketsPerSecond { get; private set; }
    public int ServerSaveNotifyDuration { get; private set; }

    private GameConfiguration instance = new GameConfiguration();
    public static async void Load()
    {
        
    }

}