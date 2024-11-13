﻿
namespace dofus_unity_rendering_back.Models.Metadata.Effect
{

    public enum ActionId : ushort
    {

        CharacterChangeMap = 2,

        CharacterChangeRespawnMap = 3,

        CharacterTeleportOnSameMap = 4,

        CharacterPush = 5,

        CharacterPull = 6,

        CharacterDivorceWifeOrHusband = 7,

        CharacterExchangePlaces = 8,

        CharacterDodgeHit = 9,

        CharacterLearnEmoticon = 10,

        CharacterCreateGuild = 12,

        QuestObjectiveValidate = 30,

        QuestStepValidate = 31,

        QuestQuestValidate = 32,

        QuestStart = 34,

        QuestReset = 36,

        QuestForceStart = 37,

        BreachCreate = 46,

        BreachEnter = 47,

        BreachNextFightRoom = 48,

        BreachNextSafeRoom = 49,

        CarryCharacter = 50,

        ThrowCarriedCharacter = 51,

        BreachPreviousRoom = 52,

        BreachJumpToSafeRoom = 53,

        BreachKickOut = 54,

        BreachModifyMap = 55,

        BreachDisplayRoomsRewards = 56,

        BreachGainBonus = 57,

        BreachModifyRoom = 58,

        BreachModifyFightModifier = 60,

        BreachModifyBoss = 61,

        BreachAddBoss = 62,

        AnomalyExit = 63,

        CharacterMovementPointsSteal = 77,

        CharacterMovementPointsWin = 78,

        CharacterMultiplyReceivedDamageOrGiveLifeWithRatio = 79,

        CharacterLifePointsLostFromPush = 80,

        CharacterLifePointsWinWithoutElement = 81,

        CharacterLifePointsStealWithoutBoost = 82,

        CharacterActionPointsSteal = 84,

        CharacterLifePointsLostBasedOnCasterLifeFromWater = 85,

        CharacterLifePointsLostBasedOnCasterLifeFromEarth = 86,

        CharacterLifePointsLostBasedOnCasterLifeFromAir = 87,

        CharacterLifePointsLostBasedOnCasterLifeFromFire = 88,

        CharacterLifePointsLostBasedOnCasterLife = 89,

        CharacterDispatchLifePointsPercent = 90,

        CharacterLifePointsStealFromWater = 91,

        CharacterLifePointsStealFromEarth = 92,

        CharacterLifePointsStealFromAir = 93,

        CharacterLifePointsStealFromFire = 94,

        CharacterLifePointsSteal = 95,

        CharacterLifePointsLostFromWater = 96,

        CharacterLifePointsLostFromEarth = 97,

        CharacterLifePointsLostFromAir = 98,

        CharacterLifePointsLostFromFire = 99,

        CharacterLifePointsLost = 100,

        CharacterActionPointsLost = 101,

        CharacterLifeLostModerator = 105,

        CharacterSpellReflector = 106,

        CharacterLifeLostReflector = 107,

        CharacterLifePointsWinFromFire = 108,

        CharacterLifePointsLostCaster = 109,

        CharacterBoostLifePoints = 110,

        CharacterBoostActionPoints = 111,

        CharacterBoostDamages = 112,

        CharacterBoostCriticalHit = 115,

        CharacterDeboostRange = 116,

        CharacterBoostRange = 117,

        CharacterBoostStrength = 118,

        CharacterBoostAgility = 119,

        CharacterActionPointsWin = 120,

        CharacterBoostDamagesForAllGame = 121,

        CharacterBoostCriticalMiss = 122,

        CharacterBoostChance = 123,

        CharacterBoostWisdom = 124,

        CharacterBoostVitality = 125,

        CharacterBoostIntelligence = 126,

        CharacterMovementPointsLost = 127,

        CharacterBoostMovementPoints = 128,

        CharacterStealGold = 130,

        CharacterRemoveAllEffects = 132,

        CharacterActionPointsLostCaster = 133,

        CharacterMovementPointsLostCaster = 134,

        CharacterBoostRangeCaster = 136,

        CharacterBoostDamagesCaster = 137,

        CharacterBoostDamagesPercent = 138,

        CharacterEnergyPointsWin = 139,

        CharacterPassNextTurn = 140,

        CharacterKill = 141,

        CharacterBoostPhysicalDamages = 142,

        CharacterLifePointsWinWithoutBoost = 143,

        CharacterLifePointsLostNoBoost = 144,

        CharacterDeboostDamages = 145,

        CharacterCurse = 146,

        CharacterResurectAllyInFight = 147,

