using Scheduler.Lib.Enums;

namespace Scheduler.Lib.Interfaces
{
    public interface IMonitorScheduler
    {
        /// <summary>
        /// Consulta os detalhes de um Job.
        /// 
        /// Jobs criados a mais de 24h podem não ser localizados, 
        /// pois o Scheduler tente a manter o histórico de até um dia.
        /// </summary>
        /// <param name="jobId"></param>
        /// <returns></returns>
        JobDetails GetJobDetails(string jobId);

        StatusJob GetJobStatus(string jobId);
    }
}
