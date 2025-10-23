using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente : Usuario
    {
        public int Saldo { get; set; }
        public Cliente(string nombre, string apellido, string email, string contrasenia, int saldo) : base(nombre, apellido, email, contrasenia)
        {
            Saldo = saldo;
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
            if (Saldo<0)
            {
                throw new Exception("El saldo no puede ser menor a 0");
            }

        }
    }
}
