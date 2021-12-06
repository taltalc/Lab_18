using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string aboutbreckets = Console.ReadLine();
            Breckets(aboutbreckets);
            Console.ReadKey();
        }
        static void Breckets(string str, char brct1 = '(', char brct2 = ')', char brct3 = '[', char brct4 = ']', char brct5 = '{', char brct6 = '}')
        {
            string breckets = "";
            foreach (char i in str)
            {

                if (i == brct1 || i == brct2 || i == brct3 || i == brct4 || i == brct5 || i == brct6)
                    breckets += i;
            }

            Stack<char> Brecketsin = new Stack<char>();
            foreach (char i in breckets)
            {
                if (i == brct1)
                {
                    Brecketsin.Push(brct2);
                }
                else if (i == brct3)
                {
                    Brecketsin.Push(brct4);
                }
                else if (i == brct5)
                {
                    Brecketsin.Push(brct6);
                }
                else
                {
                    char top = Brecketsin.Pop();
                    if ((top == brct2 && i != brct2) || (top == brct4 && i != brct4) || (top == brct6 && i != brct6))
                    {
                        Console.WriteLine("В строке присутствуют непарные скобки.");
                    }


                }

            }
        }
    }
}
