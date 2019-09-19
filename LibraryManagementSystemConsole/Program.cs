using System;

namespace LibraryManagementSystemConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryContext con = new LibraryContext();
            con.BookInfos.Add(new BookInfo());
            con.UserInfos.Add(new UserInfo());
            con.Students.Add(new Student());
            con.BookIssues.Add(new BookIssue());
            con.returnBooks.Add(new ReturnBook());

            StartPoint: Console.WriteLine("===========================");
            Console.WriteLine("Welcome to library system.");
            Console.WriteLine("Please enter your choice:");
            Console.WriteLine("To entry student information enter: 1");
            Console.WriteLine("To entry book information enter: 2");
            Console.WriteLine("To issue a book, enter: 3");
            Console.WriteLine("To return a book enter: 4");
            Console.WriteLine("To check fine, enter: 5");
            Console.WriteLine("To receive fine, enter: 6");
            Console.WriteLine("===========================");

            int KeyPress = int.Parse(Console.ReadLine());

            if (KeyPress == 1)
            {
                //Student Information
                Console.Clear();
                String GoStart = Console.ReadLine();
                Console.WriteLine("Go Start Point Press: ( * )");
                Console.Write("Please enter student Id:");
                int StudentId = int.Parse(Console.ReadLine());
                Console.Write("Please enter student name:");
                String StudentName = Console.ReadLine();
            }else if (KeyPress == 2)
            {
                //Book Information
                Console.Write("Please enter Book Id:");
                int BookId = int.Parse(Console.ReadLine());
                Console.Write("Please enter Book name:");
                String BooktName = Console.ReadLine();
                Console.Write("Please enter Book Author Name:");
                String BookAuthor = Console.ReadLine();
            }
            else if (KeyPress == 3)
            {
                //issue a book
                Console.Write("Please enter Student Id:");
                int IssueStudentId = int.Parse(Console.ReadLine());
                Console.Write("Please enter Book Id:");
                int IssueBookId = int.Parse(Console.ReadLine());
            }
            else if (KeyPress == 4)
            {
                //return a book
                Console.Write("Please enter Student Id:");
                int returnStudentId = int.Parse(Console.ReadLine());
                Console.Write("Please enter Book Id:");
                int returnBookId = int.Parse(Console.ReadLine());
            }
            else if (KeyPress == 5)
            {
                //check fine
            }else if (KeyPress == 6)
            {
                //receive fine
            }
            else
            {
                Console.WriteLine("Please Press according to above list");
            }

        }
    }
}
