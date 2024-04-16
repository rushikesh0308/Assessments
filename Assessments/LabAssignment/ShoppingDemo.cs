using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class ShoppingDemo
    {
        static void Main(string[] args)
        {
            Shopping s1 = new Shopping();
            s1.AcceptValues();
            s1.CalculateTotalPrice();
            s1.DisplayShoppingDetails();
        }
    }
}
