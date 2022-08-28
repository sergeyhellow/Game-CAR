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
            while (sw.Elapsed < TimeSpan.FromSeconds(3))
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

     
            


        public void Lets_go_time(int surface, int dist, Car car, Truck Truck, Motorbike motj, Logger log)
        {
            
            double c= car.Lets_go_time(surface, dist);
            double t= Truck.Lets_go_time(surface, dist);
            double m= motj.Lets_go_time(surface, dist);
            

            double[] ar = { c, t, m };
            double minValue = ar.Min<double>();
           

            Console.WriteLine($"Time of CAR: {car.Name} is  {c}");
            log.redordLog("Information ", "Time of CAR " + " " + car.Name + " " +  c);
            Console.WriteLine($"Time of TRUCK: {Truck.Name} is  { t}");
            log.redordLog("Information ", "Time of TRUCK " + " " + Truck.Name + " " + t);
            Console.WriteLine($"Time of Bike: {motj.Name} is  { m}");
            log.redordLog("Information ", "Time of Bike " + " "+ motj.Name + " " + m);

            if (minValue == c)
            {
                Console.WriteLine($"And the winner is: {car.Name} is  {minValue}");
                log.redordLog("Information ", "the winner is " + " " + car.Name + " " + minValue);
            }

            else if (minValue == t)
            {
                Console.WriteLine($"And the winner is : {Truck.Name} is  {minValue}");
                log.redordLog("Information ", "the winner is " + " " + Truck.Name + " " + minValue);
            }


            else if (minValue == m) Console.WriteLine($"And the winner is : {motj.Name} is  {minValue}");
            {
                Console.WriteLine($"And the winner is : {motj.Name} is  {minValue}");
                log.redordLog("Information ", "the winner is " + " " + motj.Name + " " + minValue);

            }

        }















    }
}
