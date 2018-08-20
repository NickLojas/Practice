using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email to the owner of the video notifying them that the video started processing.");
        }
    }
}
