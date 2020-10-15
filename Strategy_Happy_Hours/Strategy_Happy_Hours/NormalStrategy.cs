using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Happy_Hours
{
    public class NormalStrategy : IBillingStrategy
    {
        public double GetPrice(double price)
        {
            return price;
        }
    }
}
