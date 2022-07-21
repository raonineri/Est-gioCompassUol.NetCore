using Newtonsoft.Json;
using Vendedores.Domain.Entidades;
using Vendedores.Domain.Interfaces;

namespace Vendedores.Data
{
    public class VendedoresRepository : IVendedoresRepository
    {

        public List<VendedoresOutput> DesserializacaoJson(string path)
        {
            List<VendedoresOutput> vendedores = new List<VendedoresOutput>();
            using (StreamReader streamReader = new StreamReader(path))
            {
                var jsonString = streamReader.ReadToEnd();
                vendedores = JsonConvert.DeserializeObject<List<VendedoresOutput>>(jsonString);

            }

            return vendedores;
        }

        public void SerializacaoJsonOutput(List<VendedoresOutput> vendedores)
        {
            var jsonSerializado = JsonConvert.SerializeObject(vendedores);
            using (StreamWriter streamWriter = new StreamWriter("vendedoresOutput.json"))
            {
                streamWriter.Write(jsonSerializado);
            }
        }

        public void PopulaListaJson(List<VendedoresOutput> vendedores)
        {
            foreach (var vendedor in vendedores)
            {
                vendedor.Id = Guid.NewGuid();
                vendedor.DataInclusao = DateTime.Now;
                vendedor.DataAlteracao = DateTime.Now;
            }
        }

    }
}
