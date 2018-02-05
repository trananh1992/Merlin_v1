////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.10.351.109781-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Albion_Direct
{
    /* Internal type: Albion.Common.Photon.OperationCodes */
    public enum OperationCodes
    {
        Unused = 0,
        Ping = 1,
        Join = 2,
        CreateAccount = 3,
        Login = 4,
        SendCrashLog = 5,
        CreateCharacter = 6,
        DeleteCharacter = 7,
        SelectCharacter = 8,
        RedeemKeycode = 9,
        GetGameServerByCluster = 10,
        GetSubscriptionDetails = 11,
        GetActiveSubscription = 12,
        GetSubscriptionUrl = 13,
        GetBuyTrialDetails = 14,
        GetReferralSeasonDetails = 15,
        GetAvailableTrialKeys = 16,
        Move = 17,
        AttackStart = 18,
        CastStart = 19,
        CastCancel = 20,
        TerminateToggleSpell = 21,
        ChannelingCancel = 22,
        AttackBuildingStart = 23,
        InventoryDestroyItem = 24,
        InventoryMoveItem = 25,
        InventorySplitStack = 26,
        ChangeCluster = 27,
        ConsoleCommand = 28,
        ChatMessage = 29,
        ReportClientError = 30,
        RegisterToObject = 31,
        UnRegisterFromObject = 32,
        CraftBuildingChangeSettings = 33,
        CraftBuildingTakeMoney = 34,
        RepairBuildingChangeSettings = 35,
        RepairBuildingTakeMoney = 36,
        ActionBuildingChangeSettings = 37,
        HarvestStart = 38,
        HarvestCancel = 39,
        TakeSilver = 40,
        ActionOnBuildingStart = 41,
        ActionOnBuildingCancel = 42,
        ItemRerollQualityStart = 43,
        ItemRerollQualityCancel = 44,
        InstallResourceStart = 45,
        InstallResourceCancel = 46,
        InstallSilver = 47,
        BuildingFillNutrition = 48,
        BuildingChangeRenovationState = 49,
        BuildingBuySkin = 50,
        BuildingClaim = 51,
        BuildingGiveup = 52,
        BuildingNutritionSilverStorageDeposit = 53,
        BuildingNutritionSilverStorageWithdraw = 54,
        BuildingNutritionSilverRewardSet = 55,
        ConstructionSiteCreate = 56,
        PlaceableItemPlace = 57,
        PlaceableItemPlaceCancel = 58,
        PlaceableObjectPickup = 59,
        FurnitureObjectUse = 60,
        FarmableHarvest = 61,
        FarmableFinishGrownItem = 62,
        FarmableDestroy = 63,
        FarmableGetProduct = 64,
        FarmableFill = 65,
        LaborerObjectPlace = 66,
        LaborerObjectPlaceCancel = 67,
        CastleGateUse = 68,
        AuctionCreateOffer = 69,
        AuctionCreateRequest = 70,
        AuctionGetOffers = 71,
        AuctionGetRequests = 72,
        AuctionBuyOffer = 73,
        AuctionAbortAuction = 74,
        AuctionAbortOffer = 75,
        AuctionAbortRequest = 76,
        AuctionSellRequest = 77,
        AuctionGetFinishedAuctions = 78,
        AuctionFetchAuction = 79,
        AuctionGetMyOpenOffers = 80,
        AuctionGetMyOpenRequests = 81,
        AuctionGetMyOpenAuctions = 82,
        AuctionGetItemsAverage = 83,
        ContainerOpen = 84,
        ContainerClose = 85,
        Respawn = 86,
        Suicide = 87,
        JoinGuild = 88,
        LeaveGuild = 89,
        CreateGuild = 90,
        InviteToGuild = 91,
        DeclineGuildInvitation = 92,
        KickFromGuild = 93,
        DuellingChallengePlayer = 94,
        DuellingAcceptChallenge = 95,
        DuellingDenyChallenge = 96,
        ChangeClusterTax = 97,
        ClaimTerritory = 98,
        GiveUpTerritory = 99,
        ChangeTerritoryAccessRights = 100,
        GetMonolithInfo = 101,
        GetClaimInfo = 102,
        GetAttackInfo = 103,
        GetTerritorySeasonPoints = 104,
        GetAttackSchedule = 105,
        ScheduleAttack = 106,
        GetMatches = 107,
        GetMatchDetails = 108,
        JoinMatch = 109,
        LeaveMatch = 110,
        ChangeChatSettings = 111,
        LogoutStart = 112,
        LogoutCancel = 113,
        ClaimOrbStart = 114,
        ClaimOrbCancel = 115,
        OpenBattleVault = 116,
        CloseBattleVault = 117,
        DepositToGuildAccount = 118,
        WithdrawalFromAccount = 119,
        ChangeGuildPayUpkeepFlag = 120,
        ChangeGuildTax = 121,
        GetMyTerritories = 122,
        MorganaCommand = 123,
        GetServerInfo = 124,
        InviteMercenaryToMatch = 125,
        SubscribeToCluster = 126,
        AnswerMercenaryInvitation = 127,
        GetCharacterEquipment = 128,
        GetCharacterStats = 129,
        GetKillHistoryDetails = 130,
        LearnMasteryLevel = 131,
        ChangeAvatar = 132,
        PromotePlayer = 133,
        DemotePlayer = 134,
        GetRankings = 135,
        GetRank = 136,
        GetGvgSeasonRankings = 137,
        GetGvgSeasonRank = 138,
        GetGvgSeasonHistoryRankings = 139,
        KickFromGvGMatch = 140,
        InviteToPlayerTrade = 141,
        PlayerTradeCancel = 142,
        PlayerTradeInvitationAccept = 143,
        PlayerTradeAddItem = 144,
        PlayerTradeRemoveItem = 145,
        PlayerTradeAcceptTrade = 146,
        PlayerTradeSetSilverOrGold = 147,
        SendMiniMapPing = 148,
        Stuck = 149,
        BuyRealEstate = 150,
        ClaimRealEstate = 151,
        GiveUpRealEstate = 152,
        ChangeRealEstateOutline = 153,
        GetMailInfos = 154,
        ReadMail = 155,
        SendNewMail = 156,
        DeleteMail = 157,
        ClaimAttachmentFromMail = 158,
        UpdateLfgInfo = 159,
        GetLfgInfos = 160,
        GetMyGuildLfgInfo = 161,
        GetLfgDescriptionText = 162,
        LfgApplyToGuild = 163,
        AnswerLfgGuildApplication = 164,
        GetClusterInfo = 165,
        RegisterChatPeer = 166,
        SendChatMessage = 167,
        JoinChatChannel = 168,
        LeaveChatChannel = 169,
        SendWhisperMessage = 170,
        Say = 171,
        PlayEmote = 172,
        StopEmote = 173,
        GetClusterMapInfo = 174,
        AccessRightsChangeSettings = 175,
        Mount = 176,
        MountCancel = 177,
        BuyJourney = 178,
        SetSaleStatusForEstate = 179,
        ResolveGuildOrPlayerName = 180,
        GetRespawnInfos = 181,
        MakeHome = 182,
        LeaveHome = 183,
        ResurrectionReply = 184,
        AllianceCreate = 185,
        AllianceDisband = 186,
        AllianceGetMemberInfos = 187,
        AllianceInvite = 188,
        AllianceAnswerInvitation = 189,
        AllianceCancelInvitation = 190,
        AllianceKickGuild = 191,
        AllianceLeave = 192,
        AllianceChangeGoldPaymentFlag = 193,
        AllianceGetDetailInfo = 194,
        GetIslandInfos = 195,
        AbandonMyIsland = 196,
        BuyMyIsland = 197,
        BuyGuildIsland = 198,
        AbandonGuildIsland = 199,
        UpgradeMyIsland = 200,
        UpgradeGuildIsland = 201,
        MonolithBankOpen = 202,
        MonolithBankClose = 203,
        TerritoryFillNutrition = 204,
        TeleportBack = 205,
        PartyInvitePlayer = 206,
        PartyAnswerInvitation = 207,
        PartyLeave = 208,
        PartyKickPlayer = 209,
        PartyMakeLeader = 210,
        PartyChangeLootSetting = 211,
        GetGuildMOTD = 212,
        SetGuildMOTD = 213,
        ExitEnterStart = 214,
        ExitEnterCancel = 215,
        AgentRequest = 216,
        GoldMarketGetBuyOffer = 217,
        GoldMarketGetBuyOfferFromSilver = 218,
        GoldMarketGetSellOffer = 219,
        GoldMarketGetSellOfferFromSilver = 220,
        GoldMarketBuyGold = 221,
        GoldMarketSellGold = 222,
        GoldMarketCreateSellOrder = 223,
        GoldMarketCreateBuyOrder = 224,
        GoldMarketGetInfos = 225,
        GoldMarketCancelOrder = 226,
        GoldMarketGetAverageInfo = 227,
        SiegeCampClaimStart = 228,
        SiegeCampClaimCancel = 229,
        SiegeCampBankOpen = 230,
        SiegeCampBankClose = 231,
        ChangeUseCraftingFocus = 232,
        TreasureChestUsingStart = 233,
        TreasureChestUsingCancel = 234,
        LaborerStartJob = 235,
        LaborerTakeJobLoot = 236,
        LaborerDismiss = 237,
        LaborerMove = 238,
        LaborerBuyItem = 239,
        LaborerUpgrade = 240,
        BuyPremium = 241,
        BuyTrial = 242,
        RealEstateGetAuctionData = 243,
        RealEstateBidOnAuction = 244,
        GetSiegeCampCooldown = 245,
        FriendInvite = 246,
        FriendAnswerInvitation = 247,
        FriendCancelnvitation = 248,
        FriendRemove = 249,
        InventoryStack = 250,
        InventorySort = 251,
        EquipmentItemChangeSpell = 252,
        ExpeditionRegister = 253,
        ExpeditionRegisterCancel = 254,
        JoinExpedition = 255,
        DeclineExpeditionInvitation = 256,
        VoteStart = 257,
        VoteDoVote = 258,
        RatingDoRate = 259,
        EnteringExpeditionStart = 260,
        EnteringExpeditionCancel = 261,
        ActivateExpeditionCheckPoint = 262,
        ArenaRegister = 263,
        ArenaRegisterCancel = 264,
        ArenaLeave = 265,
        JoinArenaMatch = 266,
        DeclineArenaInvitation = 267,
        EnteringArenaStart = 268,
        EnteringArenaCancel = 269,
        UpdateCharacterStatement = 270,
        BoostFarmable = 271,
        GetStrikeHistory = 272,
        UseFunction = 273,
        UsePortalEntrance = 274,
        QueryPortalBinding = 275,
        ClaimPaymentTransaction = 276,
        ChangeUseAutoLP = 277,
        ClientPerformanceStats = 278,
        ExtendedHardwareStats = 279,
        TerritoryClaimStart = 280,
        TerritoryClaimCancel = 281,
        RequestAppStoreProducts = 282,
        VerifyProductPurchase = 283,
        QueryGuildPlayerStats = 284,
        TrackAchievements = 285,
        DepositItemToGuildToken = 286,
        WithdrawalItemFromGuildToken = 287,
        AuctionSellSpecificItemRequest = 288
    }
    
    public static class OperationCodesExtensions
    {
        public static Albion.Common.Photon.OperationCodes ToInternal(this OperationCodes instance)
        {
            return (Albion.Common.Photon.OperationCodes)instance;
        }
        
        public static OperationCodes ToWrapped(this Albion.Common.Photon.OperationCodes instance)
        {
            return (OperationCodes)instance;
        }
    }
}
