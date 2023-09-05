using System;

namespace Fitness.BL.Model
{
    /// <summary>
    /// Пол
    /// </summary>
    public class Gender
    {/// <summary>
     /// Название пола
     /// </summary>
        public string Name { get; }
/// <summary>
/// Создать новый пол
/// </summary>
/// <param name="name"> Имя пола </param>
/// <exception cref="ArgumentNullException"></exception>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name),"Гендер не может быть пустым" );
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}