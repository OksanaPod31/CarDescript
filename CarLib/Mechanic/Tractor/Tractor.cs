using CarLib.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib.Mechanic.Tractor
{
    public class Tractor : CarModel
    {
        public readonly OneLevelType oneLevelType = OneLevelType.Mechanics;
        public readonly TwoLevelType twoLevelType = TwoLevelType.Tractor;
        private int tagClass;  //Тяговый класс

        public int TagClass { get { return tagClass; } }

        public Tractor(int tagClass, string model, string marka, string cuzov, int weight,
            int height, int wheelbase, string typedrive, string typeengine,
            int volumeengine, float maxspeed, float rash, string transmission,
            int volumetrunk) : base(model, marka, cuzov, weight, height, wheelbase,
                typedrive, typeengine, volumeengine, maxspeed, rash, transmission, volumetrunk)
        {
            this.tagClass = tagClass;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"\nМодель - {Model}\nМарка - {Marka}" +
                $"\nТяговый класс - {tagClass}\nКузов - {Cuzov}\nДлина - {Weight}мм\nШирина - {Height}мм\n" +
                $"Колёсная база - {Wheelbase}\nТип привода - {Typedrive}\nТип двигателя - {Typeengine}\n" +
                $"Объём двигателя - {Volumeengine}л\nМаксимальная скорость - {Maxspeed}\n" +
                $"Расход топлива на 100км - {Rash}л\nКоробка передач - {Transmission}\nОбъём багажника - {Volumetrunk}");
        }
    }
}