        CharacterAddFollowingCharacter = 148,

        CharacterChangeLook = 149,

        CharacterMakeInvisible = 150,

        CharacterDeboostChance = 152,

        CharacterDeboostVitality = 153,

        CharacterDeboostAgility = 154,

        CharacterDeboostIntelligence = 155,

        CharacterDeboostWisdom = 156,

        CharacterDeboostStrength = 157,

        CharacterBoostMaximumWeight = 158,

        CharacterDeboostMaximumWeight = 159,

        CharacterBoostActionPointsLostDodge = 160,

        CharacterBoostMovementPointsLostDodge = 161,

        CharacterDeboostActionPointsLostDodge = 162,

        CharacterDeboostMovementPointsLostDodge = 163,

        CharacterBoostOneWeaponDamagePercent = 165,

        CharacterDeboostActionPoints = 168,

        CharacterDeboostMovementPoints = 169,

        CharacterDeboostCriticalHit = 171,

        CharacterDeboostMagicalReduction = 172,

        CharacterDeboostPhysicalReduction = 173,

        CharacterBoostInitiative = 174,

        CharacterDeboostInitiative = 175,

        CharacterBoostMagicFind = 176,

        CharacterDeboostMagicFind = 177,

        CharacterBoostHealBonus = 178,

        CharacterDeboostHealBonus = 179,

        CharacterAddDoubleUseSummonSlot = 180,

        SummonCreature = 181,

        CharacterBoostMaximumSummonedCreatures = 182,

        CharacterBoostMagicalReduction = 183,

        CharacterBoostPhysicalReduction = 184,

        CharacterDeboostDamagesPercent = 186,

        CharacterAlignmentSideSet = 188,

        CharacterInventoryRemoveItem = 192,

        CharacterInventoryAddItemCheck = 193,

        CharacterInventoryGainKamas = 194,

        CharacterTransform = 197,

        DecorsRevealUnvisible = 202,

        CharacterResurrection = 206,

        CharacterBoostEarthElementPercent = 210,

        CharacterBoostWaterElementPercent = 211,

        CharacterBoostAirElementPercent = 212,

        CharacterBoostFireElementPercent = 213,

        CharacterBoostNeutralElementPercent = 214,

        CharacterDeboostEarthElementPercent = 215,

        CharacterDeboostWaterElementPercent = 216,

        CharacterDeboostAirElementPercent = 217,

        CharacterDeboostFireElementPercent = 218,

        CharacterDeboostNeutralElementPercent = 219,

        CharacterReflectorUnboosted = 220,

        CharacterInventoryAddItemRandomNocheck = 221,

        CharacterInventoryAddItemFromRandomDrop = 222,

        CharacterBoostTrap = 225,

        CharacterBoostTrapPercent = 226,

        CharacterGainRide = 229,

        CharacterEnergyLossBoost = 230,

        DecorsPlayAnimationD2 = 237,

        PlayCinematic = 239,

        CharacterBoostEarthElementResist = 240,

        CharacterBoostWaterElementResist = 241,

        CharacterBoostAirElementResist = 242,

        CharacterBoostFireElementResist = 243,

        CharacterBoostNeutralElementResist = 244,

        CharacterDeboostEarthElementResist = 245,

        CharacterDeboostWaterElementResist = 246,

        CharacterDeboostAirElementResist = 247,

        CharacterDeboostFireElementResist = 248,

        CharacterDeboostNeutralElementResist = 249,

        CharacterLifeLostCasterModerator = 265,

        CharacterStealChance = 266,

        CharacterStealVitality = 267,

        CharacterStealAgility = 268,

        CharacterStealIntelligence = 269,

        CharacterStealWisdom = 270,

        CharacterStealStrength = 271,

        CharacterLifePointsLostBasedOnCasterLifeMissingFromWater = 275,

        CharacterLifePointsLostBasedOnCasterLifeMissingFromEarth = 276,

        CharacterLifePointsLostBasedOnCasterLifeMissingFromAir = 277,

        CharacterLifePointsLostBasedOnCasterLifeMissingFromFire = 278,

        CharacterLifePointsLostBasedOnCasterLifeMissing = 279,

        BoostSpellRangeMin = 280,

        BoostSpellRangeMax = 281,

        BoostSpellRangeable = 282,

        BoostSpellDmg = 283,

        BoostSpellHeal = 284,

        BoostSpellApCost = 285,

        BoostSpellCastIntvl = 286,

        BoostSpellCc = 287,

        BoostSpellCastoutline = 288,

        BoostSpellNolineofsight = 289,

