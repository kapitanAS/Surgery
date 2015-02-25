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
         surgery.Animals[0] = new DogOwner();
         surgery.CreateCheckupNotificationLetters();
      }
   }
}
