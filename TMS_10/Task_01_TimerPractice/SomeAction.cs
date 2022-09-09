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
        public int StartTime { get; private set; }
        public int PeriodOfTime { get; private set; }
        public Stopwatch stopwatch;
        public SomeAction(int startTime, int periodOfTime, Stopwatch stopwatch)
        {
            StartTime = startTime;
            PeriodOfTime = periodOfTime;
            this.stopwatch = stopwatch;
        }
    }

}
