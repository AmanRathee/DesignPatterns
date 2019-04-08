using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class Chain
    {
        protected Chain nextStep { get; set; }
        public void SetNextStep(Chain chain)
        {
            nextStep = chain;
        }
        
        public abstract void ExecuteStep();

    }
}
