using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Controller
    {
        public void DoAction()
        {
            Console.WriteLine("P1 or P2? ");
            var condition= Console.ReadLine();

            //Keeping this if else condition is not recommended.
            //This procedure shall be handled by a factory class.

            //if (process.ToLower() == "p1")
            //{
            //    ConcreteProcess1 processLayer = new ConcreteProcess1();
            //    processLayer.ProcessMethodCalled();
            //}
            //else
            //{
            //    ConcreteProcess2 processLayer = new ConcreteProcess2();
            //    processLayer.ProcessMethodCalled();
            //}

            IProcess processLayer = ProcessFactory.GetProcessInstance(condition);
            processLayer.ProcessMethodCalled();

            Console.ReadLine();

        }

    }
}
