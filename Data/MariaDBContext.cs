using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGreeting.Models
{
    public class MariaDBContext : DbContext
    {
        public MariaDBContext(DbContextOptions<MariaDBContext> options) : base(options) { }
        public DbSet<Card> Cards { get; set; }
        public DbSet<EmailList> EmailLists { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<PaymentInfo> PaymentInfos { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentInfo>().HasData(new PaymentInfo {PayId = 1, UserId = 2, UserName = "test", BankName = "ACB", BankAccount = 9405123465478545, DateExpire = DateTime.ParseExact("2022-01-12", "yyyy-MM-dd", null) });
            modelBuilder.Entity<Feedback>().HasData(new Feedback {FeedbackId = 1, Subject = "test", Content = "Hello Handsome Guys", Username = "test", DataCreated = DateTime.Now });

            modelBuilder.Entity<Transaction>().HasData(new Transaction {TransId = 1, Username = "test", Receiver = "receiver@gmail.com", Subject = "Happy Birthday my friend", Content = "Hello your 30! Wish you see many many lucky with this old, happiness and healthy", ImageNameTrans = "b-image1.png", TimeSend = DateTime.Now, NameCard = "Birthday-01" });
            modelBuilder.Entity<User>().HasData(
                new User {UserId = 1, UserName = "admin", Password = "admin1234", RePassword = "admin1234", FullName = "Admin", Gender = true, Email = "admin@egreeting.com", Phone = "0762327226", Role = true, IsDeactive = false, IsVIP = true },
                new User {UserId = 2, UserName = "test", Password = "123123123", RePassword = "123123123", FullName = "test", Gender = true, Email = "test@gmail.com", Phone = "0762371254" });
            modelBuilder.Entity<Card>().HasData(
                new Card { CardId = 1, NameCard = "Birthday-01", Category = "Birthday", ImageName = "b-image1.png", DateCreated = DateTime.Now },
                new Card { CardId = 2, NameCard = "Birthday-02", Category = "Birthday", ImageName = "b-image2.png", DateCreated = DateTime.Now },
                new Card { CardId = 3, NameCard = "Birthday-03", Category = "Birthday", ImageName = "b-image3.png", DateCreated = DateTime.Now },
                new Card { CardId = 4, NameCard = "Birthday-04", Category = "Birthday", ImageName = "b-image4.png", DateCreated = DateTime.Now },
                new Card { CardId = 5, NameCard = "Birthday-05", Category = "Birthday", ImageName = "b-image5.png", DateCreated = DateTime.Now },
                new Card { CardId = 6, NameCard = "Birthday-06", Category = "Birthday", ImageName = "b-image6.png", DateCreated = DateTime.Now },
                new Card { CardId = 7, NameCard = "Birthday-07", Category = "Birthday", ImageName = "b-image7.png", DateCreated = DateTime.Now },
                new Card { CardId = 8, NameCard = "Birthday-08", Category = "Birthday", ImageName = "b-image8.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 9, NameCard = "Birthday-09", Category = "Birthday", ImageName = "b-image9.png", DateCreated = DateTime.Now },
                new Card { CardId = 10, NameCard = "Birthday-10", Category = "Birthday", ImageName = "b-image10.png", DateCreated = DateTime.Now },
                new Card { CardId = 11, NameCard = "Birthday-11", Category = "Birthday", ImageName = "b-image11.png", DateCreated = DateTime.Now },
                new Card { CardId = 12, NameCard = "Birthday-12", Category = "Birthday", ImageName = "b-image12.png", DateCreated = DateTime.Now },
                new Card { CardId = 13, NameCard = "Birthday-13", Category = "Birthday", ImageName = "b-image13.png", DateCreated = DateTime.Now },
                new Card { CardId = 14, NameCard = "Birthday-14", Category = "Birthday", ImageName = "b-image14.png", DateCreated = DateTime.Now },
                new Card { CardId = 15, NameCard = "Birthday-15", Category = "Birthday", ImageName = "b-image15.png", DateCreated = DateTime.Now },
                new Card { CardId = 16, NameCard = "Birthday-16", Category = "Birthday", ImageName = "b-image16.png", DateCreated = DateTime.Now },
                new Card { CardId = 17, NameCard = "Birthday-17", Category = "Birthday", ImageName = "b-image17.png", DateCreated = DateTime.Now },
                new Card { CardId = 18, NameCard = "Birthday-18", Category = "Birthday", ImageName = "b-image18.png", DateCreated = DateTime.Now },

                new Card { CardId = 54, NameCard = "NewYear-01", Category = "NewYear", ImageName = "n-image1.png", DateCreated = DateTime.Now },
                new Card { CardId = 19, NameCard = "NewYear-02", Category = "NewYear", ImageName = "n-image2.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 20, NameCard = "NewYear-03", Category = "NewYear", ImageName = "n-image3.png", DateCreated = DateTime.Now },
                new Card { CardId = 21, NameCard = "NewYear-04", Category = "NewYear", ImageName = "n-image4.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 22, NameCard = "NewYear-05", Category = "NewYear", ImageName = "n-image5.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 23, NameCard = "NewYear-06", Category = "NewYear", ImageName = "n-image6.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 24, NameCard = "NewYear-07", Category = "NewYear", ImageName = "n-image7.png", DateCreated = DateTime.Now },
                new Card { CardId = 25, NameCard = "NewYear-08", Category = "NewYear", ImageName = "n-image8.png", DateCreated = DateTime.Now },
                new Card { CardId = 26, NameCard = "NewYear-09", Category = "NewYear", ImageName = "n-image9.png", DateCreated = DateTime.Now },
                new Card { CardId = 27, NameCard = "NewYear-10", Category = "NewYear", ImageName = "n-image10.png", DateCreated = DateTime.Now },
                new Card { CardId = 28, NameCard = "NewYear-11", Category = "NewYear", ImageName = "n-image11.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 29, NameCard = "NewYear-12", Category = "NewYear", ImageName = "n-image12.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 30, NameCard = "NewYear-13", Category = "NewYear", ImageName = "n-image13.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 31, NameCard = "NewYear-14", Category = "NewYear", ImageName = "n-image14.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 32, NameCard = "NewYear-15", Category = "NewYear", ImageName = "n-image15.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 33, NameCard = "NewYear-16", Category = "NewYear", ImageName = "n-image16.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 34, NameCard = "NewYear-17", Category = "NewYear", ImageName = "n-image17.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 35, NameCard = "NewYear-18", Category = "NewYear", ImageName = "n-image18.jpg", DateCreated = DateTime.Now },

                new Card { CardId = 36, NameCard = "Festival-01", Category = "Festival", ImageName = "f-image1.png", DateCreated = DateTime.Now },
                new Card { CardId = 37, NameCard = "Festival-02", Category = "Festival", ImageName = "f-image2.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 38, NameCard = "Festival-03", Category = "Festival", ImageName = "f-image3.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 39, NameCard = "Festival-04", Category = "Festival", ImageName = "f-image4.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 40, NameCard = "Festival-05", Category = "Festival", ImageName = "f-image5.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 41, NameCard = "Festival-06", Category = "Festival", ImageName = "f-image6.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 42, NameCard = "Festival-07", Category = "Festival", ImageName = "f-image7.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 43, NameCard = "Festival-08", Category = "Festival", ImageName = "f-image8.png", DateCreated = DateTime.Now },
                new Card { CardId = 44, NameCard = "Festival-09", Category = "Festival", ImageName = "f-image9.png", DateCreated = DateTime.Now },
                new Card { CardId = 45, NameCard = "Festival-10", Category = "Festival", ImageName = "f-image10.png", DateCreated = DateTime.Now },
                new Card { CardId = 46, NameCard = "Festival-11", Category = "Festival", ImageName = "f-image11.png", DateCreated = DateTime.Now },
                new Card { CardId = 47, NameCard = "Festival-12", Category = "Festival", ImageName = "f-image12.png", DateCreated = DateTime.Now },
                new Card { CardId = 48, NameCard = "Festival-13", Category = "Festival", ImageName = "f-image13.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 49, NameCard = "Festival-14", Category = "Festival", ImageName = "f-image14.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 50, NameCard = "Festival-15", Category = "Festival", ImageName = "f-image15.png", DateCreated = DateTime.Now },
                new Card { CardId = 51, NameCard = "Festival-16", Category = "Festival", ImageName = "f-image16.jpg", DateCreated = DateTime.Now },
                new Card { CardId = 52, NameCard = "Festival-17", Category = "Festival", ImageName = "f-image17.png", DateCreated = DateTime.Now },
                new Card { CardId = 53, NameCard = "Festival-18", Category = "Festival", ImageName = "f-image18.jpg", DateCreated = DateTime.Now });
        }

    }

}
