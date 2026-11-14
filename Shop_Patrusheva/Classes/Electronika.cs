using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Patrusheva.Classes
{
    public class Electronika : Shop
    {
        public string BatteryCapacity; // Ёмкость аккумулятора
        public string DrivingSpeed; // Скорость езды

        public Electronika(string name, int price, string batteryCapacity, string drivingSpeed) : base(name, price)
        {
            this.BatteryCapacity = batteryCapacity;
            this.DrivingSpeed = drivingSpeed;
        }
    }
}
