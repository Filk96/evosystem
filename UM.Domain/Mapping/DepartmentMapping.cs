using AutoMapper;
using UM.Domain.DBModel;
using UM.Domain.Model;
using UM.Domain.ViewModel;

namespace UM.Domain.Mapping
{
    public class DepartmentMapping : Profile
    {
        public DepartmentMapping()
        {
            CreateMap<Departamento, DepartmentModel>()
                .ReverseMap();
            CreateMap<Departamento, DepartmentViewModel>()
                .ReverseMap();
        }
    }
}