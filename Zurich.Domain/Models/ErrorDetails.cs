using System.Text.Json;

namespace Zurich.Domain.Models
{
    public class ErrorDetails
    {
        /// <summary>
        /// Error status code
        /// </summary>
        public int StatusCode { get; set; }
        /// <summary>
        /// Error message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Override ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}