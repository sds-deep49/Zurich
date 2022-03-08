using System.ComponentModel.DataAnnotations;

namespace Zurich.Domain.Models
{
    public class ManageSubscription
    {
        /// <summary>
        /// Manage Subscription Id
        /// </summary>
        [Key]
        public int ManageSubscriptionId { get; set; }
        /// <summary>
        /// Subscription Id
        /// </summary>
        public int SubscriptionId { get; set; }
        /// <summary>
        /// Trainings Id
        /// </summary>
        public int TrainingsId { get; set; }
        /// <summary>
        /// Subscription
        /// </summary>
        public Subscription Subscription { get; set; }
        /// <summary>
        /// Trainings
        /// </summary>
        public Trainings Trainings { get; set; }        
    }
}