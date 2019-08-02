using Scheduler.Lib.Enums;

namespace Scheduler.Lib
{
    public class RecurringJobInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Assembly { get; set; }
        public string Cron { get; set; }
        public Queue Queue { get; set; }
        public bool Active { get; set; }
    }
}
