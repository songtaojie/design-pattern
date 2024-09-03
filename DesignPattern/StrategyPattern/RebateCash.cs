using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class RebateCash : ICashSuper
    {
        public double _rebate;
        public RebateCash(double rebate) 
        {
            _rebate = rebate;
        }
        public double AcceptCash(double money)
        {
            return money * _rebate;
        }
    }
}
