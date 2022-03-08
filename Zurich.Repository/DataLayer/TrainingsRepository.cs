using Zurich.Domain.Interfaces;
using Zurich.Domain.Models;

namespace Zurich.Repository.DataLayer
{
    public class TrainingsRepository : GenericRepository<Trainings>, ITrainingsRepository
    {
        public TrainingsRepository(ZurichDbContext context) : base(context)
        {

        }
    }
}