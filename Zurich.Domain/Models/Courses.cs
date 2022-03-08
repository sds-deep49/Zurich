using System.ComponentModel.DataAnnotations;

namespace Zurich.Domain.Models
{
    public class Courses
    {
        /// <summary>
        /// Course Id
        /// </summary>
        [Key]
        public int CoursesId { get; set; }
        /// <summary>
        /// Course Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Course Code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Course Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Course Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Course status id
        /// </summary>
        public int StatusId { get; set; }
    }
}