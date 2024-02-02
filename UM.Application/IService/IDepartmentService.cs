using UM.Domain.Model;
using UM.Domain.ViewModel;

namespace UM.Application.IService
{
    public interface IDepartmentService
    {
        Task Add(DepartmentModel country);
        Task<List<DepartmentViewModel>> GetAll();
        Task<DepartmentViewModel> GetById(int id);
        Task Update(DepartmentModel country);
        Task Delete(int id);
    }
}
