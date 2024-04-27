using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.MethodAssignment
{
    public class Account
    {
        protected int accno;
        protected string name;
        protected float amount;

        public Account()
        {
            accno=0;
            name = "";
            amount = 0;
        }
        public Account(int accno,string name,float amount)
        {
            this.accno = accno;
            this.name = name;
            this.amount = amount;
        }
        public void Insert(int accno, string name, float amount)
        {
            this.accno = accno;
            this.name = name;
            this.amount = amount;
        }
        public string Display()
        {
            return $"AccNo={accno},name={name},amount={amount}";
        }
        public void Deposit(float damount)
        {
            amount=amount+damount;

            Console.WriteLine($"Balance after deposit:{amount}");
        }
        public void Withdraw(float wamount)
        {
            if (amount >= wamount)
            {
                amount = amount - wamount;
                Console.WriteLine($"Balance after withdraw:{amount}");
            }
            else {
                Console.WriteLine("Insufficient Balance!");
            }
        }
        public void CheckBalance()
        {
            Console.WriteLine($"Your Account Balance is:{amount}");
        }
        static void Main(string[] args)
        {
            Account account = new Account(101,"Rohit",10000);
            account.CheckBalance();
            account.Deposit(5000);
            account.Withdraw(8000);
        }
    }
}
