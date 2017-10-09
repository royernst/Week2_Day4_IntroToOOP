using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day4_IntroToOOP
{
    class Cat
    {
        //STATES
        //Properties
        //Bouncer/Mama Bear
        //Almost always public
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Legs
        {
            get { return this.legs; }
            set { this.legs = value; }
        }
        //Fields
        //Almost always private
        private string name;
        private int legs = 4;
        private int age;
        private string furColor;
        private bool isHungry = true;
        

        //BEHAVIORS

        //CONSTRUCTORS
        //Substantiate class.  Allow us to create new instance of "cat"
        public Cat()
        {
            //default constructor (takes no parameters in parenthesis)
        }

        public Cat(string name, int age, string furColor, int legs)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
            this.legs = legs;
        }

        //METHODS
        public void Eat()
        {
            if (isHungry == true)
            {
                isHungry = false;
            } else
            {
                //intentionally left blank
            }

            Console.WriteLine("Is the cat hungry? " + isHungry);
        }
    }
}
