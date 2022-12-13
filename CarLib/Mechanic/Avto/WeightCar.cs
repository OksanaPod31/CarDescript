using CarLib.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib.Mechanic.Avto
{
    public class WeightCar : CarModel
    {
        public readonly TwoLevelType twoLevelType = TwoLevelType.Avto;
        public readonly ThreeLevelType threeLevelType = ThreeLevelType.WCar;
        public readonly OneLevelType oneLevel = OneLevelType.Mechanics;
        private string type; //Грузоподъёмность

        public string Type { get { return type; } }

        public WeightCar(WCarType types, string model, string marka, string cuzov,
            int weight, int height, int wheelbase, string typedrive, string typeengine,
            int volumeengine, float maxspeed, float rash, string transmission,
            int volumetrunk) : base(model, marka, cuzov, weight, height,
                wheelbase, typedrive, typeengine, volumeengine, maxspeed, rash,
                transmission, volumetrunk)
        {
            

            switch (types)
            {
                case WCarType.Small:
                    type = "Малая грузоподъёмность (0,5 - 2 тонны)";
                    break;
                case WCarType.Medium:
                    type = "Средняя грузоподъёмность (2 - 5 тонны)";
                    break;
                case WCarType.Large:
                    type = "<Большая грузоподъёмность (5 - 16 тонны)";
                    break;
                case WCarType.MegaLarge:
                    type = "Особо большая грузоподъёмность (от 16 тонн)";
                    break;
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"\nМодель - {Model}\nМарка - {Marka}\n" +
                $"Грузоподъёмность - {type}\nКузов - {Cuzov}\nДлина - {Weight}мм\nШирина - {Height}мм\n" +
                $"Колёсная база - {Wheelbase}\nТип привода - {Typedrive}\nТип двигателя - {Typeengine}\n" +
                $"Объём двигателя - {Volumeengine}л\nМаксимальная скорость - {Maxspeed}\n" +
                $"Расход топлива на 100км - {Rash}л\nКоробка передач - {Transmission}\nОбъём багажника - {Volumetrunk}");
        }
    }
}
