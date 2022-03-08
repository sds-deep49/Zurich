using Zurich.Domain.DTO;
using Zurich.Domain.Models;

namespace Zurich.Domain.Interfaces
{
    public interface ISubscriptionRepository : IGenericRepository<Subscription>
    {
        /// <summary>
        /// To get the subscription by paging and filtering 
        /// </summary>
        /// <param name="subscriptionParameters"></param>
        /// <returns></returns>
        PagedList<ManageSubscriptionDTO> GetSubscriptions(SubscriptionParameters subscriptionParameters);
        /// <summary>
        /// To get the user subscription by paging and filtering 
        /// </summary>
        /// <param name="userSubscriptionParameter"></param>
        /// <returns></returns>
        PagedList<UserSubscriptionDTO> GetUserSubscriptions(UserSubscriptionParameter userSubscriptionParameter);
    }
}