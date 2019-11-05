using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise
{
    class Chair
    {
        public string color;
        public int numberOfLegs;
        public string material;
        public int yearOfMaking;
        public int placeOfMaking;

        public string Description()
        {
            return $"The chair here is {color}, it has {numberOfLegs} legs. Its made out of {material}. It was made in {placeOfMaking}, in the year {yearOfMaking}";
        }

        public string SitOnChair()
        {
            return "You can sit on the chair to regain energy for your adventures.";
        }

        public string MoveChair()
        {
            return "You can pick up your chair and move it to a different location where you think it might fit better.";
        }

        public string PutChairInInventory()
        {
            return "You can bring your chair along on your adventures so you will never run out of a place to regain energy.";
        }

        public string PaintChair()
        {
            return "You can paint your chair if you would rather want a bright yellow or neon green chair that will also work as a torch in the night.";
        }

        public string ThrowChair()
        {
            return "You can throw the chair around, use it as a defence weapon if you somehow missed the many better objects in the room.";
        }
    }
}
