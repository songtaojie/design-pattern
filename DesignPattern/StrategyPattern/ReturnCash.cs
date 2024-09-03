using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class ReturnCash : ICashSuper
    {
        private double _money;
        private double _moneyReturn;
        public ReturnCash(double money,double moneyReturn)
        {
            _money = money;
            _moneyReturn = moneyReturn;
        }
        public double AcceptCash(double money)
        {
            if(money >= _money)
                return money - Math.Floor(money / _money)* _moneyReturn;
            return money;
        }
    }
}
