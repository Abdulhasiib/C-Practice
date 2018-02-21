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
            Console.WriteLine("Enter your First Name: ");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name: ");
            string LastName = Console.ReadLine();

            Console.WriteLine("Hello! Mr. {0} {1}", FirstName, LastName);
            Console.ReadLine();
        }
    }
}
