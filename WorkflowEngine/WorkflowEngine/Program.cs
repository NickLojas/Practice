using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var vidToCloud = new UploadVidToCloud();
            var callWeb = new CallWebService();
            var sendEmail = new SendEmail();
            var changeStatus = new ChangeStatus();

            var work = new Workflow();
            work.Add(vidToCloud);
            work.Add(callWeb);
            work.Add(sendEmail);
            work.Add(changeStatus);

            var doActivities = new WorkFlowEngine();
            doActivities.Run(work);
        }
    }
}
