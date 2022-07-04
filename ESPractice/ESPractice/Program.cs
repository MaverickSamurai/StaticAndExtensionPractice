using ESPractice.Implementions;
using System;
using ESPractice.Models;
using ESPractice.Helpers;

namespace ESPractice
{
    public class Program
    {
        private static object car;

        static void Main(string[] args)
        {
            #region HomeWork
            //Calculation calc = new Calculation();
            //int num1 = 20;
            //int num2 = 10;

            //var result = calc.Calculate(num1, num2, "+");

            //Console.WriteLine(result);
            #endregion

            //Car car = new Car();
            //car.Speed = 600;

            //Car.Speed = 400;

            //Car.ShowSpeed();
            //Console.WriteLine(Car.Speed);
            //Console.WriteLine(car.Speed);

            //Car car1 = new Car();
            //Car car2 = new Car();
            //Person person1 = new Person();
            //Person person2 = new Person();

            //string name = "";
            //name.ToLower();

            //string word = "Salam P130";
            //string name = "Mirsamir";

            //var result1 = word.CheckString(@"\d");
            //Console.WriteLine(result1);

            //var result2 = word.CheckString(@"[A-Z]");

            //Console.WriteLine(result2);

            //Console.WriteLine(word + "-" + result2);
            //Extension.CheckDigit(word);
            //var result = word.CheckDigit();
            //Console.WriteLine(result);



            int num1 = 2;
            num1.Power(3);
            int num2 = 10;

            //num1.SumNumbers(num2);
            Console.WriteLine(num1.SumNumbers(5,4,3));

        }
        




    }
}
