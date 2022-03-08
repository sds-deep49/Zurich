using System.ComponentModel.DataAnnotations;

namespace Zurich.Domain.Models
{
    public class Trainings : ModelBase
    {
        /// <summary>
        /// Training Id
        /// </summary>
        [Key]
        public int TrainingsId { get; set; }
        /// <summary>
        /// Training Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Training Code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Course Id
        /// </summary>
        public int CoursesId { get; set; }
        /// <summary>
        /// Training Month
        /// </summary>
        public string Month { get; set; }
        /// <summary>
        /// Training Status Id
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public Status Status { get; set; }
        /// <summary>
        /// Courses
        /// </summary>
        public Courses Courses { get; set; }
    }
}