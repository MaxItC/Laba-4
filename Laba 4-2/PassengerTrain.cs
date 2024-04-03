using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4._2.Laba_4
{
    internal class PassengerTrain : Transport
    {

        List<Wagons> wagons = new List<Wagons>
        {
        new Wagons(1,150, "Low"),
        new Wagons(2,150, "Low"),
        new Wagons(3,180, "Normal"),
        new Wagons(4,200, "High"),
        new Wagons(5,50, "Luxe"),
        new Wagons(6,50, "Luxe"),
        new Wagons(7,150, "Low"),
        new Wagons(8,180, "Normal")
        };

        public void SortByComfort()
        {
            var order = new Dictionary<string, int>
            {
        { "Luxe", 3 },
        { "High", 2 },
        { "Normal", 1 },
        { "Low", 0 }
             };

            var i = wagons.OrderByDescending(x => order[x.LevelOfConvinients] );
            

            foreach(var j in i )
            Console.WriteLine(j.NumberOfTrain + $" {j.LevelOfConvinients} ");
        }

        public void FindPlaces(int Deep)
        {
            if(Deep > 200)
            {
                Console.WriteLine("Извините , такого вагона нет");
                return;
            }

            var suitableWagons = wagons.Where(x => x.AmountOfPassagers >= Deep);

            foreach (var wagon in suitableWagons)
            {
                Console.WriteLine($"Wagon {wagon.NumberOfTrain} ({wagon.LevelOfConvinients})");
            }
        }

        public void AmountOfPass()
        {
            Console.Write("Кiлькiсть пасажирiв: " + wagons.Sum(x => x.AmountOfPassagers));
        }

        public void AmountofBagg()
        {
            Console.WriteLine("Кiлькiсть багажу: "+wagons.Sum(x=>x.Baggage));
        }

        public override void PrintAmountWagons()
        {
            Console.WriteLine("Количество вагонов: " + AmountOfWagons);
        }

    }
}
