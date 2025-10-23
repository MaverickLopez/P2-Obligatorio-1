using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        private static int _ultimoId = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Precio { get; set; }

        public Articulo(string nombre,string categoria, int precio)
        {
            Id = _ultimoId++;
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }

        public Articulo()
        {
            Id= _ultimoId++;
        }

        // --Validacion
        public void EsValido()
        {
            if (Nombre.Length < 3)
            {
                throw new Exception("El Nombre no debe contener menos de 3 caracteres");
            }
            if (Precio < 0)
            {
                throw new Exception("El Precio no puede ser menor de 0");
            }
        }
    }
}
