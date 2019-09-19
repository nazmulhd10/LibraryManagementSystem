using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

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
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<BookInfo> BookInfos { get; set; }
        public DbSet<BookIssue> BookIssues { get; set; }
        public DbSet<ReturnBook> returnBooks { get; set; }
    }
}
