using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Aviaco_V2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CUSTOMER",
                columns: table => new
                {
                    CUS_CODE = table.Column<int>(nullable: false),
                    CUS_AREACODE = table.Column<string>(type: "char", nullable: true),
                    CUS_BALANCE = table.Column<decimal>(type: "numeric", nullable: true),
                    CUS_FNAME = table.Column<string>(type: "varchar", nullable: true),
                    CUS_INITIAL = table.Column<string>(type: "char", nullable: true),
                    CUS_LNAME = table.Column<string>(type: "varchar", nullable: true),
                    CUS_PHONE = table.Column<string>(type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMER", x => x.CUS_CODE);
                });
            migrationBuilder.CreateTable(
                name: "CUSTOMER_MAINT",
                columns: table => new
                {
                    CUS_CODE = table.Column<int>(nullable: false),
                    CUS_AREACODE = table.Column<string>(type: "char", nullable: true),
                    CUS_FNAME = table.Column<string>(type: "varchar", nullable: true),
                    CUS_INITIAL = table.Column<string>(type: "char", nullable: true),
                    CUS_LNAME = table.Column<string>(type: "varchar", nullable: true),
                    CUS_PHONE = table.Column<string>(type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMER_MAINT", x => x.CUS_CODE);
                });
            migrationBuilder.CreateTable(
                name: "EMPLOYEE",
                columns: table => new
                {
                    EMP_NUM = table.Column<int>(nullable: false),
                    EMP_DOB = table.Column<DateTime>(type: "datetime", nullable: true),
                    EMP_FNAME = table.Column<string>(type: "varchar", nullable: true),
                    EMP_HIRE_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    EMP_INITIAL = table.Column<string>(type: "char", nullable: true),
                    EMP_LNAME = table.Column<string>(type: "varchar", nullable: true),
                    EMP_TITLE = table.Column<string>(type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYEE", x => x.EMP_NUM);
                });
            migrationBuilder.CreateTable(
                name: "MODEL",
                columns: table => new
                {
                    MOD_CODE = table.Column<string>(type: "char", nullable: false),
                    MOD_CHG_MILE = table.Column<decimal>(type: "numeric", nullable: true),
                    MOD_MANUFACTURER = table.Column<string>(type: "varchar", nullable: true),
                    MOD_NAME = table.Column<string>(type: "varchar", nullable: true),
                    MOD_SEATS = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MODEL", x => x.MOD_CODE);
                });
            migrationBuilder.CreateTable(
                name: "RATING",
                columns: table => new
                {
                    RTG_CODE = table.Column<string>(type: "char", nullable: false),
                    RTG_NAME = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RATING", x => x.RTG_CODE);
                });
            migrationBuilder.CreateTable(
                name: "sysdiagrams",
                columns: table => new
                {
                    diagram_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    definition = table.Column<byte[]>(type: "varbinary", nullable: true),
                    principal_id = table.Column<int>(nullable: false),
                    version = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sysdiagrams", x => x.diagram_id);
                });
            migrationBuilder.CreateTable(
                name: "PILOT",
                columns: table => new
                {
                    EMP_NUM = table.Column<int>(nullable: false),
                    PIL_LICENSE = table.Column<string>(type: "varchar", nullable: true),
                    PIL_MED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PIL_MED_TYPE = table.Column<string>(type: "char", nullable: true),
                    PIL_PT135_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PIL_RATINGS = table.Column<string>(type: "varchar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PILOT", x => x.EMP_NUM);
                    table.ForeignKey(
                        name: "FK_PILOT_EMPLOYEE_EMP_NUM",
                        column: x => x.EMP_NUM,
                        principalTable: "EMPLOYEE",
                        principalColumn: "EMP_NUM",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "AIRCRAFT",
                columns: table => new
                {
                    AC_NUMBER = table.Column<string>(type: "char", nullable: false),
                    AC_TTAF = table.Column<decimal>(type: "numeric", nullable: true),
                    AC_TTEL = table.Column<decimal>(type: "numeric", nullable: true),
                    AC_TTER = table.Column<decimal>(type: "numeric", nullable: true),
                    MOD_CODE = table.Column<string>(type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AIRCRAFT", x => x.AC_NUMBER);
                    table.ForeignKey(
                        name: "FK_AIRCRAFT_MODEL_MOD_CODE",
                        column: x => x.MOD_CODE,
                        principalTable: "MODEL",
                        principalColumn: "MOD_CODE",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "EARNEDRATING",
                columns: table => new
                {
                    EMP_NUM = table.Column<int>(nullable: false),
                    RTG_CODE = table.Column<string>(type: "char", nullable: false),
                    EARNRTG_DATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EARNEDRATING", x => new { x.EMP_NUM, x.RTG_CODE });
                    table.ForeignKey(
                        name: "FK_EARNEDRATING_EMPLOYEE_EMP_NUM",
                        column: x => x.EMP_NUM,
                        principalTable: "EMPLOYEE",
                        principalColumn: "EMP_NUM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EARNEDRATING_RATING_RTG_CODE",
                        column: x => x.RTG_CODE,
                        principalTable: "RATING",
                        principalColumn: "RTG_CODE",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "CHARTER",
                columns: table => new
                {
                    CHAR_TRIP = table.Column<int>(nullable: false),
                    AC_NUMBER = table.Column<string>(type: "char", nullable: true),
                    CHAR_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    CHAR_DESTINATION = table.Column<string>(type: "char", nullable: true),
                    CHAR_DISTANCE = table.Column<int>(nullable: true),
                    CHAR_FUEL_GALLONS = table.Column<decimal>(type: "numeric", nullable: true),
                    CHAR_HOURS_FLOWN = table.Column<decimal>(type: "numeric", nullable: true),
                    CHAR_HOURS_WAIT = table.Column<decimal>(type: "numeric", nullable: true),
                    CHAR_OIL_QTS = table.Column<int>(nullable: true),
                    CUS_CODE = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHARTER", x => x.CHAR_TRIP);
                    table.ForeignKey(
                        name: "FK_CHARTER_AIRCRAFT_AC_NUMBER",
                        column: x => x.AC_NUMBER,
                        principalTable: "AIRCRAFT",
                        principalColumn: "AC_NUMBER",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CHARTER_CUSTOMER_CUS_CODE",
                        column: x => x.CUS_CODE,
                        principalTable: "CUSTOMER",
                        principalColumn: "CUS_CODE",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("CHARTER");
            migrationBuilder.DropTable("CUSTOMER_MAINT");
            migrationBuilder.DropTable("EARNEDRATING");
            migrationBuilder.DropTable("PILOT");
            migrationBuilder.DropTable("sysdiagrams");
            migrationBuilder.DropTable("AIRCRAFT");
            migrationBuilder.DropTable("CUSTOMER");
            migrationBuilder.DropTable("RATING");
            migrationBuilder.DropTable("EMPLOYEE");
            migrationBuilder.DropTable("MODEL");
        }
    }
}
