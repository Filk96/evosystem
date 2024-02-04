using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UM.Application.IService;
using UM.Domain.DBModel;
using UM.Domain.IRepository;
using UM.Domain.Model;
using UM.Domain.ViewModel;
using UM.Infrastructure.DBContext;

namespace UM.Application.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _context;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper, ApplicationDbContext context)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
            _context = context;
        }
        public async Task Add(EmployeeModel employee)
        {
            var result = _mapper.Map<Funcionario>(employee);
            await _employeeRepository.Insert(result);
            await _employeeRepository.SaveAsync();
        }

        public async Task Delete(int id)
        {
            await _employeeRepository.Delete(id);
            await _employeeRepository.SaveAsync();
        }

        public async Task<List<EmployeeViewModel>> GetAll()
        {
            var result = await _context.Employee.Include(x => x.Department).ToListAsync();
            var data = _mapper.Map<List<EmployeeViewModel>>(result);
            return data;
        }

        public async Task<EmployeeViewModel> GetById(int id)
        {
            var result = await _employeeRepository.GetById(id);
            var data = _mapper.Map<EmployeeViewModel>(result);
            return data;
        }

        public async Task Update(EmployeeModel employee)
        {
            var existingEmployee = await _employeeRepository.FindBy(x => x.Id == employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Foto = employee.Foto;
                existingEmployee.RG = employee.RG;
                existingEmployee.DepartmentId = employee.DepartmentId;
                await _employeeRepository.Update(existingEmployee);
                await _employeeRepository.SaveAsync();
            }
        }
    }
}
