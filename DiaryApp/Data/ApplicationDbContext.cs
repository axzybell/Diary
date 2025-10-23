using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry 
                { 
                    Id = 1, 
                    Title="Went Hiking", 
                    Content="When Hiking with Joe!", 
                    DateCreated= new DateTime(2025, 10, 23, 14, 49, 50)
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Went Shopping",
                    Content = "When Shopping with Joe!",
                    DateCreated = new DateTime(2025, 10, 23, 14, 49, 50)
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Went Diving",
                    Content = "When Diving with Joe!",
                    DateCreated = new DateTime(2025, 10, 23, 14, 49, 50)
                }
             );
        }
    }
}
