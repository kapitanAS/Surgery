using System;
namespace Surgery
{
   class Animal: IAnimal
   {
      public DateTime LastCheckup {
         get { return _lastCheckup; }
         set
         {
            if (LastCheckup >= DateTime.Now)
               Console.WriteLine("Last checkup cannot be in the future"); //throw an exception
            else _lastCheckup = value;
         }}

      public int CheckupFrequencyMonths { get; set; }

      public string Name { get; set; }
      public readonly AnimalType AnimalType;
      private  DateTime _lastCheckup;

      public Animal(AnimalType animalType)
      {
         AnimalType = animalType;
      }

      public bool IsCheckDue()
      {
         return (DateTime.Now - _lastCheckup).TotalDays/30.3 >= CheckupFrequencyMonths;
      }
   }
}
