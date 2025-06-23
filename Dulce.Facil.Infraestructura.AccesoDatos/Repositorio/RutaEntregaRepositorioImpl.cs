using DulceFacil.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulce.Facil.Infraestructura.AccesoDatos.Repositorio
{
    public class RutaEntregaRepositorioImpl : RepositorioImpl<RUTA_ENTREGA>, IRutaEntregaRepositorio
    {
        public RutaEntregaRepositorioImpl(Sistema_PedidosContext dbContext) : base(dbContext)
        {
        }
    }
}
