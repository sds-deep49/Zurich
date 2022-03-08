using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Zurich.Domain.Interfaces;

namespace Zurich.Repository.DataLayer
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        #region "Protected fields"
        protected readonly ZurichDbContext _context;
        #endregion

        #region "Constructor"
        protected GenericRepository(ZurichDbContext context)
        {            
            _context = context;
        }
        #endregion

        #region "Implementations"
        /// <summary>
        /// Get records by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> Get(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        /// <summary>
        /// Add entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        /// <summary>
        /// Delete Entity
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {            
            _context.Set<T>().Update(entity);
        }
        #endregion
    }
}