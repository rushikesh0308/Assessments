using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.MovieCrud
{
    public class MovieCRUD
    {
        Movie[] m = new Movie[3];
        int mid;
        string mname;
        double ticket;
        string producer;
        int count;
        public void InsertMovie()
        {

            Console.WriteLine("Enter no of movies you want to add:");
            int size=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <size; i++)
            {
                Console.WriteLine("Enter Movie ID :");
                mid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Movie Name :");
                mname = Console.ReadLine();
                Console.WriteLine("Enter Ticket Cost :");
                ticket = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Producer Name: ");
                producer = Console.ReadLine();

                m[count] = new Movie { MovieId = mid, MovieName = mname, TicketCost = ticket, ProducerName = producer };
                count++;
                Console.WriteLine("----Successfully Added----");
            }
        }
        public void Display()
        {
            if (count == 0)
            {
                Console.WriteLine("---No Movies Available---");
            }
            else
            {
                Console.WriteLine("--All Movies--");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(m[i]);
                }
            }
        }
        public bool Search()
        {
            
            int id;
            bool flag = false;
            Console.WriteLine("\nEnter Movie ID To Search Movie :");
            id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                if (id == m[i].MovieId)
                {
                    Console.WriteLine(m[i]);
                    flag = true;
                    break;
                }

            }
            return flag;
        }
        public bool SearchByName()
        {

            string mname;
            bool flag = false;
            Console.WriteLine("\nEnter Movie name To Search Movie :");
            mname =Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                if (mname.Equals(m[i].MovieName))
                {
                    Console.WriteLine(m[i]);
                    flag = true;
                    break;
                }

            }
            return flag;
        }
        public bool Update()
        {
            bool flag = false;
            Console.WriteLine("--Update Ticket Price--");
            Console.WriteLine("\nEnter Movie ID To Update Price: ");
            int id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                if (id == m[i].MovieId)
                {
                    Console.WriteLine("Enter The Updated Price");
                    double price = Convert.ToDouble(Console.ReadLine());

                    m[i].TicketCost = price;

                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public bool Delete()
        {
            bool flag = false;
            Console.WriteLine("--Delete Movie--");
            Console.WriteLine("\nEnter Movie ID To Delete Movie");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                if (id == m[i].MovieId)
                {
                    m[i] = null;
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}
