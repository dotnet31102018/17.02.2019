using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1702interface
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawInterface(new Shape());
            //Draw(new Object());

            IRoundeable roundable = new Circle();

            Console.WriteLine("==============================");
            Console.WriteLine(roundable.GetType()); // get the class name

            GetShape(roundable);
            GetShape(new Elipse());

            Shape shape = new Circle();
            

            Circle c = new Circle();
            c.Radius = 5.9;

            DrawRoundShapes(roundable);

            Car honda = null;
            Console.WriteLine(honda);
        }

        static void GetShape(IRoundeable aRoundable)
        {
            Console.WriteLine($"Are you circle? {(aRoundable is Elipse)}");
            Console.WriteLine($"Are you eplise? {(aRoundable is Circle)}");

            Circle c2 = aRoundable as Circle; // returns null when its not the same type
            if (c2 != null)
            {
                Console.WriteLine(c2.Radius);
            }

            if (aRoundable is Circle)
            {
                Console.WriteLine("Got a circle");
                Circle c1 = aRoundable as Circle;
                Console.WriteLine(c1.Radius);
            }
            else if (aRoundable is Elipse)
            {
                Console.WriteLine("Got a elipse!");
            }


        }

        static void Draw(Shape s)
        {
            
        }

        static void DrawInterface(IItayWroteMe i1)
        {
            
        }

        static void FlyPlease(IFly flying)
        {
            flying.Fly();
        }

        static void DrawRoundShapes(IRoundeable shape)
        {
            shape.DrawRoundShape();
        }
    }
}
