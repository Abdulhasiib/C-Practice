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
        

        public void PrintComputer()
        {
            //string pDeviceInfo = this.PrintDevice();

            Console.WriteLine("Enter Drive Type: SSD/HDD");
            this.pDrive = Console.ReadLine();
            
        }

        public override void DeviceInfo()
        {
            this.PrintComputer();
            Console.WriteLine("This is Computer - {0}", this.pDrive);
        }
    }
}
