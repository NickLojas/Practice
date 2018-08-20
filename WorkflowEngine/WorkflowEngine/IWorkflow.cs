using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class Workflow
    {
        public List<IActivity> Activities { get; private set; }
        public Workflow()
        {
            Activities = new List<IActivity>();
        }
        public void Add(IActivity activity)
        {
            Activities.Add(activity);
        }
    }
}
