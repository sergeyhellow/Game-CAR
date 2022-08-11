using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
namespace Game
{
    public class Game_
    {

        


        protected Dictionary<int, string> Attenshion = new Dictionary<int, string>
        {
               { 1, "on the start"},
               { 2, "attention"},
               { 3, "march"}
        };


      public  Game_ () { }

        public void  GetAttension()
        {
            for (int i =1; i<= Attenshion.Count; i++)
            {
                
                Console.WriteLine(Attenshion[i]);
                Thread.Sleep(500);
            }

        }


        public void ShowRoad()
        {

                       Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.Elapsed < TimeSpan.FromSeconds(15))
            {


                Console.Clear();
                Console.WriteLine("           /  | \\");
                Thread.Sleep(200);
                Console.WriteLine("         /   ||   \\");
                Thread.Sleep(200);
                Console.WriteLine("       /     ||     \\");
                Thread.Sleep(200);
                Console.WriteLine("     /       ||       \\");
                Thread.Sleep(200);
                Console.WriteLine("   /         ||         \\");
                Thread.Sleep(200);
                Console.WriteLine(" /           ||           \\");
                Thread.Sleep(200);

            }

        }

        public void Who_win(int surface, int time, Car car, Truck Truck, Motorbike motj ) 
        {
            Race_track track = new Race_track();
            track.get_Surf(surface);
           
            if (surface == 1) 
            {
            

              Console.WriteLine($"Time of CAR: {car.Name} is  { car.Car_GetTime(time, 50)}");
              Console.WriteLine($"Time of TRUCK: {Truck.Name} is  { Truck.Truck_GetTime(time, 50)}");
              Console.WriteLine($"Time of Bike: {motj.Name} is  { motj.Bike_GetTime(time, 50)}");

               
            }
            else if (surface == 2)
            {
                Console.WriteLine($"Time of CAR: {car.Name} is  { car.Car_GetTime(time, 30)}");
                Console.WriteLine($"Time of: {Truck.Name} is  { Truck.Truck_GetTime(time, 30)}");
                Console.WriteLine($"Time of: {motj.Name} is  { motj.Bike_GetTime(time, 30)}");
            }
            else if (surface == 3)
            {
                Console.WriteLine($"Time of CAR: {car.Name} is  { car.Car_GetTime(time, 20)}");
                Console.WriteLine($"Time of TRUCK: {Truck.Name} is  { Truck.Truck_GetTime(time, 20)}");
                Console.WriteLine($"Time of Bike: {motj.Name} is  { motj.Bike_GetTime(time, 20)}");
            }

            

        }






    }
}
