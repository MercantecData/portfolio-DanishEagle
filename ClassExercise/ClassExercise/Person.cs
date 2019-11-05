using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExercise
{
    class Person
    {
        public string name;
        public int age;
        public string gender;
        public double height;
        public string eyeColor;

        public string Description()
        {
            return $"{name} is their name and they are {age} years old. They are {gender}, with a height of {height} and eyecolor is {eyeColor}";
        }

        public string FirstUse()
        {

        }

        public string SecondUse()
        {
            return;
        }

        public string ThirdUse()
        {
            return;
        }

        public string ForthUse()
        {
            return;
        }

        public string FifthUse()
        {
            return;
        }


        /*public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }*/

        //?? checks if the things before ?? then it returns the string after 
        //Console.WriteLine(Person.job.title ?? "Unemployeed");
    }
}
