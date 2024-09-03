using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class CashContext
    {

        private string _type;
        public CashContext(string type)
        {
            _type = type;
        }

        public double GetResult(double money)
        {
            var cashSuper = GetCashSuper();
            return cashSuper.AcceptCash(money);
        }

        private ICashSuper GetCashSuper() 
        {
            switch (_type)
            {
                case "正常收费":
                    return new NormalCash();
                case "满300返100":
                    return new ReturnCash(300,100);
                case "打八折":
                    return new RebateCash(0.8);
                   default:
                    throw new NotImplementedException();
            }
        }
    }
}
