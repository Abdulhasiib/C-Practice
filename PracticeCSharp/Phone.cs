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

        public void PrintPhone()
        {
            //string pDeviceInfo = this.PrintDevice();

            Console.WriteLine("Enter Network Type: 3G/4G");
            this.pNetwork = Console.ReadLine();
            
        }

        public override void DeviceInfo()
        {
            this.PrintPhone();
            Console.WriteLine("This is a Phone - {0} ", this.pNetwork);
            //base.DeviceInfo();
        }
    }
}
