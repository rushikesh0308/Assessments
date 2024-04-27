using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.BookLibrary
{
    public class BookDriver
    {

        static void Main(string[] args)
        {
            BookCRUD obj= new BookCRUD();
            int choice;
            char ch;

            do
            {
                Console.WriteLine("1.Add Books\n2.Update Book Price \n3.Search Book by Id \n4.Delete Book \n5.Show All Books");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Enter your choice:");
                choice =Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        obj.AddBook();
                        Console.WriteLine("books added successfully!");
                        break;
                    case 2:
                        obj.UpdateBook(); break;
                    case 3:
                        obj.SearchBookById(); break;
                    case 4:
                        bool result=obj.DeleteBook();
                        if (result)
                            Console.WriteLine("book deleted");
                        else
                            Console.WriteLine("please check id!");
                        break;
                    case 5:
                        obj.ShowBooks(); break;
                    default:
                        Console.WriteLine("invalid choice!");
                        break;
                }
                Console.WriteLine("Do you want to continue?(Y-yes/N-No)");
                ch=Convert.ToChar(Console.ReadLine());
            } while (ch=='Y' || ch=='y');

        }
    }
}
