using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TesteMarttech.Models
{
    public class Cliente
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime DtNascimento { get; set; }

        public ICollection<Endereco> Enderecos { get; set; }
    }
}
