using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Happy_Hours
{
    public interface IBillingStrategy
    {
        double GetPrice(double price);
    }
}
