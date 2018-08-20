using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class WorkFlowEngine
    {
        public void Run(Workflow work)
        {
            foreach (var activity in work.Activities)
            {
                activity.Execute();
            }
        }
    }
}
