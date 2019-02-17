using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1702propex
{
    abstract class Fruit
    {
        private string _color;
        private int _calories;

        public string Name { get; private set; } // creating new backing filed 

        internal int Calories // binded to this._calories
        {
            get
            {
                return _calories;
            }
            set
            {
                if (value > 0)
                {
                    _calories = value;
                }
            }
        }

        public string Color // binded to this._color
        {
            get
            {
                return _color;
            }
        }

        abstract public bool Taim 
        {
            get;
        }

        public Fruit(string color, int calories, string name)
        {
            _color = color; // only 1 way. because there is no setter!
            this._calories = calories; // 1 i have the field
            this.Calories = calories; // 2 i also have setter
            this.Name = name; // i have no field. only 1 way using Property setter
        }
    }
}
