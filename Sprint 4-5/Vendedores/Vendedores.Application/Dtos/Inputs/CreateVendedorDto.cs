using System.ComponentModel.DataAnnotations;

namespace Vendedores.Application.Dtos.Inputs
{
    public class CreateVendedorDto
    {

        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string DocIdentificacao { get; set; }

    }
}
