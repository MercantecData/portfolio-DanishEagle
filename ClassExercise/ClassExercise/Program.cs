using System;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

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

    class Bag
    {
        public string color;
        public int amountOfZippers;
        public string material;
        public int amountOfPockets;
        public int price;


        public string Description()
        {
            return $"The bag is a nice {color}, color. It has {amountOfZippers} zippers, {amountOfPockets} pockets and is made out of {material}. It is being sold at the price of {price} dollars.";
        }

        public string FillBagWithItems()
        {
            return "You can put either your chair or couch in your bag to carry with you on your adventures. It is however not limited to chairs and couches.";
        }

        public string OpenBag()
        {
            return "You can open the bag to look at what is inside to make sure you did not forget anything";
        }

        public string ThrowBag()
        {
            return "You can throw the bag if it is ever slowing you down, however be aware that you will lose your items in the bag as well";
        }

        public string SellBag()
        {
            return "If you got a new bag or dont need the current bag anymore you can sell it and earn yourself some coins";
        }

        public string CloseBag()
        {
            return "You can close the bag to keep your items safe when running around on all of your adventures.";
        }
    }
}

