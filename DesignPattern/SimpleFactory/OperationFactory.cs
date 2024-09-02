using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class OperationFactory
    {
        public static Operation CreateOperation(string? operate)
        {
            switch (operate)
            {
                case "+":
                    return new OperationAdd();
                case "-":
                    return new OperationSub();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
