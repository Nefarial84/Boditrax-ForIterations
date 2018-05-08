using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i.ToString());

                 if (i == 7)
                {
                    Console.WriteLine("You have fount seven :D");
                    break;
                }
            }

            for (int myx = 0; myx < 10; myx++)
            {
                Console.WriteLine(myx);
            }
            Console.ReadLine();
        }
    }
}
