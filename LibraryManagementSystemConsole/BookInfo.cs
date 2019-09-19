using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;

namespace LibraryManagementSystemConsole
{
    public class BookInfo
{
        public int BookId { get; set; }
        [Key]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }
        public string Barcode { get; set; }
        public int CopyCount { get; set; }
    }
}
