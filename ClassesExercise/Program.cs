using System;

namespace ClassesExercise
{
     class Program
    {
        static void Main(string[] args)
        {
            car mycar =new car();
            mycar.Make = "Hyundai";
            mycar.Model = "Santa fe";
            mycar.Year = 2020;

            Console.WriteLine($"{mycar.Make}");
            Console.WriteLine($"{mycar.Model}");
            Console.WriteLine($"{mycar.Year}");
        }
    } 
}
