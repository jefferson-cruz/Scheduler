using System;
using System.Collections.Generic;

namespace Scheduler.Lib
{
    public class JobHistory
    {
        public string StateName { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; }
        public IDictionary<string, string> Data { get; set; }
    }
}
