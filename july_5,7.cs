using System;
namespace Program {
   class Demo {
      static int Main() {
         DateTime date1 = new DateTime(2018, 08, 05);
         Console.WriteLine("Date 1 : {0}", date1);

         DateTime date2 = new DateTime(2018, 08, 07);
         Console.WriteLine("Date 2 : {0}", date2);
         if (date1 < date2)
         Console.WriteLine("{0} comes before {1}", date1, date2);
         Console.ReadLine();
         return 0;
      }
   }
}