
using UM.Domain.Model;
using UM.Domain.ViewModel;

namespace UM.Application.IService
{
    public interface IEmployeeService
    {
        Task Add(EmployeeModel country);
        Task<List<EmployeeViewModel>> GetAll();
        Task<EmployeeViewModel> GetById(int id);
        Task Update(EmployeeModel country);
        Task Delete(int id);
    }
}
