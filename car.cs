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
        public double GetTime(int speed, int distance)
        {

            return distance / speed;

        }


    }

    public class Car : Vehicle
    {
        public Car(string name) : base(name) { }
        public Car() { }
     
        public double Car_Get_speed()// слабое замедление плохой дороги
        {
            int i = new Random().Next(70, 90);
            return i;
        }

        public double Lets_go_time(int surface, int dist)
        {
            double Time_car = 0;
            int slow_tr = 0;
            if (surface == 1)
            {
                slow_tr = 0;

            }
            else if (surface == 2)
            {
                slow_tr = 15;

            }

            else if (surface == 3)
            {
                slow_tr = 15;

            }
            for (int i = 0; i <= dist; i++)
            {
                Time_car += 1 / (Car_Get_speed() - slow_tr);

            }

            return Time_car;

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

        public double Bike_Get_speed()// слабое замедление плохой дороги
        {
            int i = new Random().Next(80, 100);
            return i;
        }

        public double Lets_go_time(int surface, int dist)
        {
            double Time_bike = 0;
            int slow_tr = 0;
            if (surface == 1)
            {
                slow_tr = 0;

            }
            else if (surface == 2)
            {
                slow_tr = 20;

            }

            else if (surface == 3)
            {
                slow_tr = 30;

            }
            for (int i = 0; i <= dist; i++)
            {
                Time_bike += 1 / (Bike_Get_speed() - slow_tr);

            }

            return Time_bike;

        }








    }

    public class Truck : Vehicle
    {
        public Truck(string name) : base(name) { }
        public Truck() { }
        public double Truck_GetTime(int time, int slow)// слабое замедление плохой дороги
        {
            return time - slow;
        }

        public double Truck_Get_speed()// слабое замедление плохой дороги
        {
            int i = new Random().Next(50, 80);
            return i;
        }


        public double Lets_go_time(int surface, int dist)
        {
            double Time_TR = 0;
            int slow_tr = 0;
            if (surface == 1)
            {
                slow_tr = 0;

            }
            else if (surface == 2)
            {
                slow_tr = 5;

            }

            else if (surface == 3)
            {
                slow_tr = 10;

            }
            for (int i = 0; i <= dist; i++)
            {
                Time_TR += 1 / (Truck_Get_speed() - slow_tr);

            }

            return Time_TR;

        }


    }
}

