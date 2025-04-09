using System.ComponentModel.DataAnnotations;
using SalasAluguer.Data;

namespace SalasAluguer.Data
{
    public class Limpeza
    {
        /// <summary>
        /// Identificador da sala
        /// </summary>
        public int IdSala { get; set; }

        /// <summary>
        /// Identificador do utilizador respons�vel pela limpeza
        /// </summary>
        public int IdUtilizador { get; set; }

        /// <summary>
        /// Dia da semana em que a limpeza � realizada
        /// </summary>
        public string DiaSemana { get; set; }

        // Relacionamento com a tabela Salas
        public Salas Sala { get; set; }

        // Relacionamento com a tabela Funcionario
        public Funcionario Funcionario { get; set; }
    }
}
