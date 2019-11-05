using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise
{
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
