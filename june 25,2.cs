/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System
class sum {
   public static void Main() {
     Console.Write("Enter a value: ");
        int a = Convert.ToInt32(Console.ReadLine());
 
        Console.Write("Enter b value: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        int result1 = a+b;
        Console.WriteLine("a+b", a,b,a+b);
         int result2 = a-b;
        Console.WriteLine("a-b", a,b,a-b);
         int result3 = a*b;
        Console.WriteLine("a*b", a,b,a*b);
         int result4 = a/b;
        Console.WriteLine("a/b", a/b,a/b);
        
  }
}
