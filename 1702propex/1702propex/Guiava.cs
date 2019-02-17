using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1702propex
{
    class Guiava : Fruit
    {
        public Guiava(string color, int calories, string name) : base(color, calories, name)
        {
        }

        public override bool Taim
        {
            get
            {
                return false;
            }
        }
    }
}
