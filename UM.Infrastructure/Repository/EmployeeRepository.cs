using UM.Domain.DBModel;
using UM.Domain.IRepository;
using UM.Infrastructure.DBContext;

namespace UM.Infrastructure.Repository
{
    public class EmployeeRepository : Repository<Funcionario, int>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
