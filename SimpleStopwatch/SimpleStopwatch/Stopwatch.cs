using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleStopwatch
{
    class Stopwatch
    {
        private bool startCheck = false;
        public TimeSpan TimeElapsed { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime StopTime { get; private set; }

        public void Start()
        {
            if (startCheck) throw new InvalidOperationException("Stopwatch cannot be started again without first being stopped.");
            else
            {
                this.StartTime = DateTime.Now;
                this.startCheck = true;
            }
        }
        public void Stop()
        {
            this.StopTime = DateTime.Now;
            this.TimeElapsed += (StopTime - StartTime);
            this.startCheck = false;
        }
    }
}
