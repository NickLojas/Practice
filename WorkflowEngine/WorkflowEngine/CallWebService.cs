using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class CallWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling a web service provided by a third-party video encoding service to tell them that you have a video ready for encoding.");
        }
    }
}
