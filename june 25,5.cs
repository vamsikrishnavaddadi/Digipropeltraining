/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
public class triple sum {
  static void Main(string[] args)
        {
            int a=2,b=2;
         Console.WriteLine("enter the sum of a,b values");
         Console.WriteLine("enter the value of a:",a);
         a = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("enter the value of b:",b);
         b = Convert.ToInt32(Console.ReadLine());
         if(a==b)
         {
             int c =(a+b)*(a+b)*(a+b);
             Console.WriteLine("sum of triple integers:"+c);
             Console.ReadLine();
         }
        }
}