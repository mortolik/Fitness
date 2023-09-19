using System;

namespace Fitness.BL.Model
{
    [Serializable]
    public class User
    {/// <summary>
     /// Имя
     /// </summary>
        public string Name { get; }
     /// <summary>
     /// Пол
     /// </summary>
        public Gender Gender { get; set; }
     /// <summary>
     /// Дата рождения
     /// </summary>
        public DateTime Birthdate { get; set; }
     /// <summary>
     /// Вес
     /// </summary>
        public double Weight { get; set; }
     /// <summary>
     /// Рост
     /// </summary>
        public double Height { get; set; }
     /// <summary>
     /// Возраст
     /// </summary>
     public int Age
     {
         get { return DateTime.Now.Year - Birthdate.Year; }
     }
/// <summary>
/// Создать пользователя
/// </summary>
/// <param name="name"> Имя</param>
/// <param name="gender">Пол</param>
/// <param name="birthdate">Дата</param>
/// <param name="weight">Вес</param>
/// <param name="height">Рост</param>
/// <exception cref="ArgumentNullException"></exception>
/// <exception cref="ArgumentException"></exception>
        public User(string name, Gender gender, DateTime birthdate, double weight, double height)
        {
            #region Свойства

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "Имя не может быть пустым.");
            }

            if (gender == null)
            {
                throw new ArgumentNullException(nameof(gender), "Пол не может быть пустым.");
            }

            if (birthdate < DateTime.Parse("01.01.1900") || birthdate > DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения.", nameof(birthdate));
            }

            if (weight <= 0)
            {
                throw new ArgumentException("Невозможный вес.", nameof(weight));
            }
            if (height <= 0)
            {
                throw new ArgumentException("Невозможный рост.", nameof(height));
            }
            #endregion 
            
            Name = name;
            Gender = gender;
            Birthdate = birthdate;
            Weight = weight;
            Height = height;
                         
        }

        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name), "Имя не может быть пустым.");
            }
            Name = name;
        }
        public override string ToString()
        {

            return Name + " " + Age;
        }


    }
}