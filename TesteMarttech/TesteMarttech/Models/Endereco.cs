using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TesteMarttech.Models
{
    public class Endereco
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        public string Numero { get; set; }

        
        public string Complemento { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string CEP { get; set; }

        [Required]
        public string UF { get; set; }

        public virtual Cliente Clientes { get; set; }


    }
}