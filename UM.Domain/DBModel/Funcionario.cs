using UM.Domain.Model;

namespace UM.Domain.DBModel
{
    public class Funcionario : BaseModel<int>
    {
        public string Name { get; set; }
        public string Foto { get; set; }
        public string RG { get; set; }
        public int DepartmentId { get; set; }
        public virtual Departamento Departamento { get; set; }
    }
}
