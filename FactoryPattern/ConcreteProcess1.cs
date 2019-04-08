using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ConcreteProcess1: IProcess
    {
        public void ProcessMethodCalled()
        {
            Console.WriteLine("Process1 Method Called");
        }
    }
}
