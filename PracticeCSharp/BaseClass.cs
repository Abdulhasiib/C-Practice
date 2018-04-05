using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class BaseClass
    {
        string pModel;
        string pOperatingSystem;
        string pStorage;
        string pMemory;
        string pTouchScreen;
        string pDeviceInfo;

        public string PrintDevice()
        {
            Console.WriteLine("Enter Model Name:");
            this.pModel = Console.ReadLine();

            Console.WriteLine("Enter OS:");
            this.pOperatingSystem = Console.ReadLine();

            Console.WriteLine("Enter Storage size:");
            this.pStorage = Console.ReadLine();

            Console.WriteLine("Enter Memory size:");
            this.pMemory = Console.ReadLine();

            Console.WriteLine("Is it Touch Screen Device? Yes/No?");
            this.pTouchScreen = Console.ReadLine();

            this.pDeviceInfo = this.pModel + " " + this.pOperatingSystem + " " + this.pStorage + " " + this.pMemory + " " + this.pTouchScreen;

            return pDeviceInfo;
        }
    }
}
