using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _137
{
    class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public int Speed { get; set; }

        public Car(int year, string make, int speed)
        {
            Year = year;
            Make = make;
            Speed = speed;
        }
        public static int Acclerate(int newSpeed)
        { 
            return newSpeed += 5;
            
        }
        public static int Brake(int newSpeed)
        {
            return newSpeed -= 5;
        }
    }
}
