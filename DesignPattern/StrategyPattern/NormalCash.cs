using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class NormalCash : ICashSuper
    {
        public double AcceptCash(double money)
        {
            return money;
        }
    }
}
