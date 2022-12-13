using CarLib.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib.Mechanic.Avto
{
    public class Bus : CarModel
    {
        public readonly TwoLevelType twoLevelType = TwoLevelType.Avto;
        public readonly ThreeLevelType threeLevelType = ThreeLevelType.Bus;
        public readonly OneLevelType oneLevel = OneLevelType.Mechanics;

        private string classBuss;
        private int sit; // Число мест
        private string specBus;  //Специализация автобусов
        public string ClassBuss { get { return classBuss; } }
        public int Sit { get { return sit; } }

        public Bus(SpecBusType s, int sit, ClassBus cl, string model, string marka, string cuzov,
            int weight, int height, int wheelbase, string typedrive, string typeengine,
            int volumeengine, float maxspeed, float rash, string transmission,
            int volumetrunk) : base(model, marka, cuzov, weight, height, wheelbase,
                typedrive, typeengine, volumeengine, maxspeed, rash, transmission, volumetrunk)
        {
           
            this.sit = sit;
            switch (cl)
            {
                case ClassBus.Small:
                    classBuss = "Микроавтобус";
                    break;
                case ClassBus.MedSmall:
                    classBuss = "Малый";
                    break ;
                case ClassBus.Medium:
                    classBuss = "Средний";
                    break;
                case ClassBus.Large:
                    classBuss = "Большой";
                    break;
            }
            switch (s)
            {
                case SpecBusType.Med:
                    specBus = "Медицинский";
                    break;
                case SpecBusType.School:
                     specBus = "Школьный";
                    break;
                case SpecBusType.Vaht:
                    specBus = "Вахтовый";
                    break;
                case SpecBusType.Adv:
                    specBus = "Рекламный";
                    break;
                case SpecBusType.Ritual:
                    specBus = "Ритуальный";
                    break;
                case SpecBusType.Accident:
                    specBus = "Аварийно-спасательная служба";
                    break;
                case SpecBusType.Excursion:
                    specBus = "Экскурсионный";
                    break;
                case SpecBusType.Social:
                    specBus = "Общественный";
                    break;

            }
        }

        public override void PrintInfo()
        {
            
    
            Console.WriteLine($"\nМодель - {Model}\nМарка - {Marka}\nТип автобуса - {classBuss}\nСпециализация - {specBus}\n" +
                $"Число мест - {sit}\nКузов - {Cuzov}\nДлина - {Weight}мм\nШирина - {Height}мм\n" +
                $"Колёсная база - {Wheelbase}\nТип привода - {Typedrive}\nТип двигателя - {Typeengine}\n" +
                $"Объём двигателя - {Volumeengine}л\nМаксимальная скорость - {Maxspeed}\n" +
                $"Расход топлива на 100км - {Rash}л\nКоробка передач - {Transmission}\nОбъём багажника - {Volumetrunk}") ;
        }
    }
}
