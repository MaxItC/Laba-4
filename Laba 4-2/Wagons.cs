using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4._2.Laba_4
{
    internal class Wagons 
    {
        public int Baggage { get;  } = 200;
        public int AmountOfPassagers { get;  }
        public int NumberOfTrain { get; set; }

        public string LevelOfConvinients { get; }

        public int Ton { get; set; }


        public Wagons(int n,int psgrs,string Conv) // пассажирские 
        {
            NumberOfTrain = n;
            AmountOfPassagers = psgrs;
            LevelOfConvinients  = Conv;
            Transport.typeoftrain = "Пассажирский";
            Transport.AmountOfWheels = 4;
        }

        public Wagons(int n,string s,int ton) // грузовые
        {
            LevelOfConvinients = s;
            NumberOfTrain = n;
            Ton = ton;
            Transport.typeoftrain = "Грузовой";
            Transport.AmountOfWheels = 6;
        }
    }
}
