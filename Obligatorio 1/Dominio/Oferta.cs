using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Oferta
    {
        private static int _ultimoId = 1;
        public int Id { get; set; }
        public Usuario Cliente { get; set; }
        public int Monto { get; set; }
        public DateTime Fecha { get; set; }

        public Oferta(Usuario cliente, int monto, DateTime fecha)
        {
            Id = _ultimoId++;
            Cliente = cliente;
            Monto = monto;
            Fecha = fecha;
        }
        public Oferta()
        {
            Id = _ultimoId++;
        }

        // --Validacion
        public void EsValido()
        {
            if (Cliente.Id < 1)
            {
                throw new Exception("El cliente no existe");
            }
            if (Monto < 1)
            {
                throw new Exception("El monto no puede ser menor a 1");
            }
        }
    }
}
