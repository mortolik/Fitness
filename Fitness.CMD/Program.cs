using System;
using Fitness.BL.UserController;

namespace Fitness.CMD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Привет!");

            Console.WriteLine("Введите имя:");
            var name = Console.ReadLine();
                
            Console.WriteLine("Введите пол:");
            var gender = Console.ReadLine();
                
            Console.WriteLine("Введите дату рождения:");
            var birthDate = DateTime.Parse(Console.ReadLine());
                
            Console.WriteLine("Введите ваш вес:");
            var weight  = Double.Parse(Console.ReadLine());
                
            Console.WriteLine("Введите ваш рост:");
            var height  = Double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthDate, weight, height);
            userController.Save();
        }
    }
}