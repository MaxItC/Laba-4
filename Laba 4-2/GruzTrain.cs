using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4._2.Laba_4
{
    internal class GruzTrain : Transport 
    {
        List<Wagons> wagons = new List<Wagons>
        {
        new Wagons(1, "None",850),
        new Wagons(2 ,"None",1000),
        new Wagons(3 ,"None",650),
        new Wagons(4 ,"None",700),
        new Wagons(5, "None",900),
        new Wagons(6, "None",560),
        new Wagons(7, "None",950),
        new Wagons(8 ,"None",1250)
        };

        public void SortByVes()
        {
            var i = wagons.OrderByDescending(x=> x.Ton);

            foreach(var v in i)
            Console.WriteLine(v.NumberOfTrain + " "+ v.Ton);
          
        }

        public override void PrintAmountWagons()
        {
            Console.WriteLine("Количество вагонов: " + AmountOfWagons);
        }

        public void PrintType()
        {
            Console.WriteLine("Количество колес: "+typeoftrain);
        }

        public void Wheels()
        {
            Console.WriteLine("Количество колес: "+AmountOfWheels*AmountOfWagons);
        }
    }
}
