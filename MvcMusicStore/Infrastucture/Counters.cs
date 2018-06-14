using System.Diagnostics;
using PerformanceCounterHelper;

namespace MvcMusicStore.Infrastucture
{
    [PerformanceCounterCategory("MvcMusicStore", System.Diagnostics.PerformanceCounterCategoryType.MultiInstance, "MvcMusicStore")]
    public enum Counters
    {
        [PerformanceCounter("SuccessLogInCounter", "Successful logIns:", PerformanceCounterType.NumberOfItems32)]
        SuccessLogInsCounter = 1,

        [PerformanceCounter("SuccessLogOffCounter", "Successful logOffs:", PerformanceCounterType.NumberOfItems32)]
        SuccessLogOffsCounter = 2
    }
}