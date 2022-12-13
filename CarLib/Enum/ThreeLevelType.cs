using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarLib.Enum
{
    public enum ThreeLevelType
    {
        Motorbike = 2, //Мотоцик
        Car = 3, //Легковой автомобиль
        Bus = 4, //Автобус
        Trolleybus = 5, //Троллейбус
        WCar = 6, //Грузовой автомобиль
        Trac = 7,
        AutTr = 8,
        Unknown = 10,

    }
}
