using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LoopAssigmnet1
{
    internal class Program
    {
       /* static void Main(string[] args)
        {
            //  1.Display numbers from 1 to 100.
            Console.WriteLine(" number from 1 to 100 is ");
            for (int i = 1; i <= 100; i++) {
                Console.WriteLine(i);
            }


            //2.Display all even numbers from 1 to 100.
            Console.WriteLine("Even number from 1 to 100 is ");
            for (int i = 1; i <= 100; i++) {

                if (i % 2 == 0)
                {
                   
                    Console.WriteLine(i);
                }
                   
            }


            //3.Display all odd numbers from 200 to 300.
            Console.WriteLine("Odd number from 200 to 300 is ");

            for (int i = 200; i <= 300; i++) {

                if (i % 2 != 0) {

                    Console.WriteLine(i);
                }
            }

            //4.Display the seventh element between 400 to 500(both numbers excluded).
            Console.WriteLine("Display the seventh element between 400 to 500(both numbers excluded ");
            int num = 401;
            int count = 0;
            while (num < 500) {
                count++;
                if (count == 7) {
                    Console.WriteLine($"Seven number is {num}");
                    break;
                }
                num++;
            
            }

            //5.Find the first 10 even numbers. 

            int count1 = 0;
            for (int i = 0; count1 < 10; i++) {
                if (i % 2 == 0) { 
                    Console.WriteLine(i);
                    count1++;
                
                }
               
            }
            //6.Find all prime numbers < 100.
            for (int i = 2; i < 100; i++) {

                if (i<2) {
                   
                
                }
            
            
            }

            //7.Calculate factorial of a number. 
       
            int num7 = 8;
            int fact = 1;
            Console.WriteLine($"factorial of {num7} is :");
            for (int i = 1; i <= num7; i++) {
                fact = fact * i;
                            
            }
            Console.WriteLine($"{fact}");

            //8.Count the number of digits in any number. 
            int num8 = 12345;
            int count8 = 0;
            while (num8 > 0)
            {
                num8 = num8 / 10;
                count8++;
            }
            Console.WriteLine($"Count of digit is: {count8}");

            //11.Generate Fibonacci series. 0,1, 1, 2, 3, 5,8..... k.where k<n . n is entered by user
            int fnum = 0, snum = 1,nextnum=0,k=10;
            Console.WriteLine("Enter value of n:");
            int n=Convert.ToInt32(Console.ReadLine());

            if (k < n) {
                for (int i = 0; i <= k; i++) {

                    nextnum = fnum + snum;
                    fnum = snum;
                    snum= nextnum;
                    Console.WriteLine(nextnum);

                }


            }



            //12.Generate Fibonacci series for first n terms.
            int fnum1 = 0, snum1 = 1, nextnum1 = 0;
            Console.WriteLine("Enter value of n:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            
            
                for (int i = 0; i < n1; i++)
                {

                Console.WriteLine(fnum1);
                nextnum1 = fnum1 + snum1;
                fnum1 = snum1;
                snum1 = nextnum1;
            }




            //13.Find the sum of all digits of a number.
            int num13 = 123456,sum=0,digit=0;
            while (num13 > 0) {

                digit = num13 % 10;
                sum = sum + digit;
                num13 = num13 / 10;
            }
            Console.WriteLine($"Sum of digit is : {sum}");


            //14.Find out if the given number is palindrome or not.
            int num14 = 121,rev=0;
            int temp = num14;
            while (num14 > 0) {

                digit=num14 % 10;
                rev = rev * 10 + digit;
                num14 = num14 / 10;
            }
            if (temp == rev) {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }

            //15.Write a Java program to find the frequency of each digit in a given integer.

            int num15=23456, frequ = 0, digit1=0;
            while (num15 > 0) { 
               digit=digit1 % 10;
                frequ++;
                num15=num15 / 10;
            }
            Console.WriteLine($"Frequency of each digit is {frequ}");

            //16.check no is automorphic or not
            //input n = 25
            //  output Automorphic
            //as 25 * 25 = 625

        } */
    }
}
