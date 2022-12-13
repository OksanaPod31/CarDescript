using CarLib;
using CarLib.Mechanic.Avto;
using CarLib.Enum;


class Program
{
    static void Main(string[] args)
    {
        Bus bus1 = new Bus(SpecBusType.Excursion, 60, ClassBus.Large,
            "MAN Lion's Coach", "MAN Lion's", "Автобусный", 12101, 2550, 97, "RWD", "V",
            12, (float)50, (float)456, "LON", 67);
        Bus bus2 = new Bus(SpecBusType.Adv, 22, ClassBus.Medium,        
        "Jumper 3", "Jumper", "КУВ", 1201, 3440, 74, "RWD", "V", 18,
        (float)54, (float)243, "LON", 50);

        Car car1 = new Car("BMW M1", "BMW", "2дв купе", 4380, 1803, 98, "4WD", 
        "N677", 879, (float)876, (float)30, "MKПП", 867);
        Car car2 = new Car("BMW X1", "BMW", "2дв купе", 4390, 1503, 98, "4WD",
        "N46", 899, (float)876.66, (float)30, "MKПП", 897);

        Trollbus tr1 = new Trollbus("Задний", 28, "MAS31", "MAS", "TYY", 1467, 678, 658,
            "ПНР", "ПП67", 890, (float)738, (float)56, "КПП", 6783);
        Trollbus tr2 = new Trollbus("Задний", 36, "Sus coach 31", "Sus coach", "TIY",
            18097, 378, 658, "ПНР", "ПП67", 800, (float)938, (float)56, "КПП", 6783);

        WeightCar wcar1 = new WeightCar(WCarType.MegaLarge,"TTR542", "TTR",
            "ПР56", 78930, 678, 67, "TYYI", "5GG7", 673, 786, 4664, "МКПП",494);
        WeightCar wcar2 = new WeightCar(WCarType.Small, "МАЗ42", "МАЗ",
            "ПР76", 5480, 698, 67, "TYYI", "5GG7", 673, 786, 4664, "МКПП", 5884);

        

        List<object> m = new List<object>();
        m.Add(car1);
        m.Add(bus2);
        m.Add(bus1);
        m.Add(car2);
        m.Add(tr1);
        m.Add(tr2);
        m.Add(wcar1);
        m.Add(wcar2);


        StartProg.Start(m);
    }

}
