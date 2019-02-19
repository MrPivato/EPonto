using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EPonto
{
    public class Funcionario
    {
        [Required, StringLength(14), Key]
        public string Cpf { get; set; }

        [Required, StringLength(55)]
        public string Nome { get; set; }

        [Required, StringLength(70)]
        public string Email { get; set; }

        [Required, StringLength(8)]
        public string CargaHoraria { get; set; }

        //public ICollection<Ponto> Pontos { get; set; }

        /* [Required]
         public string HoraPonto { get; set; }

         public string HorasTrabalhadas { get; set; }

         public string HorasExtras { get; set; }

         public int Contador { get; set; }
         */
    }
}