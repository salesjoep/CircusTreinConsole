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
        public bool CanBeAdded()
        {
            //Methode om regels op te stellen om dieren toe te voegen.
            return false;
        }
    }
}
