using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendedores.Domain.Entidades
{
    [JsonObject("VendedoresOutput")]
    public class VendedoresOutput
    {

        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("dataInclusao")]
        public DateTime DataInclusao { get; set; }

        [JsonProperty("dataAlteracao")]
        public DateTime DataAlteracao { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("dataAdmissao")]
        public DateTime DataAdmissao { get; set; }

        [JsonProperty("salario")]
        public double Salario { get; set; }

        [JsonProperty("comissao")]
        public double Comissao { get; set; }

    }

}

