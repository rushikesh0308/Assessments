using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.StringAssignment
{
    //20.	Accept email_id from user and check valid or not(should contain @,.)
    public class Que20
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your email ID: ");
            string email = Console.ReadLine();

            if (IsValidEmail(email))
            {
                Console.WriteLine("The email ID is valid.");
            }
            else
            {
                Console.WriteLine("The email ID is not valid.");
            }
        }

        static bool IsValidEmail(string email)
        {
            
            if (string.IsNullOrEmpty(email))
                return false;

            
            int atPos = email.IndexOf('@');
            int dotPos = email.LastIndexOf('.');

            
            if (atPos > 0 && dotPos > atPos && dotPos < email.Length - 1)
            {
                return true;
            }

            return false;
        }
    }
 }

