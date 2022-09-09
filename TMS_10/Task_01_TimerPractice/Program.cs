// Изучить класс Timer
// Написать код с использованием класса Timer

using System.Diagnostics;
using Task_01_TimerPractice;

Stopwatch stopwatch = Stopwatch.StartNew();
SomeAction someAction = new(5000, 5000, stopwatch);

TimerCallback tcb = DoSomeAction;

Timer timer = new Timer(tcb, someAction, someAction.StartTime, someAction.PeriodOfTime);

Console.ReadLine();

static void DoSomeAction(object someAction)
{
    var action = (SomeAction)someAction;
    Console.WriteLine($"This action will be made every {action.PeriodOfTime / 1000} sec...");
    Console.WriteLine($"Time passed: {action.stopwatch.Elapsed.TotalSeconds:F2}");
    action.stopwatch.Restart();
}


