using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta : Publicacion
    {
        public bool OfertaRelampago { get; set; }
        public Venta(string nombre, Estado estado, DateTime fechaPublicacion, Usuario? cliente, DateTime? fechaFinalizacion, Usuario? finalizador,bool ofertarelampago) : base(nombre, estado, fechaPublicacion, cliente, fechaFinalizacion, finalizador)
        {
            OfertaRelampago=ofertarelampago;
        }

        // --Validacion
        public override void EsValido()
        {
            if (Nombre.Length<2)
            {
                throw new Exception("El nombre no puede tener menos de 2 caracteres"); 
            }
        }
    }
}
