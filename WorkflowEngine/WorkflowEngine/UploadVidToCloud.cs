using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class UploadVidToCloud : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video to a cloud storage.");
        }
    }
}
