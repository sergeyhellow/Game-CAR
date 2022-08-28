using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Game

{
    class Program
    {


        delegate void Vhicle();
       

        static void Main(string[] args)
        {

            Logger log = new Logger();
            Car Car = new Car();
            Truck Truck = new Truck ();
            Motorbike Moto = new Motorbike();
            int vehicle=0;
        go:

            Console.Clear();

            Console.WriteLine("1: Play");
            Console.WriteLine("2: Read rools");
            ConsoleKey key = GetButton();
            log.redordLog("informational", "Menu item: " + key.ToString());

            Console.Clear();
            if (key == ConsoleKey.D1)
            {

                Console.WriteLine("Choose your car");
                Console.WriteLine("1. Car");
                Console.WriteLine("2. Track");
                Console.WriteLine("3. Motobike");
                log.redordLog("informational", "Choosing your car: " + key.ToString());

                ConsoleKey key2 = GetButton();
                Console.Clear();

                if (key2 == ConsoleKey.D1)
                {
                    vehicle = 1;
                    Console.WriteLine("Get name of your Car");
                    Car.Name = Console.ReadLine();
                    log.redordLog("informational", "name of player car: " + Car.Name);
                    Console.WriteLine("Name: " + Car.Name);
                }
                else if (key2 == ConsoleKey.D2)
                {
                    vehicle = 2;
                    Console.WriteLine("Get name of your Truck");
                    Truck.Name = Console.ReadLine();
                    log.redordLog("informational", "name of player car: " + Truck.Name);
                    Console.WriteLine("Name: " + Truck.Name);
                }
                else if (key2 == ConsoleKey.D3)
                {
                    vehicle = 3;
                    Console.WriteLine("Get name of your Moto");
                    Moto.Name = Console.ReadLine();
                    log.redordLog("informational", "name of player car: " + Moto.Name);
                    Console.WriteLine("Name: " + Moto.Name);

                }
                else 
                {
                    Console.WriteLine("Command not exist ");
                    log.redordLog("Warning", "Choosing car WRONG command is : " + key.ToString());
                    Thread.Sleep(1000);
                    goto go;

                }
               

            }

               
              else if (key == ConsoleKey.D2)
                {
                    Console.WriteLine("Правила: игрок выбирает вид транспортного средства: мотоцикл, грузовик либо легкойо автомобиль");
                    log.redordLog("informational", " Player reading rools  " + key.ToString());
                Thread.Sleep(2000);
                   
                    goto go;
              }

                else
                {
                    Console.WriteLine("Command not exist ");
                    log.redordLog("Warning", "Menu WRONG command is : " + key.ToString());
                    Thread.Sleep(1000);
                    goto go;
                }

            go1:
            Console.Clear();
            Console.WriteLine("Choose track coverage (покрытие гоночного трека)");
            Console.WriteLine("1. asphalt");
            Console.WriteLine("2. ground");
            Console.WriteLine("3. snow");

            int coverage;
            try
            {
                coverage = Int32.Parse(Console.ReadLine());
                log.redordLog("Informational", "coverage is : " + coverage);

            }
            catch
            {
                Console.WriteLine("Enter number, command not exist");
                log.redordLog("Error", "WRONG command of coverage : is not number");
                Thread.Sleep(1000);
                goto go1;
            }
                       
            if (coverage != 1 && coverage != 2 && coverage != 3)
           
            {
                Console.WriteLine("Command not exist");
                log.redordLog("Warning", "WRONG number of coverage : " + coverage);
                Thread.Sleep(1000);
             goto go1;
            }
            int duration;
             go2:           
            Console.Clear();
            Console.WriteLine("Choose duration of the race (продолжительность заезда) more then 100");
            try
            {
                duration = Int32.Parse(Console.ReadLine());
                log.redordLog("Informational", "long of duration : " + duration);
            }
            catch
            {
                Console.WriteLine("Enter number, command not exist");
                log.redordLog("Error", "WRONG command of duration : is not number");
                Thread.Sleep(1000);
                goto go2;
            }
            if (duration < 100) {
                Console.WriteLine("Enter duration more then 100");
                log.redordLog("Warning", "Trying Enter duration less then 100 = " + duration);

                goto go2;
            }


            Game_ Game = new Game_();
            log.redordLog("Informational", "Game started");
            Game.GetAttension();
            Game.ShowRoad();
            Game.Lets_go_time(coverage, duration, Car, Truck, Moto, log);

           

            Console.ReadLine();

            }

        
                 
            public static ConsoleKey GetButton()
            {
          
                var but = Console.ReadKey(true).Key;
                return but;


            }

                         


        }


     }





  
