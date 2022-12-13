using CarLib.Combin;
using CarLib.Enum;
using CarLib.Mechanic.Avto;
using CarLib.Mechanic.Moto;
using CarLib.Mechanic.Tractor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class StartProg
    {

        private static string preview = "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\r\n▒█▒▒▒█▒█▀▒█▒▒█▀▒█▀█▒█▀█▀█▒█▀▒\r\n▒█▒█▒█▒█▀▒█▒▒█▒▒█▒█▒█▒█▒█▒█▀▒\r\n▒█▄█▄█▒██▒█▄▒█▄▒█▄█▒█▒█▒█▒██▒";
        private ThreeLevelType s;

        public static void Start(List<object> mass)
        {
            Console.WriteLine(preview);
            Console.WriteLine("Выберите категорию: Механическое транспортное сред-во, Комбинированное");
            
            Console.WriteLine($"Выберите категорию: {BaseAns(Answer1(Console.ReadLine()))}");
            Console.WriteLine($"Выберите категорию: {BaseAns(Answer2(Console.ReadLine()))}");
            find(Answer3(Console.ReadLine()), mass);
            


            




        }

        private static OneLevelType Answer1(string ans)
        {
            OneLevelType n = OneLevelType.Unknown;

            switch (ans)
            {
                case "Механическое транспортное сред-во":
                    n = OneLevelType.Mechanics;
                    break;
                case "Комбинированное":
                    n = OneLevelType.Combin;
                    break;
         
            }
            return n;
        }

        private static TwoLevelType Answer2(string ans)
        {
            TwoLevelType s = TwoLevelType.Unknown;
            
            switch (ans)
            {
                case "Мототранспортное сред-во":
                    s = TwoLevelType.Moto;
                    break;
                case "Автомобиль":
                    s = TwoLevelType.Avto;
                    break;
                case "Трактор":
                    s = TwoLevelType.Tractor;
                    break;
                case "Автопоезд":
                    s = TwoLevelType.Train;
                    break;
                    
            }
            return s;
        }

        private static ThreeLevelType Answer3(string ans)
        {
           
            ThreeLevelType t = ThreeLevelType.Unknown;

            switch (ans)
            {

                case "Мотоцикл":
                    t = ThreeLevelType.Motorbike;
                    break;
                case "Легковой автомобиль":
                    t = ThreeLevelType.Car;
                    break;
                case "Троллейбус":
                    t = ThreeLevelType.Trolleybus;
                    break;
                case "Грузовой автомобиль":
                    t = ThreeLevelType.WCar;
                    break;
                case "Автобус":
                    t = ThreeLevelType.Bus;
                    break;
                case "Трактор":
                    t = ThreeLevelType.Trac;
                    break;
                case "Автопоезд":
                    t = ThreeLevelType.AutTr;
                    break;

            }
            return t;
        }

        private static string BaseAns(OneLevelType n)
        {
            string s = " ";
            switch (n)
            {
                case OneLevelType.Mechanics:
                    s = "Мототранспортное сред-во, Автомобиль, Трактор";
                    break;
                case OneLevelType.Combin:
                    s = "Автопоезд";
                    break;
            }
            return s;
        }

        private static string BaseAns(TwoLevelType n)
        {
            string s = " ";
            switch (n)
            {
                case TwoLevelType.Avto:
                    s = "Легковой автомобиль, Автобус, Троллейбус, Грузовой автомобиль";
                    break;
                case TwoLevelType.Moto:
                    s = "Мотоцикл";
                    break;
                case TwoLevelType.Tractor:
                    s = "Трактор";
                    break;
                case TwoLevelType.Train:
                    s = "Автопоезд";
                    break;

            }
            return s;
        }

        private static void find(ThreeLevelType s, List<object> g)
        {
            var locmassCar = new List<Car>();
            var locmassMoto = new List<Motobike>();
            var locmassBus = new List<Bus>();
            var locmassTrol = new List<Trollbus>();
            var locmassWcar = new List<WeightCar>();
            var locmassTrac = new List<Tractor>();
            var locmassAuto = new List<AutoTrain>();
            string str = "";
            string nameId = "";

            switch (s) {
                case ThreeLevelType.Motorbike:
                    foreach (var t in g) { 
                        if(t.GetType() == typeof(Motobike))
                        {
                            locmassMoto.Add((Motobike)t);
                            
                        }
                    }
                    if (locmassMoto.Count > 0) {
                        foreach (var r in locmassMoto)
                        {
                            str += r.Model + "\n";
                        }
                        Console.WriteLine($"Модели по выбранным категориям: \n{str}");
                        Console.WriteLine("Выберите интересующую модель");
                        nameId = Console.ReadLine();
                        foreach (var r in locmassMoto)
                        {
                            if (r.Model == nameId)
                            {
                                r.PrintInfo();
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("В базе нет таких моделей");
                    }
                    
                    
                    break;
                case ThreeLevelType.Car:
                    foreach (var t in g)
                    {
                        if (t.GetType() == typeof(Car))
                        {
                            locmassCar.Add((Car)t);
                            
                        }
                    }
                    if (locmassCar.Count > 0)
                    {
                        foreach (var r in locmassCar)
                        {
                            str += r.Model + "\n";
                        }
                        Console.WriteLine($"Модели по выбранным категориям: \n{str}");
                        Console.WriteLine("Выберите интересующую модель");
                        nameId = Console.ReadLine();
                        foreach (var r in locmassCar)
                        {
                            if (r.Model == nameId)
                            {
                                r.PrintInfo();
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("В базе нет таких моделей");
                    }
                    break;
                case ThreeLevelType.Bus:
                    foreach (var t in g)
                    {
                        if (t.GetType() == typeof(Bus))
                        {
                            locmassBus.Add((Bus)t);
                            
                        }
                    }
                    if (locmassBus.Count > 0)
                    {
                        foreach (var r in locmassBus)
                        {
                            str += r.Model + "\n";
                        }
                        Console.WriteLine($"Модели по выбранным категориям: \n{str}");
                        Console.WriteLine("Выберите интересующую модель");
                        nameId = Console.ReadLine();
                        foreach (var r in locmassBus)
                        {
                            if (r.Model == nameId)
                            {
                                r.PrintInfo();
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("В базе нет таких моделей");
                    }
                    break;
                case ThreeLevelType.Trolleybus:
                    foreach (var t in g)
                    {
                        if (t.GetType() == typeof(Trollbus))
                        {
                            locmassTrol.Add((Trollbus)t);
                            
                        }
                    }
                    if (locmassTrol.Count > 0)
                    {
                        foreach (var r in locmassTrol)
                        {
                            str += r.Model + "\n";
                        }
                        Console.WriteLine($"Модели по выбранным категориям: \n{str}");
                        Console.WriteLine("Выберите интересующую модель");
                        nameId = Console.ReadLine();
                        foreach (var r in locmassTrol)
                        {
                            if (r.Model == nameId)
                            {
                                r.PrintInfo();
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("В базе нет таких моделей");
                    }
                    break;
                case ThreeLevelType.WCar:
                    foreach (var t in g)
                    {
                        if (t.GetType() == typeof(WeightCar))
                        {
                            locmassWcar.Add((WeightCar)t);
                            
                        }
                    }
                    if (locmassWcar.Count > 0)
                    {
                        foreach (var r in locmassWcar)
                        {
                            str += r.Model + "\n";
                        }
                        Console.WriteLine($"Модели по выбранным категориям: \n{str}");
                        Console.WriteLine("Выберите интересующую модель");
                        nameId = Console.ReadLine();
                        foreach (var r in locmassWcar)
                        {
                            if (r.Model == nameId)
                            {
                                r.PrintInfo();
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("В базе нет таких моделей");
                    }
                    break;
                case ThreeLevelType.Trac:
                    foreach (var t in g)
                    {
                        if (t.GetType() == typeof(Tractor))
                        {
                            locmassTrac.Add((Tractor)t);
                            
                        }
                    }
                    if (locmassTrac.Count > 0)
                    {
                        foreach (var r in locmassTrac)
                        {
                            str += r.Model + "\n";
                        }
                        Console.WriteLine($"Модели по выбранным категориям: \n{str}");
                        Console.WriteLine("Выберите интересующую модель");
                        nameId = Console.ReadLine();
                        foreach (var r in locmassTrac)
                        {
                            if (r.Model == nameId)
                            {
                                r.PrintInfo();
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("В базе нет таких моделей");
                    }
                    break;
                case ThreeLevelType.AutTr:
                    foreach (var t in g)
                    {
                        if (t.GetType() == typeof(AutoTrain))
                        {
                            locmassAuto.Add((AutoTrain)t);

                          
                        }
                    }
                    if (locmassAuto.Count > 0)
                    {
                        foreach (var r in locmassAuto)
                        {
                            str += r.Model + "\n";
                        }
                        Console.WriteLine($"Модели по выбранным категориям: \n{str}");
                        Console.WriteLine("Выберите интересующую модель");
                        nameId = Console.ReadLine();
                        foreach (var r in locmassAuto)
                        {
                            if (r.Model == nameId)
                            {
                                r.PrintInfo();
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("В базе нет таких моделей");
                    }
                    break;
               
            }
            
            
        }

        
        

            



    }
}
    