        BoostSpellMaxperturn = 290,

        BoostSpellMaxpertarget = 291,

        BoostSpellCastIntvlSet = 292,

        BoostSpellBaseDmg = 293,

        DeboostSpellRangeMax = 294,

        DeboostSpellRangeMin = 295,

        DeboostSpellApCost = 296,

        DeboostOccupiedCell = 297,

        DeboostFreeCell = 298,

        BoostFreeCell = 299,

        FightDispellTemporaryObject = 310,

        BoostOccupiedCell = 314,

        CharacterStealRange = 320,

        CharacterChangeColor = 333,

        CharacterAddAppearance = 335,

        RefreshMapNpcOnlyForMeInRoleplay = 350,

        RefreshMapNpcForEveryoneInRoleplay = 351,

        FightAddTrapCastingSpell = 400,

        FightAddGlyphCastingSpell = 401,

        FightAddGlyphCastingSpellEndturn = 402,

        FightKillAndSummon = 405,

        CharacterDispellSpell = 406,

        CharacterLifePointsWinNoBoost = 407,

        CharacterBoostApAttack = 410,

        CharacterDeboostApAttack = 411,

        CharacterBoostMpAttack = 412,

        CharacterDeboostMpAttack = 413,

        CharacterBoostPushDamage = 414,

        CharacterDeboostPushDamage = 415,

        CharacterBoostPushDamageReduction = 416,

        CharacterDeboostPushDamageReduction = 417,

        CharacterBoostCriticalDamagesBonus = 418,

        CharacterDeboostCriticalDamagesBonus = 419,

        CharacterBoostCriticalDamagesReduction = 420,

        CharacterDeboostCriticalDamagesReduction = 421,

        CharacterBoostEarthDamages = 422,

        CharacterDeboostEarthDamages = 423,

        CharacterBoostFireDamages = 424,

        CharacterDeboostFireDamages = 425,

        CharacterBoostWaterDamages = 426,

        CharacterDeboostWaterDamages = 427,

        CharacterBoostAirDamages = 428,

        CharacterDeboostAirDamages = 429,

        CharacterBoostNeutralDamages = 430,

        CharacterDeboostNeutralDamages = 431,

        CharacterActionPointsStealNoEvade = 440,

        CharacterMovementPointsStealNoEvade = 441,

        ChangeCompassByCoord = 509,

        AddPrism = 513,

        ShowTaxCollectorList = 516,

        ExchangeDecraftOpen = 517,

        GotoWaypoint = 600,

        CharacterLearnSpellLevel = 604,

        CharacterGainXp = 605,

        CharacterGainWisdom = 606,

        CharacterGainStrength = 607,

        CharacterGainChance = 608,

        CharacterGainAgility = 609,

        CharacterGainVitality = 610,

        CharacterGainIntelligence = 611,

        CharacterGainStatsPoints = 612,

        CharacterGainJobXp = 614,

        CharacterReadBook = 620,

        CharacterSummonMonster = 621,

        GotoHouse = 622,

        CharacterSummonMonsterGroup = 623,

        CharacterResetCharacs = 626,

        CharacterSummonMonsterGroupDynamic = 628,

        CharacterLearnSpell = 629,

        CharacterSendInformationText = 630,

        CharacterSendErrorText = 632,

        CharacterGainHonour = 640,

        CharacterLooseHonour = 642,

        MapResurectionAllies = 645,

        MapHealAllies = 646,

        MapForceEnnemiesGhost = 647,

        ForceEnnemyGhost = 648,

        FakeAlignment = 649,

        SetStatedElementState = 652,

        InstanciedmapLeave = 654,

        Noop = 666,

        KillFight = 667,

        Incarnation = 669,

        CharacterLifePointsLostBasedOnCasterLifeReducedByCaster = 670,

        CharacterLifePointsLostBasedOnCasterLifeNotReduced = 671,

        CharacterLifePointsLostBasedOnCasterLifeMidlife = 672,

        ItemChangeEffect = 700,

        ItemAddEffect = 701,

        CaptureSoul = 705,

        CaptureRide = 706,

        ItemEquipPreset = 707,

        CharacterAddCostToAction = 710,

        LadderSuperrace = 715,

        LadderRace = 716,

        LadderId = 717,

        PvpLadder = 720,

        CharacterLearnSpellTemporary = 722,

        GainTitle = 724,

        CharacterRenameInvalidGuild = 725,

        GainOrnament = 726,

        TeleportNearestPrism = 730,

        AutoAggressEnemyPlayer = 731,

