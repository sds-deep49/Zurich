using System;

namespace Zurich.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Course repository
        /// </summary>
        ICoursesRepository Courses { get; }
        /// <summary>
        /// Training repository
        /// </summary>
        ITrainingsRepository Trainings { get; }
        /// <summary>
        /// Subscription repository
        /// </summary>
        ISubscriptionRepository Subscriptions { get; }
        /// <summary>
        /// To complete the transaction
        /// </summary>
        /// <returns></returns>
        int Complete();
    }
}