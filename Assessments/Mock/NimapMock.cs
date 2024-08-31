using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.Mock
{
    public class NimapMock
    {
        static void Main(string[] args)
        {
           
            for(int i = 1;i<=100;i++)
            {
                if(CheckPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
        static bool CheckPrime(int num)
        {
            if(num<=1)
                return false;
            else
            {
                int ct = 0;
                for(int i=2;i<num;i++)
                {
                    if(num%i==0)
                    {
                        ct++;
                        break;
                    }
                }
                return ct == 0;
            }
        }
        //find count of char in string
        static void FindCount(string s)
        {
            int ct = 0;
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                ct++;
            }

           
            Console.WriteLine("Count of Characters:"+ct);
        }
        //find smallest,largest,second largest,second smallest
        static void FindLargestSmallest(int[] arr)
        {
            int large = int.MinValue, small = int.MaxValue;
            int secondLarge=large,secondSmall=small;

            for (int i = 0;i < arr.Length; i++)
            {
                if (small > arr[i])
                {
                    secondSmall = small;
                    small = arr[i];
                }else if (secondSmall > arr[i])
                {
                    secondSmall = arr[i];
                }
                if (large < arr[i])
                {
                    secondLarge = large;
                    large = arr[i];
                }
                else if (secondLarge < arr[i])
                {
                    secondLarge = arr[i];
                }
            }
            Console.WriteLine($"Largest={large},Smallest={small}");
            Console.WriteLine($"Second Largest={secondLarge},Second Smallest={secondSmall}");
        }
        //find next palindrome
        static bool CheckPalindrome(int num)
        {
            int temp = num;
            int rev = 0;
            while(num>0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            return rev==temp;
        }
        static int NextPalindrome(int num)
        {
            num++;
            while (!CheckPalindrome(num))
            {
                num++;
            }

            return num;

        }
        //find count of each character in string
        static void CountOfEachCharacter(string s)
        {
            int ct;
            bool flag;

            char[] ch= s.ToCharArray();

            for(int i=0;i<ch.Length;i++)
            {
                ct = 1;
                flag = false;
                for(int j=i-1;j>=0;j--)
                {
                    if (ch[i] == ch[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if(!flag)
                {
                    for(int k=i+1;k<ch.Length;k++)
                    {
                        if (ch[i] == ch[k])
                        {
                            ct++;
                        }
                    }
                    Console.WriteLine(ch[i]+":"+ct);
                }
            }

        }

    }
}
