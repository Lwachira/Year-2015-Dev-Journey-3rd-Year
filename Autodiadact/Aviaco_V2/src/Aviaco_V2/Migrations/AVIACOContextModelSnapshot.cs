using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Aviaco_V2.Models;

namespace Aviaco_V2.Migrations
{
    [DbContext(typeof(AVIACOContext))]
    partial class AVIACOContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aviaco_V2.Models.AIRCRAFT", b =>
                {
                    b.Property<string>("AC_NUMBER")
                        .HasAnnotation("MaxLength", 5)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<decimal?>("AC_TTAF")
                        .HasAnnotation("Relational:ColumnType", "numeric");

                    b.Property<decimal?>("AC_TTEL")
                        .HasAnnotation("Relational:ColumnType", "numeric");

                    b.Property<decimal?>("AC_TTER")
                        .HasAnnotation("Relational:ColumnType", "numeric");

                    b.Property<string>("MOD_CODE")
                        .HasAnnotation("MaxLength", 10)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.HasKey("AC_NUMBER");
                });

            modelBuilder.Entity("Aviaco_V2.Models.CHARTER", b =>
                {
                    b.Property<int>("CHAR_TRIP");

                    b.Property<string>("AC_NUMBER")
                        .HasAnnotation("MaxLength", 5)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<DateTime?>("CHAR_DATE")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("CHAR_DESTINATION")
                        .HasAnnotation("MaxLength", 3)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<int?>("CHAR_DISTANCE");

                    b.Property<decimal?>("CHAR_FUEL_GALLONS")
                        .HasAnnotation("Relational:ColumnType", "numeric");

                    b.Property<decimal?>("CHAR_HOURS_FLOWN")
                        .HasAnnotation("Relational:ColumnType", "numeric");

                    b.Property<decimal?>("CHAR_HOURS_WAIT")
                        .HasAnnotation("Relational:ColumnType", "numeric");

                    b.Property<int?>("CHAR_OIL_QTS");

                    b.Property<int>("CUS_CODE");

                    b.HasKey("CHAR_TRIP");
                });

            modelBuilder.Entity("Aviaco_V2.Models.CUSTOMER", b =>
                {
                    b.Property<int>("CUS_CODE");

                    b.Property<string>("CUS_AREACODE")
                        .HasAnnotation("MaxLength", 3)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<decimal?>("CUS_BALANCE")
                        .HasAnnotation("Relational:ColumnType", "numeric");

                    b.Property<string>("CUS_FNAME")
                        .HasAnnotation("MaxLength", 15)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("CUS_INITIAL")
                        .HasAnnotation("MaxLength", 1)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<string>("CUS_LNAME")
                        .HasAnnotation("MaxLength", 15)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("CUS_PHONE")
                        .HasAnnotation("MaxLength", 8)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.HasKey("CUS_CODE");
                });

            modelBuilder.Entity("Aviaco_V2.Models.CUSTOMER_MAINT", b =>
                {
                    b.Property<int>("CUS_CODE");

                    b.Property<string>("CUS_AREACODE")
                        .HasAnnotation("MaxLength", 3)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<string>("CUS_FNAME")
                        .HasAnnotation("MaxLength", 15)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("CUS_INITIAL")
                        .HasAnnotation("MaxLength", 1)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<string>("CUS_LNAME")
                        .HasAnnotation("MaxLength", 15)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("CUS_PHONE")
                        .HasAnnotation("MaxLength", 8)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.HasKey("CUS_CODE");
                });

            modelBuilder.Entity("Aviaco_V2.Models.EARNEDRATING", b =>
                {
                    b.Property<int>("EMP_NUM");

                    b.Property<string>("RTG_CODE")
                        .HasAnnotation("MaxLength", 5)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<DateTime?>("EARNRTG_DATE")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.HasKey("EMP_NUM", "RTG_CODE");
                });

            modelBuilder.Entity("Aviaco_V2.Models.EMPLOYEE", b =>
                {
                    b.Property<int>("EMP_NUM");

                    b.Property<DateTime?>("EMP_DOB")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("EMP_FNAME")
                        .HasAnnotation("MaxLength", 15)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<DateTime?>("EMP_HIRE_DATE")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("EMP_INITIAL")
                        .HasAnnotation("MaxLength", 1)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<string>("EMP_LNAME")
                        .HasAnnotation("MaxLength", 15)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("EMP_TITLE")
                        .HasAnnotation("MaxLength", 4)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.HasKey("EMP_NUM");
                });

            modelBuilder.Entity("Aviaco_V2.Models.MODEL", b =>
                {
                    b.Property<string>("MOD_CODE")
                        .HasAnnotation("MaxLength", 10)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<decimal?>("MOD_CHG_MILE")
                        .HasAnnotation("Relational:ColumnType", "numeric");

                    b.Property<string>("MOD_MANUFACTURER")
                        .HasAnnotation("MaxLength", 15)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<string>("MOD_NAME")
                        .HasAnnotation("MaxLength", 20)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<int?>("MOD_SEATS");

                    b.HasKey("MOD_CODE");
                });

            modelBuilder.Entity("Aviaco_V2.Models.PILOT", b =>
                {
                    b.Property<int>("EMP_NUM");

                    b.Property<string>("PIL_LICENSE")
                        .HasAnnotation("MaxLength", 25)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.Property<DateTime?>("PIL_MED_DATE")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("PIL_MED_TYPE")
                        .HasAnnotation("MaxLength", 1)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<DateTime?>("PIL_PT135_DATE")
                        .HasAnnotation("Relational:ColumnType", "datetime");

                    b.Property<string>("PIL_RATINGS")
                        .HasAnnotation("MaxLength", 30)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.HasKey("EMP_NUM");
                });

            modelBuilder.Entity("Aviaco_V2.Models.RATING", b =>
                {
                    b.Property<string>("RTG_CODE")
                        .HasAnnotation("MaxLength", 5)
                        .HasAnnotation("Relational:ColumnType", "char");

                    b.Property<string>("RTG_NAME")
                        .HasAnnotation("MaxLength", 50)
                        .HasAnnotation("Relational:ColumnType", "varchar");

                    b.HasKey("RTG_CODE");
                });

            modelBuilder.Entity("Aviaco_V2.Models.sysdiagrams", b =>
                {
                    b.Property<int>("diagram_id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("definition")
                        .HasAnnotation("Relational:ColumnType", "varbinary");

                    b.Property<int>("principal_id");

                    b.Property<int?>("version");

                    b.HasKey("diagram_id");
                });

            modelBuilder.Entity("Aviaco_V2.Models.AIRCRAFT", b =>
                {
                    b.HasOne("Aviaco_V2.Models.MODEL")
                        .WithMany()
                        .HasForeignKey("MOD_CODE");
                });

            modelBuilder.Entity("Aviaco_V2.Models.CHARTER", b =>
                {
                    b.HasOne("Aviaco_V2.Models.AIRCRAFT")
                        .WithMany()
                        .HasForeignKey("AC_NUMBER");

                    b.HasOne("Aviaco_V2.Models.CUSTOMER")
                        .WithMany()
                        .HasForeignKey("CUS_CODE");
                });

            modelBuilder.Entity("Aviaco_V2.Models.EARNEDRATING", b =>
                {
                    b.HasOne("Aviaco_V2.Models.EMPLOYEE")
                        .WithMany()
                        .HasForeignKey("EMP_NUM");

                    b.HasOne("Aviaco_V2.Models.RATING")
                        .WithMany()
                        .HasForeignKey("RTG_CODE");
                });

            modelBuilder.Entity("Aviaco_V2.Models.PILOT", b =>
                {
                    b.HasOne("Aviaco_V2.Models.EMPLOYEE")
                        .WithOne()
                        .HasForeignKey("Aviaco_V2.Models.PILOT", "EMP_NUM");
                });
        }
    }
}
