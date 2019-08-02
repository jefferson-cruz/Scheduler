using Scheduler.Lib.Enums;
using System;

namespace Scheduler.Lib.Helpers
{
    public static class JobStatusHelper
    {
        public static StatusJob Convert(string statusName)
        {
            return (StatusJob)Enum.Parse(typeof(StatusJob), statusName);
        }
    }
}
