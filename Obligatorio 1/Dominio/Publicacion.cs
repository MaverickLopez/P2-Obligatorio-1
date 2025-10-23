using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Publicacion
    {
        private static int _ultimoId = 1;

        public List<Articulo> _articulos = new List<Articulo>();

        public int Id { get; set; }
        public string Nombre { get; set; }
        public Estado Estado { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public Usuario? Cliente { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public Usuario? Finalizador { get; set; }

        protected Publicacion(string nombre, Estado estado, DateTime fechaPublicacion, Usuario? cliente, DateTime? fechaFinalizacion, Usuario? finalizador)
        {
            Id = _ultimoId++;
            Nombre = nombre;
            Estado = estado;
            FechaPublicacion = fechaPublicacion;
            Cliente = cliente;
            FechaFinalizacion = fechaFinalizacion;
            Finalizador = finalizador;
        }

        protected Publicacion()
        {
            Id = _ultimoId++;
        }

        // --Alta de Articulo a la Publicacion
        public void AgregarArticulo(Articulo a)
        {
            _articulos.Add(a);
        }

        // --Validacion
        public abstract void EsValido();
    }
}
