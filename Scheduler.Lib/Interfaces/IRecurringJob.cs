using Scheduler.Lib.Enums;

namespace Mercadocar.Scheduler.Interfaces
{

    public interface IRecurringJob 
    {
        string Id { get; } 

        string Cron { get; }

        Queue Queue { get; }

        void Execute();
    }
}
