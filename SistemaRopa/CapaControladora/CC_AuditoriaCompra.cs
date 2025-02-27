// Se importan los espacios de nombres necesarios
using CapaDatos;  // Permite acceder a la capa de datos
using CapaEntidad; // Permite acceder a las entidades (modelos de datos)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Se define el namespace de la capa controladora
namespace CapaControladora
{
    // Se declara la clase CC_AuditoriaCompra (Controladora de Auditoría de Compras)
    public class CC_AuditoriaCompra
    {
        // Se crea un objeto de la capa de datos para acceder a la base de datos
        private CD_AuditoriaCompra oCD_AuditoriaCompra = new CD_AuditoriaCompra();

        /// <summary>
        /// Método para listar todas las auditorías de compras
        /// </summary>
        /// <returns>Lista de objetos AuditoriaCompra</returns>
        public List<AuditoriaCompra> ListarAuditoriaCompras()
        {
            try
            {
                // Llama al método de la capa de datos que obtiene todas las auditorías de compras
                return oCD_AuditoriaCompra.ListarAuditoriaCompras();
            }
            catch (Exception ex)
            {
                // En caso de error, lanza una excepción con el mensaje de error
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Método para obtener una auditoría de compra específica por su ID
        /// </summary>
        /// <param //name="idAuditoriaCompra >ID de la auditoría de compra</param>
        /// <returns>Objeto AuditoriaCompra con su información</returns>
        public AuditoriaCompra ObtenerAuditoriaCompra(int idAuditoriaCompra)
        {
            try
            {
                // Llama al método de la capa de datos que obtiene una auditoría específica
                AuditoriaCompra oAuditoriaCompra = oCD_AuditoriaCompra.ObtenerAuditoriaCompra(idAuditoriaCompra);

                // Si la auditoría existe (su ID no es 0)
                if (oAuditoriaCompra.IdAuditoriaCompra != 0)
                {
                    // Obtiene los detalles asociados a esa auditoría de compra
                    List<AuditoriaDetalleCompra> oAuditoriaDetalleCompra = oCD_AuditoriaCompra.ObtenerAuditoriaDetalleCompra(oAuditoriaCompra.IdAuditoriaCompra);

                    // Asigna los detalles a la auditoría principal
                    oAuditoriaCompra.oAuditoriaDetalleCompra = oAuditoriaDetalleCompra;
                }

                // Retorna la auditoría de compra con sus detalles
                return oAuditoriaCompra;
            }
            catch (Exception ex)
            {
                // En caso de error, lanza una excepción con el mensaje de error
                throw new Exception(ex.Message);
            }
        }
    }
}
