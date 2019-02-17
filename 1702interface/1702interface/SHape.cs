using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1702interface
{

    interface IGreatInterface
    {

    }
    interface IItayWroteMe // marker interface - empty interfaces
    {

    }


    class Drawing
    {
            
    }

    class Shape : Drawing, IItayWroteMe, IGreatInterface
    {

    }

    interface IRoundeable
    {
        void DrawRoundShape();
    }

    class Circle : Shape, IRoundeable
    {
        public double Radius{ get; internal set; }

        public void DrawRoundShape()
        {
            Console.WriteLine("Draw rounded circle");
        }
    }

    class Rectangle : Shape
    {

    }

    class Elipse : Shape, IRoundeable
    {
        public void DrawRoundShape()
        {
            Console.WriteLine("Draw rounded elipser");
        }
    }
}
