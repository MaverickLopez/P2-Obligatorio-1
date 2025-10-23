using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Usuario
    {
        private static int _ultimoId = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }

        protected Usuario(string nombre, string apellido, string email, string contrasenia)
        {
            Id=_ultimoId++;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Contrasenia = contrasenia;
        }
        protected Usuario()
        {
            Id = _ultimoId++;
        }

        // --Validacion
        public abstract void EsValido(); 

        // --Validacion del Email
        protected virtual bool EmailEsValido()
        {
            bool cumple = true;

            int posArroba = Email.IndexOf("@");

            if (posArroba != -1)
            {
                if (posArroba == 0)
                {
                    cumple = false;
                }
                if (posArroba == Email.Length - 1)
                {
                    cumple = false;
                }
            }
            else
            {
                cumple = false;
            }
            return cumple;
        }



    }
}
