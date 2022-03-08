namespace Zurich.Domain.Models
{
    public class Status : ModelBase
    {
        /// <summary>
        /// Status Id
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Status Type Id
        /// </summary>
        public int TypeId { get; set; }
    }
}