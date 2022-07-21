using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendedores.Domain.Entidades;

namespace Vendedores.Domain.Interfaces
{
    public interface IVendedoresService
    {

        void RemovePorId(List<VendedoresOutput> vendedores);

        void AlteraPorId(List<VendedoresOutput> vendedores);

        void ShowDezVendedores(List<VendedoresOutput> vendedores);

        void PesquisaPorId(List<VendedoresOutput> vendedores);

    }
}
