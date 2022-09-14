using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern.factory_method.Operation
{
    internal class Minus: IOperation
    {
        public int Execute()
        {
            return 1;
        }
    }
}
