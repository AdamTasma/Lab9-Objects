using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        public static int i = 1;
        static void Main()
        {
            Console.WriteLine("Welcome to the circle calculator, please enter a number for your radius.");
            if (Double.TryParse(Console.ReadLine(), out double input) && input > 0)
            {
                //OBJECT CREATION//
                Circle c = new Circle(input);
                Console.WriteLine("The circumference of a circle with a radius of " + input + " is " + c.CalculateFormattedCircumference() + ".");
                Console.WriteLine("The area of a cirlce with a radius of " + input + " is " + c.CalculateFormattedArea() + ".");
                Repeat();
            }
            else
            {
                Console.WriteLine("I'm sorry, that wasn't a calculable number.");
                Main();
            }
        }

        static void Repeat()
        {
            Console.WriteLine("Would you like to repeat (y/n)");
            if (char.TryParse(Console.ReadLine(), out char response))
            {
                if (char.ToLower(response) == 'y')
                {
                    i++;
                    Main();
                }
                else if (char.ToLower(response) == 'n')
                {
                    Console.WriteLine(i + " was enough circles, eh?");
                }
                else
                {
                    Console.WriteLine("I'm sorry, I didn't understand. Would you like to continue?(y/n)");
                    Repeat();
                }
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't understand. Would you like to continue?(y/n)");
                Repeat();
            }
        }
    }


}
