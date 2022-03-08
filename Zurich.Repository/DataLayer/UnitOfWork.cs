using System;
using Zurich.Domain.Interfaces;

namespace Zurich.Repository.DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        #region "Private fields"
        private readonly ZurichDbContext _context;
        #endregion

        #region "Public properties"
        /// <summary>
        /// Courses
        /// </summary>
        public ICoursesRepository Courses { get; }
        /// <summary>
        /// Trainings
        /// </summary>
        public ITrainingsRepository Trainings { get; }
        /// <summary>
        /// Subscription
        /// </summary>
        public ISubscriptionRepository Subscriptions { get; }
        #endregion

        #region "Constructor
        public UnitOfWork(ZurichDbContext zurichDbContext,
            ICoursesRepository coursesRepository,
            ITrainingsRepository trainingsRepository,
            ISubscriptionRepository subscriptionRepository)
        {
            this._context = zurichDbContext;

            this.Courses = coursesRepository;
            this.Trainings = trainingsRepository;
            this.Subscriptions = subscriptionRepository;
        }
        #endregion

        #region "Method Implementatiions
        /// <summary>
        /// Complete transaction
        /// </summary>
        /// <returns></returns>
        public int Complete()
        {
            return _context.SaveChanges();
        }

        /// <summary>
        /// Dispose unused object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// dispose context
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
        #endregion
    }
}