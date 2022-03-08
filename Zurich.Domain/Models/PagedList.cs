using System;
using System.Collections.Generic;
using System.Linq;

namespace Zurich.Domain.Models
{
    /// <summary>
    /// For paging
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagedList<T> : List<T>
    {
        /// <summary>
        /// Current Page
        /// </summary>
        public int CurrentPage { get; private set; }
        /// <summary>
        /// Total Pages
        /// </summary>
        public int TotalPages { get; private set; }
        /// <summary>
        /// Page Size
        /// </summary>
        public int PageSize { get; private set; }
        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; private set; }
        /// <summary>
        /// Has Previous Page
        /// </summary>
        public bool HasPrevious => CurrentPage > 1;
        /// <summary>
        /// Has Next Page
        /// </summary>
        public bool HasNext => CurrentPage < TotalPages;

        /// <summary>
        /// Manage Paging
        /// </summary>
        /// <param name="items"></param>
        /// <param name="count"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
        }

        /// <summary>
        /// To get total count, paging
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PagedList<T> ToPagedList(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
    }
}