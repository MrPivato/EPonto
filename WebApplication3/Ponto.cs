using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EPonto
{
    public class Ponto
    {
        public int Id { get; set; }

        [Required, StringLength(14)]
        public string CpfFuncionario { get; set; }

        [Required]
        public string HoraPonto { get; set; }
        // [1] - [0] e [2] - [3]

    }
}
