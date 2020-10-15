using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Happy_Hours
{
    public class HappyHoursStrategy : IBillingStrategy
    {
        public double GetPrice(double price)
        {
            return 0.5 * price;
        }
    }
}
