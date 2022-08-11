using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public abstract class Vehicle
    {
        public int max_speed;
        public string Name;

       public Vehicle(string name)
        {
            Name = name;
            
        }
        public Vehicle()
        {
            Name = "CPU Enemy";

        }
        public double GetTime (int speed, int distance)
        {
            
            return distance/speed;
        
        } 


    }

    public class Car : Vehicle
    {
        public Car (string name) : base(name) { }
        public Car() { }
        public double Car_GetTime(int time, int slow)// среднее замедление плохой дороги
        {
            return 0.8*time -  slow;
        }
    }


    public class Motorbike : Vehicle
    {
        public Motorbike(string name) : base(name) { }
        public Motorbike() { }
        public double Bike_GetTime(int time, int slow)// сильно замедление плохой дороги
        {
            return 0.6 * time - slow;
        }
    }

    public class Truck : Vehicle
    {
        public Truck(string name) : base(name) { }
        public Truck() { }
        public double Truck_GetTime(int time, int slow)// слабое замедление плохой дороги
        {
            return  time -  slow;
        }
    }


}
