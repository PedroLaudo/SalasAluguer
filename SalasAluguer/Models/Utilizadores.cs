using System.ComponentModel.DataAnnotations;

namespace SalasAluguer.Data
{
    public class Utilizadores
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O {0} � de preenchimento obrigat�rio.")]
        [StringLength(255, ErrorMessage = "O {0} deve ter no m�ximo {1} caracteres.")]
        public string Nome { get; set; }

        [StringLength(255, ErrorMessage = "O {0} deve ter no m�ximo {1} caracteres.")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "A {0} � de preenchimento obrigat�rio.")]
        [StringLength(255, ErrorMessage = "A {0} deve ter no m�ximo {1} caracteres.")]
        public string Password { get; set; }
    }
}
