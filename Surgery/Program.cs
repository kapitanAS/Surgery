using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Surgery
{
   class Program
   {
      static void Main(string[] args)
      {
         var surgery = new Surgery();
         
        AnimalOwner zenek = new AnimalOwner("121A", "Elmers End Road", "BR3 4SY", "Zenek Koczuga");
        AnimalOwner wiktor = new AnimalOwner("0X", "Void Strasse", "SE23 4AA", "Wiktor Oczko");
        surgery.AddAnimal(zenek, AnimalType.Cat, null, "Majonez");
         surgery.AddAnimal(wiktor, AnimalType.Dog, new DateTime(2012,12, 12), "Zagryz");
 
         surgery.CreateCheckupNotificationLetters();
         
         Console.ReadKey();
      }
   }
}
