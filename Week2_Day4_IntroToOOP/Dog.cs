using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day4_IntroToOOP
{
    class Dog
    {
        //fields
        private string furLength;
        private double weight;
        private string runningSpeed;
        private float height;

        //Properties
        public string FurLength
        {
            get { return this.furLength; }
            set { this.furLength = value; }
        }

        public float Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public string RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        //CONSTRUCTORS
        public Dog()
        {
            //intentionally left blank
        }

        //METHODS

        public void Run()
        {
            runningSpeed = "getting faster.";
            weight = weight - .25;
        }

        public void Bark()
        {
            Console.WriteLine("\a");
        }

        public void Potty()
        {
            weight = weight - .1;
        }

        public void Groom()
        {
            furLength = "all cleaned up.";
        }

    }
}
