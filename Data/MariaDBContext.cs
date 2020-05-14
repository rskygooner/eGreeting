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
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubscribeList> SubscribeLists { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<PaymentInfo> PaymentInfos { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserName = "admin", Password = "admin1234", FullName = "Admin", Gender = Gender.Male, Email = "admin@egreeting.com", Phone = "0762327226", Role = Role.Admin, IsActive = Status.Active },
                new User { UserName = "user", Password = "123123123", FullName = "Test User", Gender = Gender.Male, Email = "test@gmail.com", Phone = "0762371254", Role = Role.User, IsActive = Status.Active });
            
            modelBuilder.Entity<PaymentInfo>().HasData(new PaymentInfo { PayId = 1, UserName = "user", BankName = "ACB", BankAccount = 9405123465478545, DateExpire = DateTime.ParseExact("2022-01-12", "yyyy-MM-dd", null) });
            
            modelBuilder.Entity<Feedback>().HasData(new Feedback { FeedbackId = 1, Subject = "user", Content = "Hello Handsome Guys", Username = "user", DateCreated = DateTime.Now });

            modelBuilder.Entity<Transaction>().HasData(new Transaction { TransId = 1, Username = "user", Receiver = "receiver@gmail.com", Subject = "Happy Birthday my friend", Content = "Hello your 30! Wish you see many many lucky with this old, happiness and healthy", TransImage = "b-image1.png", TimeSend = DateTime.Now, CardId = 0 });

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Birthday", IsActive = Status.Active },
                new Category { CategoryId = 2, CategoryName = "Newyear", IsActive = Status.Active },
                new Category { CategoryId = 3, CategoryName = "Festival", IsActive = Status.Active }
                );

            modelBuilder.Entity<Card>().HasData(
                new Card { CardId = 1, CardName = "Birthday-01", CategoryId = 1, ImageName = "b-image1.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 2, CardName = "Birthday-02", CategoryId = 1, ImageName = "b-image2.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 3, CardName = "Birthday-03", CategoryId = 1, ImageName = "b-image3.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 4, CardName = "Birthday-04", CategoryId = 1, ImageName = "b-image4.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 5, CardName = "Birthday-05", CategoryId = 1, ImageName = "b-image5.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 6, CardName = "Birthday-06", CategoryId = 1, ImageName = "b-image6.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 7, CardName = "Birthday-07", CategoryId = 1, ImageName = "b-image7.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 8, CardName = "Birthday-08", CategoryId = 1, ImageName = "b-image8.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 9, CardName = "Birthday-09", CategoryId = 1, ImageName = "b-image9.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 10, CardName = "Birthday-10", CategoryId = 1, ImageName = "b-image10.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 11, CardName = "Birthday-11", CategoryId = 1, ImageName = "b-image11.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 12, CardName = "Birthday-12", CategoryId = 1, ImageName = "b-image12.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 13, CardName = "Birthday-13", CategoryId = 1, ImageName = "b-image13.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 14, CardName = "Birthday-14", CategoryId = 1, ImageName = "b-image14.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 15, CardName = "Birthday-15", CategoryId = 1, ImageName = "b-image15.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 16, CardName = "Birthday-16", CategoryId = 1, ImageName = "b-image16.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 17, CardName = "Birthday-17", CategoryId = 1, ImageName = "b-image17.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 18, CardName = "Birthday-18", CategoryId = 1, ImageName = "b-image18.png", DateCreated = DateTime.Now },

                new Card { CardId = 54, CardName = "NewYear-01", CategoryId = 2, ImageName = "n-image1.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 19, CardName = "NewYear-02", CategoryId = 2, ImageName = "n-image2.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 20, CardName = "NewYear-03", CategoryId = 2, ImageName = "n-image3.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 21, CardName = "NewYear-04", CategoryId = 2, ImageName = "n-image4.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 22, CardName = "NewYear-05", CategoryId = 2, ImageName = "n-image5.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 23, CardName = "NewYear-06", CategoryId = 2, ImageName = "n-image6.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 24, CardName = "NewYear-07", CategoryId = 2, ImageName = "n-image7.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 25, CardName = "NewYear-08", CategoryId = 2, ImageName = "n-image8.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 26, CardName = "NewYear-09", CategoryId = 2, ImageName = "n-image9.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 27, CardName = "NewYear-10", CategoryId = 2, ImageName = "n-image10.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 28, CardName = "NewYear-11", CategoryId = 2, ImageName = "n-image11.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 29, CardName = "NewYear-12", CategoryId = 2, ImageName = "n-image12.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 30, CardName = "NewYear-13", CategoryId = 2, ImageName = "n-image13.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 31, CardName = "NewYear-14", CategoryId = 2, ImageName = "n-image14.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 32, CardName = "NewYear-15", CategoryId = 2, ImageName = "n-image15.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 33, CardName = "NewYear-16", CategoryId = 2, ImageName = "n-image16.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 34, CardName = "NewYear-17", CategoryId = 2, ImageName = "n-image17.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 35, CardName = "NewYear-18", CategoryId = 2, ImageName = "n-image18.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },

                new Card { CardId = 36, CardName = "Festival-01", CategoryId = 3, ImageName = "f-image1.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 37, CardName = "Festival-02", CategoryId = 3, ImageName = "f-image2.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 38, CardName = "Festival-03", CategoryId = 3, ImageName = "f-image3.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 39, CardName = "Festival-04", CategoryId = 3, ImageName = "f-image4.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 40, CardName = "Festival-05", CategoryId = 3, ImageName = "f-image5.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 41, CardName = "Festival-06", CategoryId = 3, ImageName = "f-image6.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 42, CardName = "Festival-07", CategoryId = 3, ImageName = "f-image7.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 43, CardName = "Festival-08", CategoryId = 3, ImageName = "f-image8.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 44, CardName = "Festival-09", CategoryId = 3, ImageName = "f-image9.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 45, CardName = "Festival-10", CategoryId = 3, ImageName = "f-image10.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 46, CardName = "Festival-11", CategoryId = 3, ImageName = "f-image11.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 47, CardName = "Festival-12", CategoryId = 3, ImageName = "f-image12.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 48, CardName = "Festival-13", CategoryId = 3, ImageName = "f-image13.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 49, CardName = "Festival-14", CategoryId = 3, ImageName = "f-image14.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 50, CardName = "Festival-15", CategoryId = 3, ImageName = "f-image15.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 51, CardName = "Festival-16", CategoryId = 3, ImageName = "f-image16.jpg", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 52, CardName = "Festival-17", CategoryId = 3, ImageName = "f-image17.png", IsActive = Status.Active, DateCreated = DateTime.Now },
                new Card { CardId = 53, CardName = "Festival-18", CategoryId = 3, ImageName = "f-image18.jpg", IsActive = Status.Active, DateCreated = DateTime.Now });
        }

    }

}
