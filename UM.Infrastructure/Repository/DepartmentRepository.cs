
using UM.Domain.DBModel;
using UM.Domain.IRepository;
using UM.Infrastructure.DBContext;

namespace UM.Infrastructure.Repository
{
    public class DepartmentRepository : Repository<Departamento, int>, IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}