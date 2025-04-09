using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalasAluguer.Data
{
    public class Funcionario
    {
        [Key, ForeignKey("Utilizador")]
        public int Id { get; set; }

        public Utilizadores Utilizador { get; set; }
    }
}
