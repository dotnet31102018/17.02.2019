using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1702interface
{

    interface IFly
    {
        void Fly(); // always public abstract
    }

    class Person
    {
    }

    abstract class Superman : Person, IFly
    {
        public abstract void Fly(); // abstract class may not implement interface but must declare!!!

    }

    class KalEl : Superman
    {
        public override void Fly()
        {
            Console.WriteLine("Kal el is flying!!");
        }
    }

}
