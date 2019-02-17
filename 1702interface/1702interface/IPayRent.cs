using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1702interface
{
    interface IPayRent
    {
        void PayRent();
    }

    interface IPayArnona : IPayRent
    {
        void PayArnona();
    }

    public class Tenant : IPayArnona
    {
        public void PayArnona()
        {
            throw new NotImplementedException();
        }

        public void PayRent()
        {
            throw new NotImplementedException();
        }
    }
}
