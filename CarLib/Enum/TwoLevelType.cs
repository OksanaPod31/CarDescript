using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarLib.Enum
{
    public enum TwoLevelType
    {
        Moto = 1, //Мототранспорт
        Avto = 2, //Автомобиль
        Tractor = 3, //Трактор
        Train = 4, //Автопоезд
        Unknown = 10,
    }
}
