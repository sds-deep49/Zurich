using System.ComponentModel.DataAnnotations;

namespace Zurich.Domain.Models
{
    public class UserSubscription
    {
        /// <summary>
        /// User Subscription Id
        /// </summary>
        [Key]
        public int UserSubscriptionId { get; set; }
        /// <summary>
        /// User Id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Manage Subscription Id
        /// </summary>
        public int ManageSubscriptionId { get; set; }
        /// <summary>
        /// Manage Subscription
        /// </summary>
        public ManageSubscription ManageSubscription { get; set; }
        /// <summary>
        /// User
        /// </summary>
        public User User { get; set; }
    }
}