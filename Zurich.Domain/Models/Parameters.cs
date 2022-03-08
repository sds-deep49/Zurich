namespace Zurich.Domain.Models
{
    /// <summary>
    /// Paging Parameters
    /// </summary>
    public abstract class Parameters
    {
        /// <summary>
        /// Defined Max Page Size 
        /// </summary>
        private const int _maxPageSize = 50;
        /// <summary>
        /// Default Page Number Set to 1 
        /// </summary>
        public int PageNumber { get; set; } = 1;
        /// <summary>
        /// Default Page Size Set to 10
        /// </summary>
        private int _pageSize = 10;
        /// <summary>
        /// read/write page size
        /// </summary>
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > _maxPageSize) ? _maxPageSize : value;
            }
        }
    }
}