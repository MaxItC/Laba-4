using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4._2.Laba_4
{
    internal class Transport
    {
        protected const int AmountOfWagons= 8;

        static public int AmountOfWheels { get; set; }

        static public string typeoftrain { get; set; }

        public virtual void PrintAmountWagons()
        {
            Console.WriteLine(AmountOfWagons);
        }

    }
}
