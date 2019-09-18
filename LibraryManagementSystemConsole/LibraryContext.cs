using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace LibraryManagementSystemConsole
{
    public class LibraryContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<BookInfo> BookInfos { get; set; }


    }
}
