using System;
using System.ComponentModel.DataAnnotations;

namespace SalasAluguer.Data
{
    public class Disponibilidade
    {
        /// <summary>
        /// Identificador da disponibilidade
        /// </summary>
        [Key]
        public int IdDisponibilidade { get; set; }

        /// <summary>
        /// Identificador da sala
        /// </summary>
        public int IdSala { get; set; }

        /// <summary>
        /// Dia da semana em que a sala est� dispon�vel
        /// </summary>
        public string DiaSemana { get; set; }

        /// <summary>
        /// Hora de in�cio da disponibilidade
        /// </summary>
        public TimeSpan HoraInicio { get; set; }

        /// <summary>
        /// Hora de fim da disponibilidade
        /// </summary>
        public TimeSpan HoraFim { get; set; }

        // Relacionamento com a tabela Salas
        public Salas Sala { get; set; }
    }
}
