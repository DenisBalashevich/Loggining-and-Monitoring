using System;
using System.Web.Mvc;
using MvcMusicStore.Infrastucture;
using PerformanceCounterHelper;

namespace MvcMusicStore.App_Start
{
    public class PerformanceCountersConfig
    {
        public static void ConfigureCounters()
        {
            var counters = DependencyResolver.Current.GetService(typeof(CounterHelper<Counters>)) as CounterHelper<Counters>;
            foreach (Counters counter in Enum.GetValues(typeof(Counters)))
            {
                counters.Reset(counter);
            }
        }
    }
}