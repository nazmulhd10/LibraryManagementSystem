using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystemConsole
{
    public class BookIssue
    {
        public int IssueId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int BookId { get; set; }

        public BookInfo bookinfo { get; set; }
        public string BookBarCode { get; set; }
        public int UserId { get; set; }
        public DateTime IssueDate { get; set; }
    }
}
