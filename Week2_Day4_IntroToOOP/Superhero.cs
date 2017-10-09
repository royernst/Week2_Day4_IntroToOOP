using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day4_IntroToOOP
{
    class Superhero
    {
        //fields
        int powerLevel;
        bool hasCape;
        bool secretIdentity;
        string flyingSpeed;

        //Properties
        public int PowerLevel
        {
            get { return this.powerLevel; }
            set { this.powerLevel = value; }
        }

        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }

        public bool SecretIdentity
        {
            get { return this.secretIdentity; }
            set { this.secretIdentity = value; }
        }

        public string FlyingSpeed
        {
            get { return this.flyingSpeed; }
            set { this.flyingSpeed = value; }
        }

        //CONSTRUCTORS
        public Superhero()
        {
            //Intentionally left blank
        }

        public Superhero(bool secretIdentity, bool hasCape)
        {
            this.secretIdentity = secretIdentity;
            this.hasCape = hasCape;
        }

        public Superhero(int powerLevel, bool hasCape, bool secretIdentity, string flyingSpeed)
        {
            this.powerLevel = powerLevel;
            this.hasCape = hasCape;
            this.secretIdentity = secretIdentity;
            this.flyingSpeed = flyingSpeed;
        }

        //METHODS

        public void PowerBoost()
        {
            powerLevel = 9001;
            Console.WriteLine(powerLevel);
            Console.WriteLine("It's over 9000!!!!");
        }

        public void HealthBoost()
        {
            secretIdentity = false;
            hasCape = true;
            flyingSpeed = "Really fast.";
            PowerBoost();

        }

    }
}
