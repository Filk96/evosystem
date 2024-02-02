using UM.Domain.Model;

namespace UM.Domain.DBModel
{
    public class Departamento : BaseModel<int>
    {
        public int Name { get; set; }
        public int Sigla { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
    }
}