        ResistAutoAggress = 732,

        BoostSoulCaptureBonus = 750,

        BoostRideXpBonus = 751,

        CharacterBoostTakleEvade = 752,

        CharacterBoostTakleBlock = 753,

        CharacterDeboostTakleEvade = 754,

        CharacterDeboostTakleBlock = 755,

        RemoveOnMove = 760,

        CharacterSacrify = 765,

        ClockwiseConfusionDegree = 770,

        ClockwiseConfusionPi2 = 771,

        ClockwiseConfusionPi4 = 772,

        CounterClockwiseConfusionDegree = 773,

        CounterClockwiseConfusionPi2 = 774,

        CounterClockwiseConfusionPi4 = 775,

        CharacterBoostPermanentDamagePercent = 776,

        CharacterDeboostPermanentDamagePercent = 777,

        CharacterChangeRespawnMapByRef = 778,

        CharacterTeleportOnPreviousMap = 779,

        CharacterSummonDeadAllyInFight = 780,

        CharacterUnlucky = 781,

        CharacterMaximizeRoll = 782,

        CharacterPushUpTo = 783,

        CharacterTeleportToFightStartPos = 784,

        CharacterHealAttackers = 786,

        CharacterPunishment = 788,

        CharacterLooseAllItemsFromCategory = 789,

        TargetExecuteSpell = 792,

        TargetExecuteSpellWithAnimation = 793,

        HuntTool = 795,

        CharacterRestoreRespawnMap = 796,

        BoostVisibleTargetOnCellOn = 798,

        BoostVisibleTargetOnCellOff = 799,

        ItemChangeDuration = 805,

        ItemPetsShape = 806,

        ItemPetsEat = 807,

        PetsLastMeal = 808,

        Size = 810,

        ItemBuffChangeDuration = 811,

        ItemChangeDurability = 812,

        ItemUpdateDate = 813,

        ItemDungeonKeyDate = 814,

        ItemFmLostPower = 815,

        ItemResetDate = 816,

        ItemBuffChangeDurationWin = 817,

        ItemBuffChangeDurationLose = 818,

        ItemTeleportForce = 825,

        ItemTeleportMapReference = 826,

        FightChallengeAgainstMonster = 905,

        FightChallengeMixedVersusMonster = 911,

        CharacterSendNotificationText = 916,

        CharacterSendNotificationAlertText = 917,

        PetSetPowerBoost = 939,

        PetPowerBoost = 940,

        FarmTempWithdrawItem = 946,

        FarmWithdrawItem = 947,

        FarmPlaceItem = 948,

        MountRide = 949,

        FightSetState = 950,

        FightUnsetState = 951,

        FightDisableState = 952,

        CreatedSince = 963,

        ShowPlayername = 964,

        ItemLivingId = 970,

        ItemLivingMood = 971,

        ItemLivingSkin = 972,

        ItemLivingCategory = 973,

        ItemLivingLevel = 974,

        MarkNeverTradableStrong = 981,

        MarkNeverTradable = 982,

        MarkNotTradable = 983,

        MarkLegitOwner = 984,

        SetCraftermage = 985,

        MarkTarget = 986,

        SetOwner = 987,

        SetCrafter = 988,

        SeekTarget = 989,

        ShowText = 990,

        RideInvalid = 994,

        RideDetails = 995,

        ItemTeleport = 999,

        FarmObjetEfficacity = 1007,

        SummonBomb = 1008,

        CharacterActivateBomb = 1009,

        SummonSlave = 1011,

        CharacterLifePointsLostBasedOnMovementPoints = 1012,

        CharacterLifePointsLostBasedOnMovementPointsFromAir = 1013,

        CharacterLifePointsLostBasedOnMovementPointsFromWater = 1014,

        CharacterLifePointsLostBasedOnMovementPointsFromFire = 1015,

        CharacterLifePointsLostBasedOnMovementPointsFromEarth = 1016,

        TargetExecuteSpellOnSource = 1017,

        SourceExecuteSpellOnTarget = 1018,

        SourceExecuteSpellOnSource = 1019,

        CharacterBoostShieldBasedOnCasterLevel = 1020,

        CharacterPushForce = 1021,

        CharacterPullForce = 1022,

        CharacterExchangePlacesForce = 1023,

        CharacterAddIllusionRandom = 1024,

        ForceTrapTrigger = 1025,

        ForceGlyphTrigger = 1026,

        BombComboBonus = 1027,

        BombTriggerPowder = 1028,

        CharacterVanish = 1029,

        FightAddPowderCastingSpell = 1030,

