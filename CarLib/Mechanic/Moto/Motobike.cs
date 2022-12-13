using CarLib.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib.Mechanic.Moto
{
    public class Motobike : CarModel
    {
        public readonly TwoLevelType twolevel = TwoLevelType.Moto;
        public readonly ThreeLevelType threeLevel = ThreeLevelType.Motorbike;
        public readonly OneLevelType oneLevel = OneLevelType.Mechanics;
        private string typeMoto;

        public string TypeMoto { get { return typeMoto; } }


        public Motobike(MotoType type, string model, string marka,
            string cuzov, int weight, int height, int wheelbase, string typedrive,
            string typeengine, int volumeengine, float maxspeed, float rash, string transmission,
            int volumetrunk) : base(model, marka, cuzov, weight, height, wheelbase, typedrive,
                typeengine, volumeengine, maxspeed, rash, transmission, volumetrunk)
        {
            switch (type)
            {
                case MotoType.Road:
                    typeMoto = "Дорожный";
                    break;
                case MotoType.Cross:
                    typeMoto = "Кроссовый";
                    break;
                case MotoType.MaxScooter:
                    typeMoto = "Макси-скутер";
                    break;
                case MotoType.Minibike:
                    typeMoto = "Минибайк";
                    break;
                case MotoType.Sport:
                    typeMoto = "Спортивный";
                    break;
                case MotoType.Tourist:
                    typeMoto = "Турист";
                    break;
                case MotoType.Threecycle:
                    typeMoto = "Трицикл";
                    break;
                case MotoType.Mopeds:
                    typeMoto = "Мопед";
                    break;
            }
           
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"\nМодель - {Model}\nМарка - {Marka}\n" +
                $"Тип - {typeMoto}\nКузов - {Cuzov}\nДлина - {Weight}мм\nШирина - {Height}мм\n" +
                $"Колёсная база - {Wheelbase}\nТип привода - {Typedrive}\nТип двигателя - {Typeengine}\n" +
                $"Объём двигателя - {Volumeengine}л\nМаксимальная скорость - {Maxspeed}\n" +
                $"Расход топлива на 100км - {Rash}л\nКоробка передач - {Transmission}\nОбъём багажника - {Volumetrunk}");
        }
    }
}
