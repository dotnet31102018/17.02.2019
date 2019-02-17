using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1702oop
{
    class Person
    {
        private string name;

        public static int MyProperty { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        public int Id { get; set; }

        /*
        private int backingfiled_id;
        public int Id
        {
            get
            {
                return this.backingfiled_id;
            }
            set
            {
                this.backingfiled_id = value;
            }
        }
        */

        /// <summary>
        /// 2
        /// </summary>
        public string Name {
            get
            {
                return this.name;
            }
            set //(string value)
            {
                //if (value != string.Empty)
                //{
                //    this.name = value;
                //}
                this.name = value;
            }
        }

        //public string GetName()
        //{
        //    return this.name;
        //}

        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        public Person(string name)
        {
            this.name = name;
        }


    }
}
