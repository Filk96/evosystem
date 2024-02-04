
using AutoMapper;
using UM.Domain.DBModel;
using UM.Domain.Model;
using UM.Domain.ViewModel;

namespace UM.Domain.Mapping
{
    public class EmployeeMapping : Profile
    {
        public EmployeeMapping()
        {
            CreateMap<Funcionario, EmployeeModel>()
                .ReverseMap();
            CreateMap<Funcionario, EmployeeViewModel>()
                .ForMember(u => u.Department, opt => opt.MapFrom(x => x.Department.Name))
                .ReverseMap();
        }
    }
}