        CharacterPassCurrentTurn = 1031,

        MarkLegitOwnerTimestamp = 1032,

        CharacterDeboostVitalityPercentStatic = 1033,

        CharacterSummonDeadAllyAsSummonInFight = 1034,

        CharacterAddSpellCooldown = 1035,

        CharacterRemoveSpellCooldown = 1036,

        CharacterLifePointsWinZobal = 1037,

        CharacterAura = 1038,

        CharacterBoostShieldBasedOnCasterLife = 1039,

        CharacterBoostShield = 1040,

        CharacterGetPushed = 1041,

        CharacterGetPulled = 1042,

        CharacterPullUpTo = 1043,

        CharacterProtectionFromSpell = 1044,

        CharacterSetSpellCooldown = 1045,

        CharacterLifePointsMalus = 1047,

        CharacterLifePointsMalusPercent = 1048,

        CharacterGainLevel = 1049,

        CharacterResumeDungeon = 1052,

        CharacterBoostDamagesPercentSpells = 1054,

        CharacterClearDungeonSave = 1055,

        StaticValueModify = 1057,

        StaticValueSet = 1058,

        CharacterAddScaleFlat = 1060,

        CharacterShareDamages = 1061,

        CharacterLifePointsLostNoBoostFromEarth = 1063,

        CharacterLifePointsLostNoBoostFromAir = 1064,

        CharacterLifePointsLostNoBoostFromWater = 1065,

        CharacterLifePointsLostNoBoostFromFire = 1066,

        CharacterLifePointsLostBasedOnTargetLifeFromAir = 1067,

        CharacterLifePointsLostBasedOnTargetLifeFromWater = 1068,

        CharacterLifePointsLostBasedOnTargetLifeFromFire = 1069,

        CharacterLifePointsLostBasedOnTargetLifeFromEarth = 1070,

        CharacterLifePointsLostBasedOnTargetLife = 1071,

        CharacterTaunt = 1072,

        ItemChangeEffectSafe = 1073,

        MeetingPoint = 1074,

        CharacterShortenActiveEffectsDuration = 1075,

        CharacterBoostResistPercent = 1076,

        CharacterDeboostResistPercent = 1077,

        CharacterBoostVitalityPercentStatic = 1078,

        CharacterDeboostActionPointsDodgeable = 1079,

        CharacterDeboostMovementPointsDodgeable = 1080,

        ItemExtraPods = 1081,

        ItemGiftOpen = 1082,

        ItemGiftPacking = 1083,

        ItemGiftContent = 1084,

        ItemGiftQuantity = 1085,

        ItemGiftTarget = 1086,

        ItemGiftChooseTarget = 1087,

        FightAddGlyphAura = 1091,

        CharacterLifePointsLostBasedOnTargetMissingMaxLife = 1092,

        CharacterLifePointsLostBasedOnTargetMissingMaxLifeAir = 1093,

        CharacterLifePointsLostBasedOnTargetMissingMaxLifeFire = 1094,

        CharacterLifePointsLostBasedOnTargetMissingMaxLifeWater = 1095,

        CharacterLifePointsLostBasedOnTargetMissingMaxLifeEarth = 1096,

        CharacterAddIllusionMirror = 1097,

        ItemCurseUsedItem = 1098,

        FightRollbackTurnBeginPosition = 1099,

        FightRollbackPreviousPosition = 1100,

        FightTeleswap = 1101,

        SpeakingItem = 1102,

        FightPushNoDamage = 1103,

        FightTeleswapMirror = 1104,

        FightTeleswapMirrorCaster = 1105,

        FightTeleswapMirrorImpactPoint = 1106,

        ItemGuildRename = 1107,

        ItemGuildEmblemChange = 1108,

        FightLifePointsWinPercent = 1109,

        ItemSummonMonsterRewardRate = 1110,

        ItemSummonMonsterGroupMaxLootShares = 1111,

        CharacterLifePointsLostBasedOnCasterMissingMaxLife = 1118,

        CharacterLifePointsLostBasedOnCasterMissingMaxLifeAir = 1119,

        CharacterLifePointsLostBasedOnCasterMissingMaxLifeFire = 1120,

        CharacterLifePointsLostBasedOnCasterMissingMaxLifeWater = 1121,

        CharacterLifePointsLostBasedOnCasterMissingMaxLifeEarth = 1122,

        FightSplashRawTakenDamage = 1123,

        FightSplashRawTakenDamageNeutral = 1124,

        FightSplashRawTakenDamageAir = 1125,

        FightSplashRawTakenDamageFire = 1126,

