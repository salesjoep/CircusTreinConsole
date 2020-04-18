using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein
{
    public class Wagon
    {
        //Class Fields
        private List<Animals> animals = new List<Animals>();
        private int maxSize = 10;

        //Class Properties
        public bool IsWagonFull { get; set; }

        //Class Constructors

        //Class Methods
        public int RetrieveLeftOverSize()
        {
            //Zet size gelijk aan maxSize(10)
            int leftOverSize = maxSize;
            //Voor elk dier in animals list
            foreach (Animals animal in animals)
            {
                //size - grootte van dier.
                leftOverSize = leftOverSize - animal.RetrieveSize();
            }
            return leftOverSize;
        }
        public bool CanBeAdded(Animals animal)
        {
            //Wanneer de ruimte die we nog hebben kleiner is dan de size van animal
            if (RetrieveLeftOverSize() < animal.RetrieveSize())
            {
                //Niet mogelijk
                return false;
            }
            //Methode om regels op te stellen om dieren toe te voegen.
            return false;
        }
    }
}
