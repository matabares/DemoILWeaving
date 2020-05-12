using System;
using MethodBoundaryAspect.Fody.Attributes;


namespace DemoILWeaving
{
    [AttributeUsage(AttributeTargets.Method)]
    public class EnableTimerForThisMethod : OnMethodBoundaryAspect
    {
        private TimeSpan timer;

        public override void OnEntry(MethodExecutionArgs args)
        {
            timer = new TimeSpan(DateTime.Now.Ticks);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            var executionTimeInMillis = (DateTime.Now.Ticks - timer.Ticks) / TimeSpan.TicksPerMillisecond;
            System.Console.WriteLine($"This method takes {executionTimeInMillis} millis {args.Arguments[0]}");
        }
    }
}
