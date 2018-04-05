using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class Computer : BaseClass
    {
        string pDrive;
        string pComputerInfo;

        public string PrintComputer()
        {
            string pDeviceInfo = this.PrintDevice();

            Console.WriteLine("Enter Drive Type: SSD/HDD");
            this.pDrive = Console.ReadLine();
            
            return this.pComputerInfo = pDeviceInfo + " " + this.pDrive;
        }
    }
}
