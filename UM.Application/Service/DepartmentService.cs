using AutoMapper;
using UM.Application.IService;
using UM.Domain.DBModel;
using UM.Domain.IRepository;
using UM.Domain.Model;
using UM.Domain.ViewModel;

namespace UM.Application.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public DepartmentService(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public async Task Add(DepartmentModel Department)
        {
            var result = _mapper.Map<Departamento>(Department);
            await _departmentRepository.Insert(result);
            await _departmentRepository.SaveAsync();
        }

        public async Task Delete(int id)
        {
            await _departmentRepository.Delete(id);
            await _departmentRepository.SaveAsync();
        }

        public async Task<List<DepartmentViewModel>> GetAll()
        {
            var result = await _departmentRepository.GetAll();
            var data = _mapper.Map<List<DepartmentViewModel>>(result);
            return data;
        }

        public async Task<DepartmentViewModel> GetById(int id)
        {
            var result = await _departmentRepository.GetById(id);
            var data = _mapper.Map<DepartmentViewModel>(result);
            return data;
        }

        public async Task Update(DepartmentModel department)
        {
            var existingDepartment = await _departmentRepository.FindBy(x => x.Id == department.Id);
            if (existingDepartment != null)
            {
                existingDepartment.Name = department.Name;
                existingDepartment.Sigla = department.Sigla;
                await _departmentRepository.Update(existingDepartment);
                await _departmentRepository.SaveAsync();
            }
        }
    }
}
