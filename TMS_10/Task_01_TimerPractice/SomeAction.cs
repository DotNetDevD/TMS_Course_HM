using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_TimerPractice
{
   public struct SomeAction
    {
        public int startTime;
        public int periodOfTime;
        public Stopwatch stopwatch;
        public SomeAction(int startTime, int periodOfTime, Stopwatch stopwatch)
        {
            this.startTime = startTime;
            this.periodOfTime = periodOfTime;
            this.stopwatch = stopwatch;
        }
    }

}
