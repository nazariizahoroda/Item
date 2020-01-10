using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using ReactEmpeek.Models;

namespace ReactEmpeek
{
    public class ItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ItemContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "ItemDb.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }
    }
}
