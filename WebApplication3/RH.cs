using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EPonto
{
    public class RH
    {
        [Required, StringLength(70), Key]
        public string Email { get; set; }

        [Required, StringLength(32)]
        public string Senha { get; set; }
    }
}
