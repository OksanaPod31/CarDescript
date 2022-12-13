using CarLib.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib.Mechanic.Avto
{
    public class Trollbus : CarModel
    {
        public readonly TwoLevelType twoLevelType = TwoLevelType.Avto;
        public readonly ThreeLevelType threeLevelType = ThreeLevelType.Trolleybus;
        public readonly OneLevelType oneLevel = OneLevelType.Mechanics;

        private int sit; // Число мест
        private string most;  //Ведущий мост
        public int Sit { get { return sit; } }
        public string Most { get { return most; } }
        public Trollbus(string most, int sit, string model, string marka, 
            string cuzov, int weight, int height, int wheelbase, string typedrive,
            string typeengine, int volumeengine, float maxspeed, float rash,
            string transmission, int volumetrunk) : base(model, marka,
                cuzov, weight, height, wheelbase, typedrive, typeengine,
                volumeengine, maxspeed, rash, transmission, volumetrunk)
        {
            this.sit = sit;
            this.most = most;
           
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"\nМодель - {Model}\nМарка - {Marka}\nВедущий мост - {most}" +
                $"\nЧисло мест - {sit}\nКузов - {Cuzov}\nДлина - {Weight}мм\nШирина - {Height}мм\n" +
                $"Колёсная база - {Wheelbase}\nТип привода - {Typedrive}\nТип двигателя - {Typeengine}\n" +
                $"Объём двигателя - {Volumeengine}л\nМаксимальная скорость - {Maxspeed}\n" +
                $"Расход топлива на 100км - {Rash}л\nКоробка передач - {Transmission}\nОбъём багажника - {Volumetrunk}");
        }
    }
}
