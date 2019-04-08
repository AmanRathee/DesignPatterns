using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        //Source:- https://www.dofactory.com/net/chain-of-responsibility-design-pattern

        //Avoid coupling the sender of a request to its receiver 
        //by giving more than one object a chance to handle the request. 
        //Chain the receiving objects and pass the request along the chain 
        //until an object handles it.

        //COR is used to define different workflows
        static void Main(string[] args)
        {
            Console.WriteLine("Which workflow do u want to use? W1/W2?");
            var workflowType = Console.ReadLine().ToLower();
            if (workflowType == "w1")
            {
                Workflow1 wf = new Workflow1();
                wf.StartWorkFlow();
            }
            else
            {
                Workflow2 wf = new Workflow2();
                wf.StartWorkFlow();
            }
            Console.ReadLine();
        }

    }
    class Workflow1
    {
        public void StartWorkFlow()
        {
            Chain c1 = new Step1();
            Chain c2 = new Step2();
            Chain c3 = new Step3();
            c1.SetNextStep(c2);
            c2.SetNextStep(c3);

            c1.ExecuteStep();
        }
        
    }
    class Workflow2
    {
        public void StartWorkFlow()
        {
            Chain c1 = new Step2();
            Chain c2 = new Step3();
            Chain c3 = new Step1();
            c1.SetNextStep(c2);
            c2.SetNextStep(c3);

            c1.ExecuteStep();
        }

    }
}
