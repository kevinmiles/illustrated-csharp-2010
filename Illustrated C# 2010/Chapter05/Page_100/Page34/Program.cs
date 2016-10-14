﻿using System;

namespace Page34
{
   class MyClass
   {
      public int Calc( int a, int b = 3 )
      {
         return a + b;
      }                          

      static void Main()
      {
         MyClass mc = new MyClass();

         int r0 = mc.Calc( 5, 6 );             // Use explicit values.
         int r1 = mc.Calc( 5 );                // Use default for b.

         Console.WriteLine( "{0}, {1}", r0, r1 );
      }
   }
}
