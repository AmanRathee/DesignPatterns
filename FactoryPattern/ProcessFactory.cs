using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class ProcessFactory
    {
        //We can take the condition either from the params,webconfig or reflection
        public static IProcess GetProcessInstance(string condition)
        {
            if (condition.ToLower() == "p1")
            {
                return new ConcreteProcess1();
            }
            else if (condition.ToLower() == "p2")
            {
                return new ConcreteProcess2();
            }
            return null;
        }
    }
}
