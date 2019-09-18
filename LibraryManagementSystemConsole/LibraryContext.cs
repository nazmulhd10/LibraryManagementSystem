using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace LibraryManagementSystemConsole
{
    public class LibraryContext : DbContext
    {
        private string _connectionstring;

        public LibraryContext()
        {
            _connectionstring= "Server=LAPTOP-SV7TD0RB\\SQLEXPRESS;Database = LibraryManagemtn;User Id='';Password='';";
        }
        public LibraryContext(string connectionString)
        {
            _connectionstring = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionstring);
            }
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<BookInfo> BookInfos { get; set; }
    }
}
