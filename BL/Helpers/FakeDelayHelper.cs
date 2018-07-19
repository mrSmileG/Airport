using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;

namespace BL.Helpers
{
    internal static class FakeDelayHelper
    {
        public static Task<TResult> GetWithDelayAsync<T, TResult>(Func<T, TResult> function, T param, int delay = 5000)
        {
            var tcs = new TaskCompletionSource<TResult>();

            var timer = new Timer
            {
                AutoReset = false,
                Interval = delay
            };

            timer.Elapsed += delegate
            {
                try
                {
                    tcs.SetResult(function(param));
                }
                catch (Exception e)
                {
                    tcs.SetException(e);
                }
                finally
                {
                    timer.Dispose();
                }
            };
            timer.Start();
            
            return tcs.Task;
        }
    }
}
