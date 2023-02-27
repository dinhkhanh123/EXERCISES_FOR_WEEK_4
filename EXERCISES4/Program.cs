using System;
using System.Reflection;

namespace EXERCISES4
{
    internal class Program
    {

        public interface ICar
        {
            string Model { set; get; }
            string Color { set; get; }

            string Start();
            string Stop();
        }

        public interface IElectricCar
        {
            int Battery { set; get; }
        }

        public class Seat : ICar
        {
            public string Model { get; set; }
            public string Color { get; set; }

            public Seat(string model, string color)
            {
                Model = model;
                Color = color;
            }

            public override string ToString()
            {
                return $"{Color} {Model}";
            }

            public string Start()
            {
                return "Engine start";
            }

            public string Stop()
            {
                return "Breakaak!";
            }
        }

        public class Tesla : ICar, IElectricCar
        {
            public string Model { get; set; }
            public string Color { get; set; }
            public int Battery { get; set; }

            public Tesla(string model, string color, int battery)
            {
                Model = model;
                Color = color;
                Battery = battery;
            }

            public override string ToString()
            {
                return $"{Color} {Model} with {Battery} Batteries";
            }

            public string Start()
            {
                return "Engine start";
            }

            public string Stop()
            {
                return "Breakaak!";
            }
        }

        public class StartUp
        {
            public static void Main(string[] args)
            {
                ICar seat = new Seat("Leon", "Gray");
                ICar tesla = new Tesla("Model 3", "Red", 2);

                Console.WriteLine(seat.ToString());
                Console.WriteLine(seat.Start());
                Console.WriteLine(seat.Stop());

                Console.WriteLine(tesla.ToString());
                Console.WriteLine(tesla.Start());
                Console.WriteLine(tesla.Stop());
            }
        }
    }
    }
