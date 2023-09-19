using System;
using Fitness.BL.UserController;

namespace Fitness.CMD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Привет!");

            Console.WriteLine("Введите имя: ");
            var name = Console.ReadLine();

            var userController = new UserController(name);
            if (userController.IsNewUser)
            {
                Console.Write("Введите пол: ");
                var gender = Console.ReadLine();

                var birthDate = ParseDateTime();

                var weight = ParseDouble("Вес: ");
                var height = ParseDouble("Рост: ");

                
                userController.SetNewUserData(gender, birthDate, weight, height);
            }

            Console.WriteLine(userController.CurrentUser);
            Console.ReadLine();
        }

        private static DateTime ParseDateTime()
        {
            DateTime birthDate;
            while (true)
            {
                Console.Write("Введите дату рождения: ");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                    break;
                else
                {
                    Console.WriteLine("Неверный формат даты.");
                }
            }

            return birthDate;
        }

        private static double ParseDouble(string name)
        {
            
            while (true)
            {
                Console.Write($"Введите {name}");
                if (double.TryParse(Console.ReadLine(), out double value))
                    return value;
                else
                {
                    Console.WriteLine($"Неверный формат {name}.");
                }
            }
        }
    }
}