using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace dofus_unity_rendering_back.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoundScriptUsageDataRecords",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    order = table.Column<int>(type: "integer", nullable: false),
                    scriptId = table.Column<int>(type: "integer", nullable: false),
                    spellLevels = table.Column<long[]>(type: "bigint[]", nullable: false),
                    criterion = table.Column<string>(type: "text", nullable: false),
                    casterMask = table.Column<string>(type: "text", nullable: false),
                    targetMask = table.Column<string>(type: "text", nullable: false),
                    targetZone = table.Column<string>(type: "text", nullable: false),
                    activationMask = table.Column<string>(type: "text", nullable: false),
                    activationZone = table.Column<string>(type: "text", nullable: false),
                    random = table.Column<int>(type: "integer", nullable: false),
                    randomGroup = table.Column<int>(type: "integer", nullable: false),
                    sequenceGroup = table.Column<int>(type: "integer", nullable: false),
                    isTargetTreatedAsCaster = table.Column<bool>(type: "boolean", nullable: false),
                    areTargetsAffectedConcurrently = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoundScriptUsageDataRecords", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EffectInstanceDiceRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    diceNum = table.Column<int>(type: "integer", nullable: false),
                    diceSide = table.Column<int>(type: "integer", nullable: false),
                    effectUid = table.Column<int>(type: "integer", nullable: false),
                    baseEffectId = table.Column<short>(type: "smallint", nullable: false),
                    effectId = table.Column<int>(type: "integer", nullable: false),
                    order = table.Column<int>(type: "integer", nullable: false),
                    targetId = table.Column<short>(type: "smallint", nullable: false),
                    targetMask = table.Column<string>(type: "text", nullable: false),
                    duration = table.Column<short>(type: "smallint", nullable: false),
                    random = table.Column<float>(type: "real", nullable: false),
                    group = table.Column<short>(type: "smallint", nullable: false),
                    modificator = table.Column<short>(type: "smallint", nullable: false),
                    dispellable = table.Column<byte>(type: "smallint", nullable: false),
                    delay = table.Column<byte>(type: "smallint", nullable: false),
                    triggers = table.Column<string>(type: "text", nullable: false),
                    effectElement = table.Column<short>(type: "smallint", nullable: false),
                    spellId = table.Column<short>(type: "smallint", nullable: false),
                    visibleInTooltip = table.Column<bool>(type: "boolean", nullable: false),
                    visibleInBuffUi = table.Column<bool>(type: "boolean", nullable: false),
                    visibleInFightLog = table.Column<bool>(type: "boolean", nullable: false),
                    visibleOnTerrain = table.Column<bool>(type: "boolean", nullable: false),
                    forClientOnly = table.Column<bool>(type: "boolean", nullable: false),
                    trigger = table.Column<bool>(type: "boolean", nullable: false),
                    zoneSize = table.Column<byte>(type: "smallint", nullable: false),
                    zoneShape = table.Column<byte>(type: "smallint", nullable: false),
                    zoneMinSize = table.Column<byte>(type: "smallint", nullable: false),
                    zoneStopAtTarget = table.Column<bool>(type: "boolean", nullable: false),
                    category = table.Column<int>(type: "integer", nullable: false),
                    value = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EffectInstanceDiceRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EffectsRecords",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descriptionId = table.Column<int>(type: "integer", nullable: false),
                    iconId = table.Column<int>(type: "integer", nullable: false),
                    characteristic = table.Column<int>(type: "integer", nullable: false),
                    category = table.Column<int>(type: "integer", nullable: false),
                    showInTooltip = table.Column<bool>(type: "boolean", nullable: false),
                    useDice = table.Column<bool>(type: "boolean", nullable: false),
                    forceMinMax = table.Column<bool>(type: "boolean", nullable: false),
                    boost = table.Column<bool>(type: "boolean", nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false),
                    oppositeId = table.Column<int>(type: "integer", nullable: false),
                    theoreticalDescriptionId = table.Column<string>(type: "text", nullable: false),
                    theoreticalPattern = table.Column<int>(type: "integer", nullable: false),
                    showInSet = table.Column<bool>(type: "boolean", nullable: false),
                    bonusType = table.Column<short>(type: "smallint", nullable: false),
                    useInFight = table.Column<bool>(type: "boolean", nullable: false),
                    effectPriority = table.Column<int>(type: "integer", nullable: false),
                    effectPowerRate = table.Column<float>(type: "real", nullable: false),
                    elementId = table.Column<int>(type: "integer", nullable: false),
                    isInPercent = table.Column<bool>(type: "boolean", nullable: false),
                    hideValueInTooltip = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EffectsRecords", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MonsterDropCoefficientRecords",
                columns: table => new
                {
                    monsterId = table.Column<int>(type: "integer", nullable: false),
                    monsterGrade = table.Column<int>(type: "integer", nullable: false),
                    dropCoefficient = table.Column<float>(type: "real", nullable: false),
                    criteria = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterDropCoefficientRecords", x => new { x.monsterGrade, x.monsterId });
                });

            migrationBuilder.CreateTable(
                name: "MonstersRecords",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameId = table.Column<int>(type: "integer", nullable: false),
                    gfxId = table.Column<int>(type: "integer", nullable: false),
                    race = table.Column<short>(type: "smallint", nullable: false),
                    look = table.Column<string>(type: "text", nullable: false),
                    subareas = table.Column<long[]>(type: "bigint[]", nullable: false),
                    spells = table.Column<List<int>>(type: "integer[]", nullable: false),
                    spellGrades = table.Column<List<string>>(type: "text[]", nullable: false),
                    favoriteSubareaId = table.Column<int>(type: "integer", nullable: false),
                    correspondingMiniBossId = table.Column<int>(type: "integer", nullable: false),
                    speedAdjust = table.Column<short>(type: "smallint", nullable: false),
                    creatureBoneId = table.Column<short>(type: "smallint", nullable: false),
                    incompatibleIdols = table.Column<long[]>(type: "bigint[]", nullable: false),
                    incompatibleChallenges = table.Column<long[]>(type: "bigint[]", nullable: false),
                    aggressiveZoneSize = table.Column<byte>(type: "smallint", nullable: false),
                    aggressiveLevelDiff = table.Column<short>(type: "smallint", nullable: false),
                    aggressiveImmunityCriterion = table.Column<string>(type: "text", nullable: false),
                    aggressiveAttackDelay = table.Column<short>(type: "smallint", nullable: false),
                    scaleGradeRef = table.Column<byte>(type: "smallint", nullable: false),
                    useSummonSlot = table.Column<bool>(type: "boolean", nullable: false),
                    useBombSlot = table.Column<bool>(type: "boolean", nullable: false),
                    isBoss = table.Column<bool>(type: "boolean", nullable: false),
                    isMiniBoss = table.Column<bool>(type: "boolean", nullable: false),
                    isQuestMonster = table.Column<bool>(type: "boolean", nullable: false),
                    fastAnimsFun = table.Column<bool>(type: "boolean", nullable: false),
                    canPlay = table.Column<bool>(type: "boolean", nullable: false),
                    canTackle = table.Column<bool>(type: "boolean", nullable: false),
                    canBePushed = table.Column<bool>(type: "boolean", nullable: false),
                    canSwitchPos = table.Column<bool>(type: "boolean", nullable: false),
                    canSwitchPosOnTarget = table.Column<bool>(type: "boolean", nullable: false),
                    canBeCarried = table.Column<bool>(type: "boolean", nullable: false),
                    canUsePortal = table.Column<bool>(type: "boolean", nullable: false),
                    allIdolsDisabled = table.Column<bool>(type: "boolean", nullable: false),
                    useRaceValues = table.Column<bool>(type: "boolean", nullable: false),
                    soulCaptureForbidden = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonstersRecords", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SpellLevelsRecords",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    spellId = table.Column<short>(type: "smallint", nullable: false),
                    grade = table.Column<int>(type: "integer", nullable: false),
                    spellBreed = table.Column<int>(type: "integer", nullable: false),
                    apCost = table.Column<short>(type: "smallint", nullable: false),
                    minRange = table.Column<byte>(type: "smallint", nullable: false),
                    range = table.Column<byte>(type: "smallint", nullable: false),
                    criticalHitProbability = table.Column<short>(type: "smallint", nullable: false),
                    maxStack = table.Column<short>(type: "smallint", nullable: false),
                    maxCastPerTurn = table.Column<short>(type: "smallint", nullable: false),
                    maxCastPerTarget = table.Column<byte>(type: "smallint", nullable: false),
                    minCastInterval = table.Column<byte>(type: "smallint", nullable: false),
                    initialCooldown = table.Column<short>(type: "smallint", nullable: false),
                    globalCooldown = table.Column<short>(type: "smallint", nullable: false),
                    minPlayerLevel = table.Column<short>(type: "smallint", nullable: false),
                    statesCriterion = table.Column<string>(type: "text", nullable: false),
                    hideEffects = table.Column<bool>(type: "boolean", nullable: false),
                    hidden = table.Column<bool>(type: "boolean", nullable: false),
                    playAnimation = table.Column<bool>(type: "boolean", nullable: false),
                    castInLine = table.Column<bool>(type: "boolean", nullable: false),
                    castInDiagonal = table.Column<bool>(type: "boolean", nullable: false),
                    castTestLos = table.Column<bool>(type: "boolean", nullable: false),
                    needFreeCell = table.Column<bool>(type: "boolean", nullable: false),
                    needTakenCell = table.Column<bool>(type: "boolean", nullable: false),
                    needFreeTrapCell = table.Column<bool>(type: "boolean", nullable: false),
                    rangeCanBeBoosted = table.Column<bool>(type: "boolean", nullable: false),
                    needVisibleEntity = table.Column<bool>(type: "boolean", nullable: false),
                    needCellWithoutPortal = table.Column<bool>(type: "boolean", nullable: false),
                    portalProjectionForbidden = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellLevelsRecords", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SpellsRecords",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameId = table.Column<int>(type: "integer", nullable: false),
                    descriptionId = table.Column<int>(type: "integer", nullable: false),
                    typeId = table.Column<int>(type: "integer", nullable: false),
                    order = table.Column<byte>(type: "smallint", nullable: false),
                    scriptParams = table.Column<string>(type: "text", nullable: false),
                    scriptParamsCritical = table.Column<string>(type: "text", nullable: false),
                    scriptId = table.Column<byte>(type: "smallint", nullable: false),
                    scriptIdCritical = table.Column<byte>(type: "smallint", nullable: false),
                    iconId = table.Column<short>(type: "smallint", nullable: false),
                    spellLevels = table.Column<long[]>(type: "bigint[]", nullable: false),
                    adminName = table.Column<string>(type: "text", nullable: false),
                    verboseCast = table.Column<bool>(type: "boolean", nullable: false),
                    bypassSummoningLimit = table.Column<bool>(type: "boolean", nullable: false),
                    canAlwaysTriggerSpells = table.Column<bool>(type: "boolean", nullable: false),
                    hideCastConditions = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellsRecords", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SpellVariantsRecords",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    breedId = table.Column<int>(type: "integer", nullable: false),
                    spellIds = table.Column<long[]>(type: "bigint[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellVariantsRecords", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TranslatedLabelRecords",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    languageCode = table.Column<string>(type: "text", nullable: false),
                    label = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedLabelRecords", x => new { x.id, x.languageCode });
                });

            migrationBuilder.CreateTable(
                name: "AnimFunMonsterRecords",
                columns: table => new
                {
                    animId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Monstersid = table.Column<int>(type: "integer", nullable: true),
                    entityId = table.Column<int>(type: "integer", nullable: false),
                    animName = table.Column<string>(type: "text", nullable: false),
                    animWeight = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimFunMonsterRecords", x => x.animId);
                    table.ForeignKey(
                        name: "FK_AnimFunMonsterRecords_MonstersRecords_Monstersid",
                        column: x => x.Monstersid,
                        principalTable: "MonstersRecords",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "MonsterDropRecords",
                columns: table => new
                {
                    dropId = table.Column<int>(type: "integer", nullable: false),
                    monsterId = table.Column<int>(type: "integer", nullable: false),
                    objectId = table.Column<int>(type: "integer", nullable: false),
                    percentDropForGrade1 = table.Column<float>(type: "real", nullable: false),
                    percentDropForGrade2 = table.Column<float>(type: "real", nullable: false),
                    percentDropForGrade3 = table.Column<float>(type: "real", nullable: false),
                    percentDropForGrade4 = table.Column<float>(type: "real", nullable: false),
                    percentDropForGrade5 = table.Column<float>(type: "real", nullable: false),
                    count = table.Column<int>(type: "integer", nullable: false),
                    criteria = table.Column<string>(type: "text", nullable: false),
                    hasCriteria = table.Column<bool>(type: "boolean", nullable: false),
                    hiddenIfInvalidCriteria = table.Column<bool>(type: "boolean", nullable: false),
                    Monstersid = table.Column<int>(type: "integer", nullable: true),
                    Monstersid1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterDropRecords", x => new { x.objectId, x.dropId, x.monsterId });
                    table.ForeignKey(
                        name: "FK_MonsterDropRecords_MonstersRecords_Monstersid",
                        column: x => x.Monstersid,
                        principalTable: "MonstersRecords",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_MonsterDropRecords_MonstersRecords_Monstersid1",
                        column: x => x.Monstersid1,
                        principalTable: "MonstersRecords",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "MonsterGradeRecords",
                columns: table => new
                {
                    grade = table.Column<int>(type: "integer", nullable: false),
                    monsterId = table.Column<int>(type: "integer", nullable: false),
                    level = table.Column<int>(type: "integer", nullable: false),
                    lifePoints = table.Column<int>(type: "integer", nullable: false),
                    actionPoints = table.Column<short>(type: "smallint", nullable: false),
                    movementPoints = table.Column<short>(type: "smallint", nullable: false),
                    vitality = table.Column<int>(type: "integer", nullable: false),
                    paDodge = table.Column<short>(type: "smallint", nullable: false),
                    pmDodge = table.Column<short>(type: "smallint", nullable: false),
                    wisdom = table.Column<int>(type: "integer", nullable: false),
                    earthResistance = table.Column<short>(type: "smallint", nullable: false),
                    airResistance = table.Column<short>(type: "smallint", nullable: false),
                    fireResistance = table.Column<short>(type: "smallint", nullable: false),
                    waterResistance = table.Column<short>(type: "smallint", nullable: false),
                    neutralResistance = table.Column<short>(type: "smallint", nullable: false),
                    gradeXp = table.Column<int>(type: "integer", nullable: false),
                    damageReflect = table.Column<byte>(type: "smallint", nullable: false),
                    hiddenLevel = table.Column<byte>(type: "smallint", nullable: false),
                    strength = table.Column<int>(type: "integer", nullable: false),
                    intelligence = table.Column<int>(type: "integer", nullable: false),
                    chance = table.Column<int>(type: "integer", nullable: false),
                    agility = table.Column<int>(type: "integer", nullable: false),
                    startingSpellId = table.Column<int>(type: "integer", nullable: false),
                    bonusRange = table.Column<short>(type: "smallint", nullable: false),
                    Monstersid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterGradeRecords", x => new { x.grade, x.monsterId });
                    table.ForeignKey(
                        name: "FK_MonsterGradeRecords_MonstersRecords_Monstersid",
                        column: x => x.Monstersid,
                        principalTable: "MonstersRecords",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Monstersid = table.Column<int>(type: "integer", nullable: false),
                    spellsDataid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => new { x.Monstersid, x.spellsDataid });
                    table.ForeignKey(
                        name: "FK_Spells_MonstersRecords_Monstersid",
                        column: x => x.Monstersid,
                        principalTable: "MonstersRecords",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spells_SpellsRecords_spellsDataid",
                        column: x => x.spellsDataid,
                        principalTable: "SpellsRecords",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimFunMonsterRecords_Monstersid",
                table: "AnimFunMonsterRecords",
                column: "Monstersid");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterDropRecords_Monstersid",
                table: "MonsterDropRecords",
                column: "Monstersid");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterDropRecords_Monstersid1",
                table: "MonsterDropRecords",
                column: "Monstersid1");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterGradeRecords_Monstersid",
                table: "MonsterGradeRecords",
                column: "Monstersid");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_spellsDataid",
                table: "Spells",
                column: "spellsDataid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimFunMonsterRecords");

            migrationBuilder.DropTable(
                name: "BoundScriptUsageDataRecords");

            migrationBuilder.DropTable(
                name: "EffectInstanceDiceRecords");

            migrationBuilder.DropTable(
                name: "EffectsRecords");

            migrationBuilder.DropTable(
                name: "MonsterDropCoefficientRecords");

            migrationBuilder.DropTable(
                name: "MonsterDropRecords");

            migrationBuilder.DropTable(
                name: "MonsterGradeRecords");

            migrationBuilder.DropTable(
                name: "SpellLevelsRecords");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "SpellVariantsRecords");

            migrationBuilder.DropTable(
                name: "TranslatedLabelRecords");

            migrationBuilder.DropTable(
                name: "MonstersRecords");

            migrationBuilder.DropTable(
                name: "SpellsRecords");
        }
    }
}
