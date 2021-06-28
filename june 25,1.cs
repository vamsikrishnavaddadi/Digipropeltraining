/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
public class multiply
{
  public static void Main()
  {
    int a,b,c;
     
    Console.Write("Input the first number to multiply: ");
    a = Convert.ToInt32(Console.ReadLine());
     
    Console.Write("Input the second number to multiply: ");
    b = Convert.ToInt32(Console.ReadLine());
     
    Console.Write("Input the third number to multiply: ");
    c = Convert.ToInt32(Console.ReadLine());
    
            int d = a * b * c;
            Console.WriteLine("Multiplication of three numbers: " + d);
            Console.ReadLine();
     
    
  }
}
