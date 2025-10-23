using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Subasta : Publicacion
    {
        List<Oferta> _ofertas = new List<Oferta>();

        public Subasta(string nombre, Estado estado, DateTime fechaPublicacion, Usuario? cliente, DateTime? fechaFinalizacion, Usuario? finalizador) : base(nombre, estado, fechaPublicacion, cliente, fechaFinalizacion, finalizador)
        {
        }

        // --Alta de Oferta a la Subasta
        public void AgregarOferta(Oferta o)
        {
            _ofertas.Add(o);
        }

        // --Validacion
        public override void EsValido()
        {
            if (Nombre.Length < 2)
            {
                throw new Exception("El nombre no puede tener menos de 2 caracteres");
            }
        }
    }
}
