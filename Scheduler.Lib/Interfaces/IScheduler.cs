using Scheduler.Lib.Enums;
using System;
using System.Linq.Expressions;

namespace Scheduler.Lib
{
    public interface IScheduler
    {
        /// <summary>
        /// Cria um Job recorrente, que será executado sempre conforme especificado em 'cronExpression'
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="job"></param>
        /// <param name="cronExpression"></param>
        void AddRecurringJob(string jobId, Expression<Action> job, string cronExpression);

        /// <summary>
        /// Cria um Job recorrente, que será executado sempre conforme especificado em 'cronExpression'
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="job"></param>
        /// <param name="cronExpression"></param>
        void AddRecurringJob<T>(string jobId, Expression<Action<T>> job, string cronExpression);

        /// <summary>
        /// Cria um Job agendado, que será executado uma única vez no tempo definido. 
        /// </summary>
        /// <param name="job"></param>
        /// <param name="delay"></param>
        /// <returns></returns>
        string AddScheduledJob(Expression<Action> job, TimeSpan delay);

        /// <summary>
        /// Cria um Job agendado, que será executado uma única vez no tempo definido. 
        /// </summary>
        /// <param name="job"></param>
        /// <param name="delay"></param>
        /// <returns></returns>
        string AddScheduledJob<T>(Expression<Action<T>> job, TimeSpan delay);

        /// <summary>
        /// Executa um Job.
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        string ExecuteJob(Expression<Action> job);

        /// <summary>
        /// Executa um Job.
        /// </summary>
        /// <param name="job"></param>
        /// <returns></returns>
        string ExecuteJob<T>(Expression<Action<T>> job);

        /// <summary>
        /// Executa um Job em uma fila específica.
        /// </summary>
        /// <param name="job"></param>
        /// <param name="queue"></param>
        /// <returns></returns>
        string ExecuteJob(Expression<Action> job, Queue queue);

        /// <summary>
        /// Executa um Job em uma fila específica.
        /// </summary>
        /// <param name="job"></param>
        /// <param name="queue"></param>
        /// <returns></returns>
        string ExecuteJob<T>(Expression<Action<T>> job, Queue queue);

        /// <summary>
        /// Permite executar um Job a partir de um Job já executado. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parentJobId"></param>
        /// <param name="job"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        string ContinueWith<T>(string parentJobId, Expression<Action<T>> job, ContinuationOptions options = ContinuationOptions.OnlyOnSucceededState);
        
        /// <summary>
        /// Re-enfileira um Job para uma nova execução
        /// </summary>
        /// <param name="jobId"></param>
        /// <returns></returns>
        bool RequeueJob(string jobId);
    }
}
