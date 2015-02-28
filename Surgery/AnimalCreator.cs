using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surgery
{
    class AnimalCreator
    {
        public static Animal Create(AnimalOwner owner, AnimalType type, DateTime lastCheckup, string name = null)
        {
            Animal animal = new Animal(type) { Owner = owner, LastCheckup = lastCheckup, Name = name };
           
            switch (type)
            {
                    case AnimalType.Cat:
                    animal.CheckupFrequencyMonths = 9;
                    break;
                    case AnimalType.Dog:
                    animal.CheckupFrequencyMonths = 6;
                    break;

                default:
                    Console.WriteLine("throw new Exception (e) that animal has not been found");
                    break;
            }
            return animal;
        }
    }
}
