using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise
{
    class Couch
    {
        public string color;
        public int amountOfLegs;
        public string material;
        public string sizeOfCouch; 
        public double height; 

        public string Description()
        {
            return $"{color} is the color of the couch. It has {amountOfLegs} and is made out of {material}. It is a {sizeOfCouch} with a height of {height}";
        }

        public string SitInCouch()
        {
            return "Sitting down in the couch can regain somoe energy";
        }

        public string LyingInCouch()
        {
            return "Lying down in the couch can lead to a nap which can give you even more energy";
        }

        public string SwitchMaterial()
        {
            return "Remove leather currently on couch to change color or material to please your desires";
        }

        public string MoveCouch()
        {
            return "Moving it to a different location so it no longer is in the middle of the room, or maybe that is exactly where you want it";
        }

        public string PutInInventory()
        {
            return "Bringing the couch along on your adventure by putting it into your very large inventory that can carry everything";
        }
    }
}
