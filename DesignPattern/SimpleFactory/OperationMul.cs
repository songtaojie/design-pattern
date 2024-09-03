using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class OperationMul:Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }
}
