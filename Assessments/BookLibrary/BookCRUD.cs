using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.BookLibrary
{
    public class BookCRUD
    {
        Book[] books=new Book[3];
        int ct=0;

        public void AddBook()
        {
            Console.WriteLine("Enter no of books you want to add:");
            int size = Convert.ToInt32(Console.ReadLine()); 

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter book id:");
                int bid=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter book name:");
                string bname=Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter Author:");
                string bauthor=Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter book price:");
                double bprice=Convert.ToDouble(Console.ReadLine());

                books[ct] = new Book {BookId=bid,BookName=bname,BookAuthor=bauthor,BookPrice=bprice };
                Console.WriteLine("-----------------------------");
                ct++;
            }
        }
        public void UpdateBook()
        {
            Console.WriteLine("Enter book id you want to update:");
            int id= Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<ct;i++)
            {
                if (books[i].BookId==id && books[i]!=null)
                {
                    Console.WriteLine("Enter new price:");
                    double price= Convert.ToDouble(Console.ReadLine());

                    books[i].BookPrice=price;

                    Console.WriteLine("book price updated!");
                }
                else
                {
                    Console.WriteLine("id not present!");
                }
            }
        }
        public bool DeleteBook()
        {
            Console.WriteLine("Enter book id you want to delete");
            int id=Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for(int i=0;i<ct;i++)
            {
                if (books[i].BookId==id && books[i]!=null)
                {
                    books[i] = null;
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public void SearchBookById()
        {
            Console.WriteLine("Enter book id you want to search");
            int id = Convert.ToInt32(Console.ReadLine());

            bool flag = false;
            for (int i = 0; i < ct; i++)
            {
                if (books[i].BookId == id && books[i] != null)
                {
                    Console.WriteLine(books[i]);
                    flag = true;
                    break;
                }
            }
            if(!flag)
                Console.WriteLine("id not present!");
        }
        public void ShowBooks()
        {
            for(int i=0;i<ct;i++)
            {
                if (books[i]!=null)
                {
                    Console.WriteLine(books[i]);
                }
            }
        }
    }
}
