using CarLib.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public abstract class CarModel
    {

        private string model;
        private string marka;
        private string cuzov;
        private int weight;
        private int height;
        private int wheelbase;  // Колёсная база
        private string typedrive;  // Тип привода
        private string typeengine;  // Тип двигателя
        private int volumeengine;  // Объём двигателя
        private float maxspeed;
        private float rash;  // Расход топлива
        private string transmission;  // Коробка передач
        private int volumetrunk;  // Объём багажника




        public string Model { get { return model; } }
        public string Marka { get { return marka; } }
        public string Cuzov { get { return cuzov; } }
        public int Weight { get { return weight; } }
        public int Height { get { return height; } }
        public int Wheelbase { get { return wheelbase; } }  // Колёсная база
        public string Typedrive { get { return typedrive; } }  // Тип привода
        public string Typeengine { get { return typeengine; } }  // Тип двигателя
        public int Volumeengine { get { return volumeengine; } }  // Объём двигателя
        public float Maxspeed { get { return maxspeed; } }
        public float Rash { get { return rash; } }  // Расход топлива
        public string Transmission { get { return transmission; } }  // Коробка передач
        public int Volumetrunk { get { return volumetrunk; } }  // Объём багажника


        public CarModel(string model, string marka, string cuzov, 
            int weight, int height, int wheelbase, string typedrive, string typeengine,
            int volumeengine, float maxspeed, float rash, string transmission, int volumetrunk)
        {
            this.model = model;
            this.marka = marka;
            this.cuzov = cuzov;
            this.weight = weight;
            this.height = height;
            this.wheelbase = wheelbase;
            this.typedrive = typedrive;
            this.volumeengine = volumeengine;
            this.maxspeed = maxspeed;
            this.rash = rash;
            this.transmission = transmission;
            this.volumetrunk = volumetrunk;

        }

        public abstract void PrintInfo();

        //static void find(T[] mass,  )
        //{

        //}
        

    }
}
