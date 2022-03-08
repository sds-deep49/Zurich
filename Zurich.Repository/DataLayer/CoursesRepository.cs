using Zurich.Domain.Interfaces;
using Zurich.Domain.Models;

namespace Zurich.Repository.DataLayer
{
    public class CoursesRepository : GenericRepository<Courses>, ICoursesRepository
    {
        public CoursesRepository(ZurichDbContext context) : base(context)
        {

        }
    }
}