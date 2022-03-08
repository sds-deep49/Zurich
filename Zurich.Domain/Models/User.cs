namespace Zurich.Domain.Models
{
    public class User
    {
        /// <summary>
        /// User Id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// User Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// User Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// User Gender
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// User Status
        /// </summary>
        public string Status { get; set; }
    }
}
