using System.ComponentModel.DataAnnotations;

namespace Zurich.Domain.Models
{
    public class Subscription : ModelBase
    {
        /// <summary>
        /// Subscription Id
        /// </summary>
        [Key]
        public int SubscriptionId { get; set; }
        /// <summary>
        /// Subscription Type
        /// </summary>
        public string SubscriptionType { get; set; }
        /// <summary>
        /// Subscription Code
        /// </summary>
        public string SubscriptionCode { get; set; }
    }
}