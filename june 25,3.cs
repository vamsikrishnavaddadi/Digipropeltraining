/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Average
{
  static void Main() 
  {
    int number1,number2,number3,number4;
    
        Console.WriteLine("Enter the first number :");
        number1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the second number :");
         number2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter third number :");
         number3 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter fourth number  :");
         number4 = Convert.ToInt32(Console.ReadLine());
        
        int result = (number1 + number2 + number3 + number4)/4;
        
        Console.WriteLine("The average of number1, number2, number3, number4, result");
        Console.ReadLine();
    }
    
}