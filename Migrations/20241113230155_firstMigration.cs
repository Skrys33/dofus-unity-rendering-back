using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace dofus_unity_rendering_back.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimFunMonsterRecords");

            migrationBuilder.DropTable(
                name: "MonsterDropCoefficientRecords");

            migrationBuilder.DropTable(
                name: "MonsterDropRecords");

            migrationBuilder.DropTable(
                name: "MonsterGradeRecords");

            migrationBuilder.DropTable(
                name: "MonstersRecords");
        }
    }
}
