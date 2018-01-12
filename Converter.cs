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
            String postfix = "";
            Stack<char> st = new Stack<char>();

            foreach (char t in infix)
            {
                if (!"+-*/()".Contains(t))
                {
                    postfix = postfix + t;
                }
                else if (')' == t)
                {
                    while (st.Pop() != '(' && !"+-*/".Contains(t))
                    {
                        st.Pop();
                        postfix = postfix + t;
                    }
                }
                else ()
            }

        }
    }

}