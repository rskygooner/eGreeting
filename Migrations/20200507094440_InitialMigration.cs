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
                    NameCard = table.Column<string>(maxLength: 50, nullable: false),
                    Category = table.Column<string>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                });

            migrationBuilder.CreateTable(
                name: "EmailLists",
                columns: table => new
                {
                    EmailId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: false),
                    ListEmail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailLists", x => x.EmailId);
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
                    DataCreated = table.Column<DateTime>(nullable: false)
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
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    BankName = table.Column<string>(maxLength: 50, nullable: false),
                    BankAccount = table.Column<long>(nullable: false),
                    DateExpire = table.Column<DateTime>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentInfos", x => x.PayId);
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
                    NameCard = table.Column<string>(maxLength: 50, nullable: false),
                    ImageNameTrans = table.Column<string>(maxLength: 50, nullable: true),
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
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    RePassword = table.Column<string>(maxLength: 50, nullable: false),
                    Role = table.Column<bool>(nullable: false),
                    IsSubcribeSend = table.Column<bool>(nullable: false),
                    IsSubcribeReceive = table.Column<bool>(nullable: false),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    IsVIP = table.Column<bool>(nullable: false),
                    IsDeactive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "Category", "DateCreated", "ImageName", "NameCard" },
                values: new object[,]
                {
                    { 1, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(5998), "b-image1.png", "Birthday-01" },
                    { 30, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7010), "n-image13.jpg", "NewYear-13" },
                    { 31, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7013), "n-image14.jpg", "NewYear-14" },
                    { 32, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7014), "n-image15.jpg", "NewYear-15" },
                    { 33, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7016), "n-image16.jpg", "NewYear-16" },
                    { 34, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7018), "n-image17.jpg", "NewYear-17" },
                    { 35, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7020), "n-image18.jpg", "NewYear-18" },
                    { 36, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7023), "f-image1.png", "Festival-01" },
                    { 37, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7025), "f-image2.jpg", "Festival-02" },
                    { 38, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7027), "f-image3.jpg", "Festival-03" },
                    { 39, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7028), "f-image4.jpg", "Festival-04" },
                    { 40, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7030), "f-image5.jpg", "Festival-05" },
                    { 28, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7007), "n-image11.jpg", "NewYear-11" },
                    { 41, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7032), "f-image6.jpg", "Festival-06" },
                    { 43, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7036), "f-image8.png", "Festival-08" },
                    { 44, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7038), "f-image9.png", "Festival-09" },
                    { 45, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7040), "f-image10.png", "Festival-10" },
                    { 46, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7042), "f-image11.png", "Festival-11" },
                    { 47, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7043), "f-image12.png", "Festival-12" },
                    { 48, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7045), "f-image13.jpg", "Festival-13" },
                    { 49, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7047), "f-image14.jpg", "Festival-14" },
                    { 50, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7048), "f-image15.png", "Festival-15" },
                    { 51, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7050), "f-image16.jpg", "Festival-16" },
                    { 52, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7052), "f-image17.png", "Festival-17" },
                    { 53, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7054), "f-image18.jpg", "Festival-18" },
                    { 42, "Festival", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7034), "f-image7.jpg", "Festival-07" },
                    { 27, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7005), "n-image10.png", "NewYear-10" },
                    { 29, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7009), "n-image12.jpg", "NewYear-12" },
                    { 25, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7000), "n-image8.png", "NewYear-08" },
                    { 2, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6921), "b-image2.png", "Birthday-02" },
                    { 3, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6956), "b-image3.png", "Birthday-03" },
                    { 4, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6958), "b-image4.png", "Birthday-04" },
                    { 5, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6960), "b-image5.png", "Birthday-05" },
                    { 6, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6962), "b-image6.png", "Birthday-06" },
                    { 7, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6964), "b-image7.png", "Birthday-07" },
                    { 8, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6966), "b-image8.jpg", "Birthday-08" },
                    { 9, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6968), "b-image9.png", "Birthday-09" },
                    { 10, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6970), "b-image10.png", "Birthday-10" },
                    { 11, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6972), "b-image11.png", "Birthday-11" },
                    { 26, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(7003), "n-image9.png", "NewYear-09" },
                    { 13, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6975), "b-image13.png", "Birthday-13" },
                    { 12, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6973), "b-image12.png", "Birthday-12" },
                    { 15, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6980), "b-image15.png", "Birthday-15" },
                    { 24, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6998), "n-image7.png", "NewYear-07" },
                    { 23, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6996), "n-image6.jpg", "NewYear-06" },
                    { 14, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6977), "b-image14.png", "Birthday-14" },
                    { 21, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6993), "n-image4.jpg", "NewYear-04" },
                    { 20, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6990), "n-image3.png", "NewYear-03" },
                    { 22, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6994), "n-image5.jpg", "NewYear-05" },
                    { 54, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6987), "n-image1.png", "NewYear-01" },
                    { 18, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6985), "b-image18.png", "Birthday-18" },
                    { 17, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6983), "b-image17.png", "Birthday-17" },
                    { 16, "Birthday", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6982), "b-image16.png", "Birthday-16" },
                    { 19, "NewYear", new DateTime(2020, 5, 7, 16, 44, 39, 943, DateTimeKind.Local).AddTicks(6989), "n-image2.jpg", "NewYear-02" }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "FeedbackId", "Content", "DataCreated", "Subject", "Username" },
                values: new object[] { 1, "Hello Handsome Guys", new DateTime(2020, 5, 7, 16, 44, 39, 940, DateTimeKind.Local).AddTicks(7443), "test", "test" });

            migrationBuilder.InsertData(
                table: "PaymentInfos",
                columns: new[] { "PayId", "BankAccount", "BankName", "DateCreated", "DateExpire", "IsActive", "UserId", "UserName" },
                values: new object[] { 1, 9405123465478545L, "ACB", null, new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2, "test" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransId", "Content", "ImageNameTrans", "NameCard", "Receiver", "Subject", "TimeSend", "Username" },
                values: new object[] { 1, "Hello your 30! Wish you see many many lucky with this old, happiness and healthy", "b-image1.png", "Birthday-01", "receiver@gmail.com", "Happy Birthday my friend", new DateTime(2020, 5, 7, 16, 44, 39, 942, DateTimeKind.Local).AddTicks(539), "test" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FullName", "Gender", "IsDeactive", "IsSubcribeReceive", "IsSubcribeSend", "IsVIP", "Password", "Phone", "RePassword", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, "admin@egreeting.com", "Admin", true, false, false, false, true, "admin1234", "0762327226", "admin1234", true, "admin" },
                    { 2, "test@gmail.com", "test", true, false, false, false, false, "123123123", "0762371254", "123123123", false, "test" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "EmailLists");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "PaymentInfos");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
