using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendedores.Domain.Entidades;

namespace Vendedores.Domain.Interfaces
{
    public interface IVendedoresRepository
    {
        public List<VendedoresOutput> DesserializacaoJson(string path);

        public void SerializacaoJsonOutput(List<VendedoresOutput> vendedores);

        void PopulaListaJson(List<VendedoresOutput> vendedores);
    }
}
