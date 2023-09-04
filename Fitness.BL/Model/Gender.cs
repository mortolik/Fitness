using System;

namespace Fitness.BL.Model
{
    public class Gender
    {
        public string Name { get; }

        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name),"Гендер не может быть пустым" );
            }

            Name = name;
        }
    }
}