using Microsoft.EntityFrameworkCore;
using System.Linq;
using Zurich.Common.Constants;
using Zurich.Domain.DTO;
using Zurich.Domain.Interfaces;
using Zurich.Domain.Models;

namespace Zurich.Repository.DataLayer
{
    public class SubscriptionRepository : GenericRepository<Subscription>, ISubscriptionRepository
    {
        #region "Contructor"
        public SubscriptionRepository(ZurichDbContext context) : base(context)
        {
        }
        #endregion

        #region "methods Implementations"
        public PagedList<ManageSubscriptionDTO> GetSubscriptions(SubscriptionParameters subscriptionParameters)
        {
            IQueryable<ManageSubscriptionDTO> query = _context.ManageSubscription.Include(ms => ms.Subscription).
                Include(ms => ms.Trainings).Where(ms => ms.Trainings.Status.Name.Equals(CommonConstants.TRAINING_STATUS_OPEN)).
                Select(ms => new ManageSubscriptionDTO
                {
                    SubscriptionCode = ms.Subscription.SubscriptionCode,
                    TrainingName = ms.Trainings.Name,
                    TrainingCode = ms.Trainings.Code,
                    Month = ms.Trainings.Month
                });

            if (!string.IsNullOrEmpty(subscriptionParameters.Month))
            {
                query = query.Where(s => s.Month.Contains(subscriptionParameters.Month));
            }

            if (!string.IsNullOrEmpty(subscriptionParameters.TrainingName))
            {
                query = query.Where(s => s.TrainingName.Contains(subscriptionParameters.TrainingName));
            }

            var rec = PagedList<ManageSubscriptionDTO>.ToPagedList(query, subscriptionParameters.PageNumber, subscriptionParameters.PageSize);

            return rec;
        }

        public PagedList<UserSubscriptionDTO> GetUserSubscriptions(UserSubscriptionParameter userSubscriptionParameter)
        {
            var query = _context.UserSubscription.Include(us => us.ManageSubscription).
                                Select(us => new UserSubscriptionDTO
                                {
                                    TrainingName = us.ManageSubscription.Trainings.Name,
                                    TrainingCode = us.ManageSubscription.Trainings.Code,
                                    CourseName = us.ManageSubscription.Trainings.Courses.Name,
                                    CourseCode = us.ManageSubscription.Trainings.Courses.Code,
                                    TrainingMonth = us.ManageSubscription.Trainings.Month,
                                    UserName = us.User.Name,
                                    UserGender = us.User.Gender,
                                    UserEmail = us.User.Email
                                });

            if (!string.IsNullOrEmpty(userSubscriptionParameter.TrainingName))
            {
                query = query.Where(s => s.TrainingName.Contains(userSubscriptionParameter.TrainingName));
            }

            if (!string.IsNullOrEmpty(userSubscriptionParameter.CourseName))
            {
                query = query.Where(s => s.CourseName.Contains(userSubscriptionParameter.CourseName));
            }

            if (!string.IsNullOrEmpty(userSubscriptionParameter.Month))
            {
                query = query.Where(s => s.TrainingMonth.Contains(userSubscriptionParameter.Month));
            }
                        
            if (!string.IsNullOrEmpty(userSubscriptionParameter.UserName))
            {
                query = query.Where(s => s.UserName.Contains(userSubscriptionParameter.UserName));
            }

            var rec = PagedList<UserSubscriptionDTO>.ToPagedList(query, userSubscriptionParameter.PageNumber, userSubscriptionParameter.PageSize);

            return rec;
        }
        #endregion
    }
}