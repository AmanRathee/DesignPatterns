using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Step1 : Chain
    {
        public override void ExecuteStep()
        {
            Console.WriteLine("Step 1 executed");
            if (nextStep != null)
            {
                nextStep.ExecuteStep();
            }
        }
    }
}
