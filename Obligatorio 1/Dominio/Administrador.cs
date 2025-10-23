using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Administrador : Usuario
    {
        public Administrador(string nombre, string apellido, string email, string contrasenia) : base(nombre, apellido, email, contrasenia)
        {
        }

        // --Validacion
        public override void EsValido()
        {
            if (Nombre.Length < 2)
            {
                throw new Exception("El nombre no puede contener menos de 2 caracteres");
            }
            if (Apellido.Length < 2)
            {
                throw new Exception("El apellido no puede contener menos de 2 caracteres");
            }
            if (EmailEsValido() == false)
            {
                throw new Exception("El email no es valido");
            }
        }
    }
}
