using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Step2: Chain
    {
        public override void ExecuteStep()
        {
            Console.WriteLine("Step 2 executed");
            if (nextStep != null)
            {
                nextStep.ExecuteStep();
            }
        }
    }
}
