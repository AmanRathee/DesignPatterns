using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ConcreteProcess2: IProcess
    {
        public void ProcessMethodCalled()
        {
            Console.WriteLine("Process2 Method Called");
        }
    }
}
