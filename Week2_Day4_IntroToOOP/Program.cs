using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day4_IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Squid jerry = new Squid();
            Cat mittens = new Cat();
            if (mittens.Legs > jerry.arms)
            {
                Console.WriteLine("Mittens has more limbs!");
            } else if (mittens.Legs < jerry.arms)
            {
                Console.WriteLine("Jerry has more limbs!");
            } else
            {
                Console.WriteLine("They're both the same");
            }
        }
    }
    public class Squid
    {
        public int arms = 8;
    }

}
