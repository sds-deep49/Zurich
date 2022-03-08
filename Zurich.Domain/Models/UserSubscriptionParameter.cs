namespace Zurich.Domain.Models
{
    public class UserSubscriptionParameter : Parameters
    {
        /// <summary>
        /// Training Name
        /// </summary>
        public string TrainingName { get; set; }
        /// <summary>
        /// Course Name
        /// </summary>
        public string CourseName { get; set; }
        /// <summary>
        /// Training Month
        /// </summary>
        public string Month { get; set; }
        /// <summary>
        /// User Name
        /// </summary>
        public string UserName { get; set; }
    }
}