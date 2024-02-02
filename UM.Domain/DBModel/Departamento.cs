using UM.Domain.Model;

namespace UM.Domain.DBModel
{
    public class Departamento : BaseModel<int>
    {
        public string Name { get; set; }
        public string Sigla { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
    }
}
