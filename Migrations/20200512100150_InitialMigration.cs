using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace eGreeting.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CardName = table.Column<string>(maxLength: 50, nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    IsActive = table.Column<byte>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(maxLength: 50, nullable: false),
                    IsActive = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Subject = table.Column<string>(maxLength: 50, nullable: false),
                    Content = table.Column<string>(maxLength: 1000, nullable: false),
                    IsChecked = table.Column<byte>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.FeedbackId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentInfos",
                columns: table => new
                {
                    PayId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    BankName = table.Column<string>(maxLength: 50, nullable: false),
                    BankAccount = table.Column<long>(nullable: false),
                    DateExpire = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentInfos", x => x.PayId);
                });

            migrationBuilder.CreateTable(
                name: "SubscribeLists",
                columns: table => new
                {
                    SubscribeId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    SubscribeEmail = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscribeLists", x => x.SubscribeId);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    Receiver = table.Column<string>(maxLength: 50, nullable: false),
                    Subject = table.Column<string>(maxLength: 100, nullable: false),
                    Content = table.Column<string>(maxLength: 1000, nullable: false),
                    CardId = table.Column<int>(nullable: false),
                    TransImage = table.Column<string>(maxLength: 50, nullable: true),
                    Status = table.Column<byte>(nullable: false),
                    TimeSend = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<byte>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Role = table.Column<byte>(nullable: false),
                    IsActive = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserName);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "CardName", "CategoryId", "DateCreated", "ImageName", "IsActive" },
                values: new object[,]
                {
                    { 1, "Birthday-01", 1, new DateTime(2020, 5, 12, 17, 1, 49, 557, DateTimeKind.Local).AddTicks(9773), "b-image1.png", (byte)1 },
                    { 29, "NewYear-12", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(726), "n-image12.jpg", (byte)1 },
                    { 31, "NewYear-14", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(730), "n-image14.jpg", (byte)1 },
                    { 32, "NewYear-15", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(733), "n-image15.jpg", (byte)1 },
                    { 33, "NewYear-16", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(734), "n-image16.jpg", (byte)1 },
                    { 34, "NewYear-17", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(736), "n-image17.jpg", (byte)1 },
                    { 35, "NewYear-18", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(738), "n-image18.jpg", (byte)1 },
                    { 36, "Festival-01", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(740), "f-image1.png", (byte)1 },
                    { 37, "Festival-02", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(742), "f-image2.jpg", (byte)1 },
                    { 38, "Festival-03", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(744), "f-image3.jpg", (byte)1 },
                    { 39, "Festival-04", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(746), "f-image4.jpg", (byte)1 },
                    { 40, "Festival-05", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(748), "f-image5.jpg", (byte)1 },
                    { 28, "NewYear-11", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(724), "n-image11.jpg", (byte)1 },
                    { 41, "Festival-06", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(749), "f-image6.jpg", (byte)1 },
                    { 43, "Festival-08", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(753), "f-image8.png", (byte)1 },
                    { 44, "Festival-09", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(755), "f-image9.png", (byte)1 },
                    { 45, "Festival-10", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(757), "f-image10.png", (byte)1 },
                    { 46, "Festival-11", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(759), "f-image11.png", (byte)1 },
                    { 47, "Festival-12", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(761), "f-image12.png", (byte)1 },
                    { 48, "Festival-13", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(763), "f-image13.jpg", (byte)1 },
                    { 49, "Festival-14", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(765), "f-image14.jpg", (byte)1 },
                    { 50, "Festival-15", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(767), "f-image15.png", (byte)1 },
                    { 51, "Festival-16", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(769), "f-image16.jpg", (byte)1 },
                    { 52, "Festival-17", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(771), "f-image17.png", (byte)1 },
                    { 53, "Festival-18", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(773), "f-image18.jpg", (byte)1 },
                    { 42, "Festival-07", 3, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(751), "f-image7.jpg", (byte)1 },
                    { 27, "NewYear-10", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(723), "n-image10.png", (byte)1 },
                    { 30, "NewYear-13", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(728), "n-image13.jpg", (byte)1 },
                    { 25, "NewYear-08", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(719), "n-image8.png", (byte)1 },
                    { 2, "Birthday-02", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(657), "b-image2.png", (byte)1 },
                    { 3, "Birthday-03", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(673), "b-image3.png", (byte)1 },
                    { 4, "Birthday-04", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(675), "b-image4.png", (byte)1 },
                    { 5, "Birthday-05", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(677), "b-image5.png", (byte)1 },
                    { 6, "Birthday-06", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(680), "b-image6.png", (byte)1 },
                    { 7, "Birthday-07", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(682), "b-image7.png", (byte)1 },
                    { 8, "Birthday-08", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(684), "b-image8.jpg", (byte)1 },
                    { 9, "Birthday-09", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(686), "b-image9.png", (byte)1 },
                    { 10, "Birthday-10", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(688), "b-image10.png", (byte)1 },
                    { 26, "NewYear-09", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(721), "n-image9.png", (byte)1 },
                    { 12, "Birthday-12", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(692), "b-image12.png", (byte)1 },
                    { 13, "Birthday-13", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(694), "b-image13.png", (byte)1 },
                    { 11, "Birthday-11", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(690), "b-image11.png", (byte)1 },
                    { 15, "Birthday-15", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(698), "b-image15.png", (byte)1 },
                    { 24, "NewYear-07", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(717), "n-image7.png", (byte)1 },
                    { 14, "Birthday-14", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(696), "b-image14.png", (byte)1 },
                    { 22, "NewYear-05", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(713), "n-image5.jpg", (byte)1 },
                    { 21, "NewYear-04", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(711), "n-image4.jpg", (byte)1 },
                    { 20, "NewYear-03", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(710), "n-image3.png", (byte)1 },
                    { 23, "NewYear-06", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(715), "n-image6.jpg", (byte)1 },
                    { 54, "NewYear-01", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(706), "n-image1.png", (byte)1 },
                    { 18, "Birthday-18", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(704), "b-image18.png", (byte)0 },
                    { 17, "Birthday-17", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(701), "b-image17.png", (byte)1 },
                    { 16, "Birthday-16", 1, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(700), "b-image16.png", (byte)1 },
                    { 19, "NewYear-02", 2, new DateTime(2020, 5, 12, 17, 1, 49, 558, DateTimeKind.Local).AddTicks(708), "n-image2.jpg", (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "IsActive" },
                values: new object[,]
                {
                    { 1, "Birthday", (byte)1 },
                    { 2, "Newyear", (byte)1 },
                    { 3, "Festival", (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackId", "Content", "DateCreated", "IsChecked", "Subject", "Username" },
                values: new object[] { 1, "Hello Handsome Guys", new DateTime(2020, 5, 12, 17, 1, 49, 555, DateTimeKind.Local).AddTicks(5584), (byte)0, "user", "user" });

            migrationBuilder.InsertData(
                table: "PaymentInfos",
                columns: new[] { "PayId", "BankAccount", "BankName", "DateCreated", "DateExpire", "IsActive", "UserName" },
                values: new object[] { 1, 9405123465478545L, "ACB", null, new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)0, "user" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransId", "CardId", "Content", "Receiver", "Status", "Subject", "TimeSend", "TransImage", "Username" },
                values: new object[] { 1, 0, "Hello your 30! Wish you see many many lucky with this old, happiness and healthy", "receiver@gmail.com", (byte)0, "Happy Birthday my friend", new DateTime(2020, 5, 12, 17, 1, 49, 557, DateTimeKind.Local).AddTicks(1685), "b-image1.png", "user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserName", "Email", "FullName", "Gender", "IsActive", "Password", "Phone", "Role" },
                values: new object[,]
                {
                    { "admin", "admin@egreeting.com", "Admin", (byte)1, (byte)1, "admin1234", "0762327226", (byte)0 },
                    { "user", "test@gmail.com", "Test User", (byte)1, (byte)1, "123123123", "0762371254", (byte)1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "PaymentInfos");

            migrationBuilder.DropTable(
                name: "SubscribeLists");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
