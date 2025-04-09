using System;
using System.ComponentModel.DataAnnotations;
using SalasAluguer.Data;

namespace SalasAluguer.Data
{
    public class Reservas
    {
        /// <summary>
        /// Identificador da reserva
        /// </summary>
        [Key]
        public int IdReserva { get; set; }

        /// <summary>
        /// Identificador do utilizador que fez a reserva
        /// </summary>
        public int IdUtilizador { get; set; }

        /// <summary>
        /// Identificador da sala reservada
        /// </summary>
        public int IdSala { get; set; }

        /// <summary>
        /// Data e hora de início da reserva
        /// </summary>
        public DateTime DataHoraInicio { get; set; }

        /// <summary>
        /// Data e hora de fim da reserva
        /// </summary>
        public DateTime DataHoraFim { get; set; }

        /// <summary>
        /// Status da reserva
        /// </summary>
        public string Status { get; set; }

        // Relacionamento com a tabela Utilizadores
        public Utilizadores Utilizador { get; set; }

        // Relacionamento com a tabela Salas
        public Salas Sala { get; set; }
    }
}
