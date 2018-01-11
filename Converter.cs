using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Convert
{
     class Converter
     {
         static void Main()
         {
            Console.WriteLine("Infix expression: ");
            String infix = Console.ReadLine();
            infix = infix.Replace(" ", "");

            for (int i = 0; i < infix.Length; i++)
            {
                String t = infix.Substring(i, i + 1);
                if (t == "+" || t == "-" || t == "*" || t == "/")
                {
                    return t;
                }
            }
            Stack st = new Stack();
             
         }
     }
}