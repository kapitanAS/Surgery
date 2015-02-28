using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;

namespace Surgery
{
   class Surgery
   {
      static PrintDocument _printDoc = new PrintDocument();

      public void CreateCheckupNotificationLetters()
      {
         for (int i = 0; i < _animals.Count(); ++i)
         {
            var animal = _animals[i];
            if (animal == null) break;
            if (animal.IsCheckDue())
            {
                  PrintNotificationLetter(animal);
            }
         }
      }

      public void PrintNotificationLetter(Animal animal)
      {
         //_printDoc.PrintPage += (obj, e) =>
         //   {
         //      e.Graphics.DrawString(animal.Name, new Font(FontFamily.GenericSerif, 12, FontStyle.Bold), Brushes.Black, PointF.Empty);
         //      e.HasMorePages = false;
         //   };
         //_printDoc.Print();
          Console.WriteLine(animal);
      }
      
      private IList<Animal> _animals = new List<Animal>(); //List or IList?
      public IList<Animal> Animals
      {
         get { return _animals; }
         set { _animals = value; }
      }

       public void AddAnimal(AnimalOwner owner, AnimalType type, DateTime? lastCheckup, string name=null)
      {
          Animal newAnimal = AnimalCreator.Create(owner, type, (lastCheckup.HasValue?(DateTime)lastCheckup:DateTime.Now),name);
          _animals.Add(newAnimal);
      }
   }
}
