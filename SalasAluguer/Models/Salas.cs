using System.ComponentModel.DataAnnotations;
using SalasAluguer.Models;
using SalasAluguer.Data;

namespace SalasAluguer.Data
{
    public class Salas
    {
        [Key]
        public int Id { get; set; }

        // Valida��o para garantir que o nome da sala � obrigat�rio e n�o exceda 255 caracteres
        [Required(ErrorMessage = "O {0} � de preenchimento obrigat�rio.")]
        [StringLength(255, ErrorMessage = "O {0} deve ter no m�ximo {1} caracteres.")]
        public string NomeSala { get; set; }

        // Valida��o para garantir que a capacidade da sala � obrigat�ria
        [Required(ErrorMessage = "A {0} � de preenchimento obrigat�rio.")]
        public int Capacidade { get; set; }

        // A descri��o da sala pode ser opcional
        public string Descricao { get; set; }

        // Relacionamento com a tabela Disponibilidade (se houver)
        public ICollection<Disponibilidade> Disponibilidades { get; set; }

        // Relacionamento com a tabela Reserva (se houver)
        public ICollection<Reservas> Reservas { get; set; }
    }
}
