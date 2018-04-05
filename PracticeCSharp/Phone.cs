using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    class Phone : BaseClass
    {
        string pNetwork;
        string pPhoneInfo;

        public string PrintPhone()
        {
            string pDeviceInfo = this.PrintDevice();

            Console.WriteLine("Enter Network Type: 3G/4G");
            this.pNetwork = Console.ReadLine();
            
            return this.pPhoneInfo = pDeviceInfo + " " + this.pNetwork;
        }
    }
}
