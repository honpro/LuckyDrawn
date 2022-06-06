using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectAlta.Migrations
{
    public partial class ProjectAltaDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Gmail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "CharsetBarcode",
                columns: table => new
                {
                    CharsetBarcodeID = table.Column<int>(type: "int", nullable: false),
                    CharsetBarcodeName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharsetBarcode", x => x.CharsetBarcodeID);
                });

            migrationBuilder.CreateTable(
                name: "CharsetType",
                columns: table => new
                {
                    CharsetTypeID = table.Column<int>(type: "int", nullable: false),
                    Charset = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharsetType", x => x.CharsetTypeID);
                });

            migrationBuilder.CreateTable(
                name: "CodeDetail",
                columns: table => new
                {
                    CodeDetailID = table.Column<int>(type: "int", nullable: false),
                    BarcodeID = table.Column<int>(type: "int", nullable: true),
                    UsageLimit = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProgramName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeDetail", x => x.CodeDetailID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerType",
                columns: table => new
                {
                    CustomerPypeID = table.Column<int>(type: "int", nullable: false),
                    CustomerPypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerType", x => x.CustomerPypeID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypeofBussiness",
                columns: table => new
                {
                    CustomerTypeofBussinessID = table.Column<int>(type: "int", nullable: false),
                    CustomerTypeofBussinessName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypeofBussiness", x => x.CustomerTypeofBussinessID);
                });

            migrationBuilder.CreateTable(
                name: "Gifts",
                columns: table => new
                {
                    GiftsID = table.Column<int>(type: "int", nullable: false),
                    GiftsName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    CreaterDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gifts", x => x.GiftsID);
                });

            migrationBuilder.CreateTable(
                name: "RulesForGifts",
                columns: table => new
                {
                    RulesForGiftsID = table.Column<int>(type: "int", nullable: false),
                    RulesForGiftsName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Schedule = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    Probability = table.Column<int>(type: "int", nullable: true),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RulesForGifts", x => x.RulesForGiftsID);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    SettingID = table.Column<int>(type: "int", nullable: false),
                    QRCodeSetting = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LandingPage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SMSText = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: true),
                    SendtoMail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.SettingID);
                });

            migrationBuilder.CreateTable(
                name: "TimeFrame",
                columns: table => new
                {
                    TimeFrameID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeFrame", x => x.TimeFrameID);
                });

            migrationBuilder.CreateTable(
                name: "TypeBarcode",
                columns: table => new
                {
                    TypeBarcodeID = table.Column<int>(type: "int", nullable: false),
                    TypeBarcodeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeBarcode", x => x.TypeBarcodeID);
                });

            migrationBuilder.CreateTable(
                name: "TypeCode",
                columns: table => new
                {
                    TypeCodeID = table.Column<int>(type: "int", nullable: false),
                    TypeCodeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeCode", x => x.TypeCodeID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CustomerPhone = table.Column<string>(type: "char(11)", unicode: false, fixedLength: true, maxLength: 11, nullable: false),
                    CustomerBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerPosition = table.Column<int>(type: "int", nullable: true),
                    CustomerLocaltion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CustomerStatus = table.Column<bool>(type: "bit", nullable: true),
                    CustomerTypeofBussinessID = table.Column<int>(type: "int", nullable: true),
                    CustomerTypeofBussinessName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    Block = table.Column<bool>(type: "bit", nullable: true),
                    AccountUserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customer_Account_AccountUserID",
                        column: x => x.AccountUserID,
                        principalTable: "Account",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customer_CustomerTypeofBussiness_CustomerTypeofBussinessID",
                        column: x => x.CustomerTypeofBussinessID,
                        principalTable: "CustomerTypeofBussiness",
                        principalColumn: "CustomerTypeofBussinessID");
                });

            migrationBuilder.CreateTable(
                name: "GiftsOfCampign",
                columns: table => new
                {
                    GiftsOfCampignID = table.Column<int>(type: "int", nullable: false),
                    GiftsOfCampignName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CodeCount = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    GiftsID = table.Column<int>(type: "int", nullable: true),
                    ExpriredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GiftsID1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftsOfCampign", x => x.GiftsOfCampignID);
                    table.ForeignKey(
                        name: "FK_GiftsOfCampign_Gifts_GiftsID1",
                        column: x => x.GiftsID1,
                        principalTable: "Gifts",
                        principalColumn: "GiftsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Barcode",
                columns: table => new
                {
                    BarcodeID = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CodeLeght = table.Column<int>(type: "int", nullable: true),
                    CharsetBarcodeName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    TypeBarcodeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CharsetBarcodeID = table.Column<int>(type: "int", nullable: true),
                    TypeBarcodeID = table.Column<int>(type: "int", nullable: true),
                    Prefix = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Profix = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CountCode = table.Column<int>(type: "int", nullable: true),
                    CodeDetailID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barcode", x => x.BarcodeID);
                    table.ForeignKey(
                        name: "FK_Barcode_CharsetBarcode_CharsetBarcodeID",
                        column: x => x.CharsetBarcodeID,
                        principalTable: "CharsetBarcode",
                        principalColumn: "CharsetBarcodeID");
                    table.ForeignKey(
                        name: "FK_Barcode_CodeDetail_CodeDetailID",
                        column: x => x.CodeDetailID,
                        principalTable: "CodeDetail",
                        principalColumn: "CodeDetailID");
                    table.ForeignKey(
                        name: "FK_Barcode_TypeBarcode_TypeBarcodeID",
                        column: x => x.TypeBarcodeID,
                        principalTable: "TypeBarcode",
                        principalColumn: "TypeBarcodeID");
                });

            migrationBuilder.CreateTable(
                name: "ProgramSize",
                columns: table => new
                {
                    ProgramSizeID = table.Column<int>(type: "int", nullable: false),
                    ProgramName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CodeLegth = table.Column<int>(type: "int", nullable: true),
                    Prefix = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Profix = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CharsetTypeID = table.Column<int>(type: "int", nullable: true),
                    Charset = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TypeCodeID = table.Column<int>(type: "int", nullable: true),
                    TypeCodeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CountCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramSize", x => x.ProgramSizeID);
                    table.ForeignKey(
                        name: "FK_ProgramSize_CharsetType_CharsetTypeID",
                        column: x => x.CharsetTypeID,
                        principalTable: "CharsetType",
                        principalColumn: "CharsetTypeID");
                    table.ForeignKey(
                        name: "FK_ProgramSize_TypeCode_TypeCodeID",
                        column: x => x.TypeCodeID,
                        principalTable: "TypeCode",
                        principalColumn: "TypeCodeID");
                });

            migrationBuilder.CreateTable(
                name: "BarcodesUsageHistory",
                columns: table => new
                {
                    BarcodesUsageHistoryID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Scaned = table.Column<bool>(type: "bit", nullable: true),
                    ScannedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BarcodeID = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SpinDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsedForSpin = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarcodesUsageHistory", x => x.BarcodesUsageHistoryID);
                    table.ForeignKey(
                        name: "FK_BarcodesUsageHistory_Barcode_BarcodeID",
                        column: x => x.BarcodeID,
                        principalTable: "Barcode",
                        principalColumn: "BarcodeID");
                    table.ForeignKey(
                        name: "FK_BarcodesUsageHistory_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Barcode_CharsetBarcodeID",
                table: "Barcode",
                column: "CharsetBarcodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Barcode_CodeDetailID",
                table: "Barcode",
                column: "CodeDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Barcode_TypeBarcodeID",
                table: "Barcode",
                column: "TypeBarcodeID");

            migrationBuilder.CreateIndex(
                name: "IX_BarcodesUsageHistory_BarcodeID",
                table: "BarcodesUsageHistory",
                column: "BarcodeID");

            migrationBuilder.CreateIndex(
                name: "IX_BarcodesUsageHistory_CustomerID",
                table: "BarcodesUsageHistory",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AccountUserID",
                table: "Customer",
                column: "AccountUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CustomerTypeofBussinessID",
                table: "Customer",
                column: "CustomerTypeofBussinessID");

            migrationBuilder.CreateIndex(
                name: "IX_GiftsOfCampign_GiftsID1",
                table: "GiftsOfCampign",
                column: "GiftsID1");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramSize_CharsetTypeID",
                table: "ProgramSize",
                column: "CharsetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramSize_TypeCodeID",
                table: "ProgramSize",
                column: "TypeCodeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarcodesUsageHistory");

            migrationBuilder.DropTable(
                name: "CustomerType");

            migrationBuilder.DropTable(
                name: "GiftsOfCampign");

            migrationBuilder.DropTable(
                name: "ProgramSize");

            migrationBuilder.DropTable(
                name: "RulesForGifts");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "TimeFrame");

            migrationBuilder.DropTable(
                name: "Barcode");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Gifts");

            migrationBuilder.DropTable(
                name: "CharsetType");

            migrationBuilder.DropTable(
                name: "TypeCode");

            migrationBuilder.DropTable(
                name: "CharsetBarcode");

            migrationBuilder.DropTable(
                name: "CodeDetail");

            migrationBuilder.DropTable(
                name: "TypeBarcode");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "CustomerTypeofBussiness");
        }
    }
}