        FightSplashRawTakenDamageWater = 1127,

        FightSplashRawTakenDamageEarth = 1128,

        CharacterManaUseKillLifeAir = 1131,

        CharacterManaUseKillLifeWater = 1132,

        CharacterManaUseKillLifeFire = 1133,

        CharacterManaUseKillLifeNeutral = 1134,

        CharacterManaUseKillLifeEarth = 1135,

        CharacterMovementUseKillLifeAir = 1136,

        CharacterMovementUseKillLifeWater = 1137,

        CharacterMovementUseKillLifeFire = 1138,

        CharacterMovementUseKillLifeNeutral = 1139,

        CharacterMovementUseKillLifeEarth = 1140,

        AchievementObjectiveValidate = 1142,

        FightBoostWeaponDamagePower = 1144,

        ItemAllianceEmblemChange = 1145,

        ItemAllianceRename = 1146,

        CharacterGainXpWithLevel = 1149,

        RefreshElement = 1150,

        ItemMimicryObjGid = 1151,

        MarkNotTradableBackup = 1152,

        AddTaxCollector = 1153,

        AddPrismModule = 1154,

        ItemTeleportMapReferenceForce = 1155,

        CharacterMultiplyReceivedHeal = 1159,

        CasterExecuteSpell = 1160,

        SetCompanion = 1161,

        ChangeCompassByRef = 1162,

        CharacterMultiplyReceivedDamage = 1163,

        CharacterGiveLifeWithRatio = 1164,

        FightAddGlyphCastingSpellImmediate = 1165,

        FightBoostGlyphDamagePower = 1166,

        FightBoostRuneDamagePower = 1167,

        GetPortalQuest = 1168,

        UsePortal = 1169,

        GetTreasureQuest = 1170,

        CharacterBoostDealtDamagePercentMultiplier = 1171,

        CharacterDeboostDealtDamagePercentMultiplier = 1172,

        GetLegendaryTreasureQuest = 1173,

        StopXp = 1174,

        CastStartingSpell = 1175,

        ItemWrapperLookObjGid = 1176,

        ItemTeleportNextMap = 1177,

        ItemTeleportPreviousMap = 1178,

        ItemWrapperCompatibleObjType = 1179,

        FightAddPortal = 1181,

        FightUsePortal = 1182,

        FightDisablePortal = 1183,

        CharacterGainJobLevelFromLevelOne = 1184,

        ItemResetEffects = 1185,

        RideHarnessGid = 1187,

        RideGainCapacity = 1188,

        CharacterAddDoubleNoSummonSlot = 1189,

        FightSplashFinalTakenDamage = 1223,

        FightSplashFinalTakenDamageNeutral = 1224,

        FightSplashFinalTakenDamageAir = 1225,

        FightSplashFinalTakenDamageFire = 1226,

        FightSplashFinalTakenDamageWater = 1227,

        FightSplashFinalTakenDamageEarth = 1228,

        EnableControlEntityByFightOwner = 2010,

        DisableControlEntityByFightOwner = 2011,

        TargetExecuteSpellOnSourceGlobalLimitation = 2017,

        DispelGlyphsOfTarget = 2018,

        DispelTrapsOfTarget = 2019,

        FightSplashHeal = 2020,

        NuggetsRepartition = 2021,

        FightAddRuneCastingSpell = 2022,

        ForceRuneTrigger = 2023,

        DispelRunesOfTarget = 2024,

        CharacterOpenHavenbagStorage = 2025,

        CharacterHavenbagLottery = 2026,

        ControlEntity = 2027,

        InheriteCharac = 2028,

        FinishMove = 2029,

        CharacterLearnFinishMove = 2030,

        CharacterLearnHavenBagTheme = 2031,

        CasterExecuteSpellGlobalLimitation = 2160,

        TargetExecuteSpellGlobalLimitation = 2792,

        TargetExecuteSpellWithAnimationGlobalLimitation = 2793,

        TargetExecuteSpellOnCell = 2794,

        TargetExecuteSpellOnCellGlobalLimitation = 2795,

        FightKillAndSummonSlave = 2796,

        CharacterLearnSmileyPack = 2797,

        CharacterBoostDealtDamagePercentMultiplierMelee = 2800,

        CharacterDeboostDealtDamagePercentMultiplierMelee = 2801,

        CharacterBoostReceivedDamagePercentMultiplierMelee = 2802,

        CharacterDeboostReceivedDamagePercentMultiplierMelee = 2803,

        CharacterBoostDealtDamagePercentMultiplierDistance = 2804,

