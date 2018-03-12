using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class Class1
    {
        static void Main()
        {
            //Reading and Writing to Console Application
            Console.WriteLine("Enter your First Name: ");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name: ");
            string LastName = Console.ReadLine();

            //Escape Sequence 
            Console.WriteLine("Hello! \nMr. {0} {1}", FirstName, LastName);
            
            //Escape Sequnce and Verbatim Literal
            string MyCSharpCodePath = @"C:\Users\muHtasib\source\repos\PracticeCSharp\PracticeCSharp";
            Console.WriteLine("Your C# Project path is \n{0}", MyCSharpCodePath);

            //Nullable types
            bool? IsMarried = null;

            if (IsMarried == true)
            {
                Console.WriteLine("Congratulations!");
            }
            else if (IsMarried == false)
            {
                Console.WriteLine("Cool! Enjoy freedom ;) ");
            }
            else
            {
                Console.WriteLine("Wanna keep it secret! All right");
            }

            //null coalescinf operator
            int Income;
            int? Salary = null;

            Income = Salary ?? 0;

            Console.WriteLine("Your income is {0}", Income);

            Console.ReadLine();
        }
    }
}
