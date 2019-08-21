using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
      


        static void Main(string[] args)
        {

            int firstnumber = 0;
            // first number

            int secondnumber = 0;

            // second number

            int anser = 0;

            string operation = "";
            Console.WriteLine("This is a calculator");
            Console.ReadKey();
            Console.WriteLine("What do you want to do (multiply subtract division add");
            operation = Console.ReadLine();
            if (operation == "multiply")
            {
                Console.WriteLine("what numbers do you want to multiply");
                firstnumber = Convert.ToInt32(Console.ReadLine());
                // sets first number

                secondnumber = Convert.ToInt32(Console.ReadLine());
                // sets second number

                anser = firstnumber * secondnumber;
                // multiplys 2 numbers

                Console.WriteLine(anser);
                //shows user the anser

                Console.ReadKey();
            }
            else if (operation == "add")
            {
                Console.WriteLine("what numbers do you want to add");
                firstnumber = Convert.ToInt32(Console.ReadLine());
                // sets first number

                secondnumber = Convert.ToInt32(Console.ReadLine());
                // sets second number

                anser = firstnumber + secondnumber;
                // adds 2 numbers

                Console.WriteLine(anser);
                //shows user the anser

                Console.ReadKey();
            }
            else if (operation == "subtract")
            {
                Console.WriteLine("what numbers do you want to add");
                firstnumber = Convert.ToInt32(Console.ReadLine());
                // sets first number

                secondnumber = Convert.ToInt32(Console.ReadLine());
                // sets second number

                anser = firstnumber - secondnumber;
                // subtracts 2 numbers

                Console.WriteLine(anser);
                //shows user the anser

                Console.ReadKey();
            }
            else if (operation == "division")
            {
                Console.WriteLine("what numbers do you want to add");
                firstnumber = Convert.ToInt32(Console.ReadLine());
                // sets first number

                secondnumber = Convert.ToInt32(Console.ReadLine());
                // sets second number

                anser = firstnumber / secondnumber;
                // divideds 2 numbers

                Console.WriteLine(anser);
                //shows user the anser

                Console.ReadKey();
            }
            
        }
    }
}
