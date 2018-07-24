using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_2_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y;



            Console.WriteLine("please enter a number");//prompt user

            x = Convert.ToInt32(Console.ReadLine());//get user input and assign to the variable x

            Console.WriteLine("please enter a second number");//prompt user

            y = Convert.ToInt32(Console.ReadLine());//get user input and assign to the variable y


            while (x != -1)
            {
                if (x == y)
                {
                    Console.WriteLine(x + " and " + y + " are the same");

                    Console.WriteLine("Lets start again..... please enter a number");//prompt user

                    x = Convert.ToInt32(Console.ReadLine());//get user input and assign to the variable x

                    Console.WriteLine("please enter a second number");//prompt user

                    y = Convert.ToInt32(Console.ReadLine());//get user input and assign to the variable y
                }

                else
                {
                    Console.WriteLine(x + " and " + y + " different");

                    Console.WriteLine("Lets start again..... please enter a number");//prompt user

                    x = Convert.ToInt32(Console.ReadLine());//get user input and assign to the variable x

                    Console.WriteLine("please enter a second number");//prompt user

                    y = Convert.ToInt32(Console.ReadLine());//get user input and assign to the variable y
                }
                

            }

        }
    }
}
