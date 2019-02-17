using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1702oop
{
    class Program
    {
        static void Main(string[] args)
        {

            Person moshe = new Person("Moshe");
            moshe.Name = "new name";
            moshe.Id = 1;
            Console.WriteLine(moshe.Id);
            Console.WriteLine(moshe.Name);

        }
    }
}
