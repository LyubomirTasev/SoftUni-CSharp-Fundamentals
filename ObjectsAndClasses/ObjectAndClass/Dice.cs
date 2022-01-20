using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectAndClass
{
    class Dice
    {
        public int Side { get; set; }
        public string Type { get; set; }

        public int Roll()
        {
            Random rnd = new Random();

            return rnd.Next(1, Side + 1);
        }
    }
}
