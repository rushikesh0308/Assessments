using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.MovieCrud
{
    public class MovieDriver
    {
        static void Main(string[] args)
        {
            MovieCRUD cd=new MovieCRUD();
            int choice;
            char ch;
            Console.WriteLine("\t---WELCOME---");
            Console.WriteLine("--------------------------");
            do
            {
                Console.WriteLine("1.Add Movies" + "\n2.Update Ticket Price" + "\n3.Show All Movies" + "\n4.Search Movie by ID \n5.Search Movie By Name" + "\n6.Delete Movie \n7.Exit");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Enter choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        cd.InsertMovie();
                        break;
                    case 2:
                        if (cd.Update())
                        {
                            Console.WriteLine("Price Succssfully Updated!");

                        }
                        else
                        {
                            Console.WriteLine("ID Not Found!");
                        }
                        break;
                    case 3:
                        cd.Display();
                        break;
                    case 4:
                        if (cd.Search())
                        {
                            Console.WriteLine("--Movie--");
                        }
                        else
                        {
                            Console.WriteLine("ID Not Found!");
                        }
                        break;
                    case 5:
                        if (cd.SearchByName())
                        {
                            Console.WriteLine("--Movie--");
                        }
                        else
                        {
                            Console.WriteLine("Name Not Found!");
                        }
                        break;
                    case 6:
                        if (cd.Delete())
                        {
                            Console.WriteLine("---Movie Deleted!---");
                        }
                        else
                        {
                            Console.WriteLine("---ID Not Found!---");
                        }
                        break;
                        case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;

                }
                Console.WriteLine("Do you want to continue?(Yes-Y/No-N)");
                ch = Convert.ToChar(Console.ReadLine());
            }
            while (ch == 'Y' || ch == 'y');
        }
    }
}