        CharacterDeboostDealtDamagePercentMultiplierDistance = 2805,

        CharacterBoostReceivedDamagePercentMultiplierDistance = 2806,

        CharacterDeboostReceivedDamagePercentMultiplierDistance = 2807,

        CharacterBoostDealtDamagePercentMultiplierWeapon = 2808,

        CharacterDeboostDealtDamagePercentMultiplierWeapon = 2809,

        CharacterBoostReceivedDamagePercentMultiplierWeapon = 2810,

        CharacterDeboostReceivedDamagePercentMultiplierWeapon = 2811,

        CharacterBoostDealtDamagePercentMultiplierSpells = 2812,

        CharacterDeboostDealtDamagePercentMultiplierSpells = 2813,

        CharacterBoostReceivedDamagePercentMultiplierSpells = 2814,

        CharacterDeboostReceivedDamagePercentMultiplierSpells = 2815,

        BoostCharacConvert = 2816,

        BuyInBidHouse = 2817,

        HomeMade = 2818,

        EvolutiveObjectExperience = 2819,

        SuperfoodExperience = 2820,

        EvolutivePetLevel = 2821,

        CharacterLifePointsLostFromBestElement = 2822,

        CharacterPlayEmoticon = 2823,

        BoostAllSpellBaseDmg = 2824,

        PreventFutureSmithmagic = 2825,

        SmithmagicForceWeight = 2826,

        SmithmagicForceProbability = 2827,

        CharacterLifePointsStealFromBestElement = 2828,

        FightSplashRawTakenDamageBestElement = 2829,

        FightSplashFinalTakenDamageBestElement = 2830,

        Wipwipwip = 2831,

        CharacterLifePointsLostFromWorstElement = 2832,

        ItemExpiration = 2833,

        CharacterBoostStrengthPercent = 2834,

        CharacterDeboostStrengthPercent = 2835,

        CharacterBoostAgilityPercent = 2836,

        CharacterDeboostAgilityPercent = 2837,

        CharacterBoostIntelligencePercent = 2838,

        CharacterDeboostIntelligencePercent = 2839,

        CharacterBoostChancePercent = 2840,

        CharacterDeboostChancePercent = 2841,

        CharacterBoostWisdomPercent = 2842,

        CharacterDeboostWisdomPercent = 2843,

        CharacterBoostVitalityPercent = 2844,

        CharacterDeboostVitalityPercent = 2845,

        CharacterBoostActionPointsPercent = 2846,

        CharacterDeboostActionPointsPercent = 2847,

        CharacterBoostMovementPointsPercent = 2848,

        CharacterDeboostMovementPointsPercent = 2849,

        CharacterBoostTakleBlockPercent = 2850,

        CharacterDeboostTakleBlockPercent = 2851,

        CharacterBoostTakleEvadePercent = 2852,

        CharacterDeboostTakleEvadePercent = 2853,

        CharacterBoostActionPointsLostDodgePercent = 2854,

        CharacterDeboostActionPointsLostDodgePercent = 2855,

        CharacterBoostMovementPointsLostDodgePercent = 2856,

        CharacterDeboostMovementPointsLostDodgePercent = 2857,

        CharacterBoostApAttackPercent = 2858,

        CharacterDeboostApAttackPercent = 2859,

        CharacterBoostMpAttackPercent = 2860,

        CharacterDeboostMpAttackPercent = 2861,

        LegendaryStatus = 2862,

        LegendaryPowerSpell = 2864,

        CharacterGainXpWoBoost = 2865,

        CharacterBoostXpCoeff = 2867,

        CharacterAddScalePercent = 2868,

        CharacterBoostJobXpCoeff = 2869,

        CharacterLowerScalePercent = 2871,

        CharacterBoostThreshold = 2872,

        BreachResetRoomSeed = 2873,

        BreachResetRoomChallenge = 2874,

        CharacterLearnSpellForgettable = 2875,

        FightValidateChallenge = 2876,

        FightInvalidateChallenge = 2877,

        GainLevel = 2878,

        CharacterInventoryAddPerfectItemCheck = 2879,

        ItemCustomEffect = 2880,

        SelfPiloting = 2881,

        DistributeGameaction = 2882,

        SetTurnWaitingTime = 2883,

        CharacterSendInformationTextToMap = 2884,

        CharacterSendInformationTextToSubarea = 2885,

        CharacterSendInformationTextToArea = 2886,

        CharacterSendInformationTextToWorld = 2887,

        Unknown = 2888,

        CharacterOpenGuildStorage = 2889,

