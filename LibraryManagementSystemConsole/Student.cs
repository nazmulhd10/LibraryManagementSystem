using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystemConsole
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StdPhone { get; set; }
        public double FineAmount { get; set; }
        public IList<BookIssue> BookIssues { get; set; }
        public IList<ReturnBook> BookReturns { get; set; }
    }
}
