using Scheduler.Lib.Enums;
using Scheduler.Lib.Extensions;
using System;
using System.Linq;

namespace Scheduler.Lib.Helpers
{
    public static class QueueHelper
    {
        public static string GetQueueNameByEnum(Queue queue)
        {
            return queue.ToString().ToLower();
        }

        public static Queue GetQueueByName(string queueName)
        {
            return (Queue)Enum.Parse(typeof(Queue), queueName.ToUpperWords());
        }

        public static string[] GetNameQueues()
        {
            return Enum.GetNames(typeof(Queue))
                .Select(q => q.ToLower()).ToArray();
        }
    }
}