        CharacterLifePointsStealFromWorstElement = 2890,

        FightSplashFinalTakenDamageWorstElement = 2891,

        CharacterAddAlteration = 2892,

        CharacterRemoveAlteration = 2893,

        CharacterSpeedMultiplier = 2894,

        ItemTeleportGroupToMe = 2895,

        FightSplashRawTakenDamageWorstElement = 2896,

        CharacterLimitStats = 2897,

        MultiplyVictoryPointsAva = 2898,

        MultiplyDefeatPointsAva = 2899,

        SeeAlliesRoleAva = 2900,

        SeeOpponentRoleAva = 2901,

        TeamPointsLostAva = 2902,

        StorePointsAva = 2903,

        SpendPointsAva = 2904,

        SetSpellRangeMax = 2905,

        SetSpellRangeMin = 2906,

        AddPrismCristal = 2907,

        BoostPortalFreeCellOff = 2908,

        BoostPortalProjectionOn = 2909,

        BoostPortalProjectionOff = 2910,

        BoostPortalFreeCellOn = 2911,

        SetSpellApCost = 2913,

        DisableSpellRangeable = 2914,

        EnableSpellNolineofsight = 2915,

        SetSpellMaxpertarget = 2916,

        DeboostSpellMaxpertarget = 2917,

        SetSpellMaxperturn = 2918,

        DeboostSpellMaxperturn = 2919,

        BoostSpellCastGlobalIntvl = 2920,

        DeboostSpellCastGlobalIntvl = 2921,

        SetSpellCastGlobalIntvl = 2922,

        BoostSpellMaxStack = 2923,

        DeboostSpellMaxStack = 2924,

        SetSpellMaxStack = 2925,

        DeboostSpellCriticalHit = 2926,

        SetSpellCriticalHit = 2927,

        DeboostSpellHeal = 2928,

        SetSpellHeal = 2929,

        DeboostSpellDmg = 2930,

        SetSpellDmg = 2931,

        EnableSpellCastoutline = 2932,

        DisableSpellCastoutdiagonal = 2933,

        EnableSpellCastoutdiagonal = 2934,

        BoostSpellBaseHeal = 2935,

        CasterExecuteSpellOnCell = 2960,

        CharacterBoostDealtHealPercentMultiplier = 2971,

        CharacterDeboostDealtHealPercentMultiplier = 2972,

        FightCasterSplashHeal = 2973,

        FightSplashRawInflictedDamageAir = 2974,

        FightSplashRawInflictedDamageWater = 2975,

        FightSplashRawInflictedDamageFire = 2976,

        FightSplashRawInflictedDamageEarth = 2977,

        FightSplashRawInflictedDamageNeutral = 2978,

        FightSplashRawInflictedDamageBestElement = 2979,

        FightSplashRawInflictedDamageWorstElement = 2980,

        FightSplashRawInflictedDamage = 2981,

        FightSplashFinalInflictedDamageAir = 2982,

        FightSplashFinalInflictedDamageWater = 2983,

        FightSplashFinalInflictedDamageFire = 2984,

        FightSplashFinalInflictedDamageEarth = 2985,

        FightSplashFinalInflictedDamageNeutral = 2986,

        FightSplashFinalInflictedDamageBestElement = 2987,

        FightSplashFinalInflictedDamageWorstElement = 2988,

        FightSplashFinalInflictedDamage = 2989,

        CharacterReduceMaximumSummonedCreatures = 2990,

        LockPrismModule = 2991,

        CharacterReadGuide = 2992,

        CharacterRenameInvalidAlliance = 2993,

        ReducePrismDurabilityReduction = 2994,

        TeamPointsWinAva = 2995,

        DurationHour = 2996,

        CharacterLearnSpellTemporaryMutant = 2997,

        CharacterLifePointsWinFromWater = 2998,

        CharacterLifePointsWinFromAir = 2999,

        CharacterLifePointsWinFromEarth = 3000,

        CharacterLifePointsWinFromNeutral = 3001,

        CharacterLifePointsWinFromBestElement = 3002,

        RefreshMarkQuest = 3003,

        InventoryRemoveItem = 3004,

        CharacterLeaveGuild = 3005,

        CharacterLifePointsWinFromWorstElement = 3006,

        StartDialogWithNpc = 3007,

        CharacterTriggerChoice = 3008,

        PlayAnimationOnMap = 3009,

        PlayAnimationOnNpc = 3010,

        PlaySpellScriptOnNpc = 3011,

        PlayEmoteOnNpc = 3012,

        ExecuteSpellScriptUsage = 3792
    }
}