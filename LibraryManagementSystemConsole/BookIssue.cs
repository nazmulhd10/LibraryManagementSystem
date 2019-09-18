using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystemConsole
{
    class BookIssue
    {
        public int IssueId { get; set; }
        public int StudentId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime IssueDate { get; set; }
    }
}
