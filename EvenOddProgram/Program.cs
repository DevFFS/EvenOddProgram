using System;
namespace EvenOddProgram
{
    public class Program
    {
        static void Main()
        {
            //print all primes upto n numbers
            /*int n;
            n =Convert.ToInt32(Console.ReadLine());
            for(int number=2; number<=n; number++) {
                int count = 0;
                for(int i=1;i<=number;i++)
                {
                    if(number%i==0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.Write(number + " ");
                }
            }*/


            //check prime or not
            /*int number;
            number=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i=1; i<=number; i++)
            { 
                if(number%i==0)
                {
                    count++;
                }
            
            }
            if (count == 2)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }*/

            //fibonacci without recursion
            /*int noOfElements;
            noOfElements=Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1;
            int n3;
            Console.Write(n1 + " " + n2 +" ");
            for(int i=2; i<noOfElements; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
                
            }*/

            //even odd program
            /*int a;
            Console.WriteLine("Enter Number");
            a= Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("even");

            }
            else
            {
                Console.WriteLine("odd");
            }*/
        }
    }
}