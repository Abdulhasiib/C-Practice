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
            #region Reading & Writing to Console Application
            /*
            
            Console.WriteLine("Enter your First Name: ");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name: ");
            string LastName = Console.ReadLine();
            */
            #endregion

            #region Escape Sequence & Verbatim Literal
            /*
            Console.WriteLine("Hello! \nMr. {0} {1}", FirstName, LastName);
            
            //Escape Sequnce and Verbatim Literal
            string MyCSharpCodePath = @"C:\Users\muHtasib\source\repos\PracticeCSharp\PracticeCSharp";
            Console.WriteLine("Your C# Project path is \n{0}", MyCSharpCodePath);

            */
            #endregion

            #region Nullable types & null coalescinf operator

            /*
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
            */

            #endregion

            #region Datatype conversion
            /*
            //Implicit Conversion
                int i = 123;

                float f = i;

                Console.WriteLine(i);

                Console.ReadLine();
            
            //Explicit Conversion - Type cast operator
                float fl = 123.45F;

                int x = (int)fl;

                Console.WriteLine(x);

                Console.ReadLine();
                
            //Explicit Conversion - Convert Class

                float fl1 = 123.45F;

                int x1 = Convert.ToInt32(fl1);

                Console.WriteLine(x1);

                Console.ReadLine();
                
            //Parse

                string number = "42572";

                int n = int.Parse(number);

                Console.WriteLine(n);

                Console.ReadLine();
                */

            //Try Parse
            /*
                string Alphanumber = "42572H";

                int h = 0;

                bool CheckParse = int.TryParse(Alphanumber,out h);

                if (CheckParse)
                {
                    Console.WriteLine(h);
                }
                else
                {
                    Console.WriteLine("Conversion failed, Check number");
                }

                Console.ReadLine();
             */
            #endregion

            #region Arrays

            string[] FamilyMembers = new string[8];

            FamilyMembers[0] = "Father - M.A. Saleem";
            FamilyMembers[1] = "Mother - Shabana Akhtar";
            FamilyMembers[2] = "Son - M.A. Haseeb";
            FamilyMembers[3] = "Wife - Hajra Haseeb";
            FamilyMembers[4] = "Sister - Memona Firdos";
            FamilyMembers[5] = "Sister - Sana Fatema";
            FamilyMembers[6] = "Brother - Abdul Haq";
            FamilyMembers[7] = "Sister - Saniya Almas";

            /*
            for (int i = 0; i < FamilyMembers.Length; i++)
            {
                Console.WriteLine(FamilyMembers[i]);
            }
            */

            Console.WriteLine("Enter a number.");

            int UserNumber = int.Parse(Console.ReadLine());

            if (UserNumber == 0)
            {
                Console.WriteLine(FamilyMembers[0]);
            }
            else if (UserNumber == 1)
            {
                Console.WriteLine(FamilyMembers[1]);
            }
            else if (UserNumber == 2)
            {
                Console.WriteLine(FamilyMembers[2]);
            }
            else if (UserNumber == 3)
            {
                Console.WriteLine(FamilyMembers[3]);
            }
            else if (UserNumber == 4)
            {
                Console.WriteLine(FamilyMembers[4]);
            }
            else if (UserNumber == 5)
            {
                Console.WriteLine(FamilyMembers[5]);
            }
            else if (UserNumber == 6)
            {
                Console.WriteLine(FamilyMembers[6]);
            }
            else if (UserNumber == 7)
            {
                Console.WriteLine(FamilyMembers[7]);
            }
            else
            {
                Console.WriteLine("Sorry, No member matched against the number.");
            }

            Console.ReadLine();

            #endregion
        }
    }
}
