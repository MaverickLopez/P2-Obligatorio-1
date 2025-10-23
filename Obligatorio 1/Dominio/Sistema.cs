using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        //  --Listas--
        List<Usuario> _usuarios = new List<Usuario>();
        List<Publicacion> _publicaciones = new List<Publicacion>();
        List<Articulo> _articulos = new List<Articulo>();

        public Sistema()
        {
            Precarga();
        }

        // --Precarga de Datos--
        public void Precarga()
        {
            // --Creacion de Clientes--
            Usuario usuario1 = new Cliente("Juan", "Perez", "juanperez@gmail.com", "123456", 5000);
            Usuario usuario2 = new Cliente("Ana", "Gomez", "anagomez@yahoo.com", "abcdef", 3000);
            Usuario usuario3 = new Cliente("Luis", "Martinez", "luismartinez@hotmail.com", "qwerty", 7000);
            Usuario usuario4 = new Cliente("Sofia", "Lopez", "sofia.lopez@gmail.com", "pass123", 4500);
            Usuario usuario5 = new Cliente("Carlos", "Diaz", "carlosdiaz@outlook.com", "mypassword", 2500);
            Usuario usuario6 = new Cliente("Maria", "Rodriguez", "mrodriguez@gmail.com", "1234abcd", 6000);
            Usuario usuario7 = new Cliente("Fernando", "Hernandez", "ferhernandez@gmail.com", "ferrari", 8000);
            Usuario usuario8 = new Cliente("Lucia", "Cruz", "lucia.cruz@yahoo.com", "letmein", 5500);
            Usuario usuario9 = new Cliente("Jorge", "Torres", "jorge.torres@hotmail.com", "password1", 3500);
            Usuario usuario10 = new Cliente("Valeria", "Morales", "valeria.morales@gmail.com", "iloveyou", 4000);

            // --Alta de los Clientes--
            AltaUsuario(usuario1);
            AltaUsuario(usuario2);
            AltaUsuario(usuario3);
            AltaUsuario(usuario4);
            AltaUsuario(usuario5);
            AltaUsuario(usuario6);
            AltaUsuario(usuario7);
            AltaUsuario(usuario8);
            AltaUsuario(usuario9);
            AltaUsuario(usuario10);

            // --Creacion de los Administradores
            Usuario administrador1 = new Administrador("Luis", "Fernández", "luis.fernandez@gmail.com", "password123");
            Usuario administrador2 = new Administrador("Ana", "González", "ana.gonzalez@gmail.com", "qwerty");

            // --Alta de los Administradores
            AltaUsuario(administrador1);
            AltaUsuario(administrador2);

            // --Creacion de los Articulos--
            Articulo art1 = new Articulo("Camiseta", "Ropa", 500);
            Articulo art2 = new Articulo("Pantalones", "Ropa", 800);
            Articulo art3 = new Articulo("Zapatos", "Calzado", 1200);
            Articulo art4 = new Articulo("Chaqueta", "Ropa", 1500);
            Articulo art5 = new Articulo("Gorra", "Accesorios", 300);
            Articulo art6 = new Articulo("Vestido", "Ropa", 1000);
            Articulo art7 = new Articulo("Botas", "Calzado", 1800);
            Articulo art8 = new Articulo("Bufanda", "Accesorios", 400);
            Articulo art9 = new Articulo("Cinturón", "Accesorios", 600);
            Articulo art10 = new Articulo("Camisa", "Ropa", 700);
            Articulo art11 = new Articulo("Sudadera", "Ropa", 900);
            Articulo art12 = new Articulo("Shorts", "Ropa", 500);
            Articulo art13 = new Articulo("Zapatillas", "Calzado", 1300);
            Articulo art14 = new Articulo("Abrigo", "Ropa", 2000);
            Articulo art15 = new Articulo("Leggings", "Ropa", 750);
            Articulo art16 = new Articulo("Sandalias", "Calzado", 800);
            Articulo art17 = new Articulo("Sombrero", "Accesorios", 350);
            Articulo art18 = new Articulo("Chaleco", "Ropa", 950);
            Articulo art19 = new Articulo("Pañuelo", "Accesorios", 200);
            Articulo art20 = new Articulo("Traje", "Ropa", 2500);
            Articulo art21 = new Articulo("Mochila", "Accesorios", 700);
            Articulo art22 = new Articulo("Camiseta de deporte", "Ropa", 600);
            Articulo art23 = new Articulo("Botines", "Calzado", 1600);
            Articulo art24 = new Articulo("Jersey", "Ropa", 900);
            Articulo art25 = new Articulo("Tennis", "Calzado", 1100);
            Articulo art26 = new Articulo("Saco", "Ropa", 1700);
            Articulo art27 = new Articulo("Pantalones cortos", "Ropa", 400);
            Articulo art28 = new Articulo("Calzado deportivo", "Calzado", 1400);
            Articulo art29 = new Articulo("Camisón", "Ropa", 850);
            Articulo art30 = new Articulo("Chándal", "Ropa", 950);
            Articulo art31 = new Articulo("Chaqueta de cuero", "Ropa", 2200);
            Articulo art32 = new Articulo("Foulard", "Accesorios", 300);
            Articulo art33 = new Articulo("Bailarinas", "Calzado", 700);
            Articulo art34 = new Articulo("Sudadera con capucha", "Ropa", 850);
            Articulo art35 = new Articulo("Chaqueta impermeable", "Ropa", 1300);
            Articulo art36 = new Articulo("Pantalones de pijama", "Ropa", 400);
            Articulo art37 = new Articulo("Alpargatas", "Calzado", 600);
            Articulo art38 = new Articulo("Corbata", "Accesorios", 450);
            Articulo art39 = new Articulo("Camisa de cuadros", "Ropa", 800);
            Articulo art40 = new Articulo("Zapatos de vestir", "Calzado", 1500);
            Articulo art41 = new Articulo("Camiseta sin mangas", "Ropa", 550);
            Articulo art42 = new Articulo("Cazadora", "Ropa", 1800);
            Articulo art43 = new Articulo("Chancletas", "Calzado", 300);
            Articulo art44 = new Articulo("Bolso de mano", "Accesorios", 1200);
            Articulo art45 = new Articulo("Chaqueta de mezclilla", "Ropa", 1100);
            Articulo art46 = new Articulo("Pantalones de chándal", "Ropa", 800);
            Articulo art47 = new Articulo("Corte clásico", "Ropa", 900);
            Articulo art48 = new Articulo("Sandalias de playa", "Calzado", 350);
            Articulo art49 = new Articulo("Gafas de sol", "Accesorios", 500);
            Articulo art50 = new Articulo("Guantes", "Accesorios", 400);

            // --Alta de los Articulos--
            AltaArticulo(art1);
            AltaArticulo(art2);
            AltaArticulo(art3);
            AltaArticulo(art4);
            AltaArticulo(art5);
            AltaArticulo(art6);
            AltaArticulo(art7);
            AltaArticulo(art8);
            AltaArticulo(art9);
            AltaArticulo(art10);
            AltaArticulo(art11);
            AltaArticulo(art12);
            AltaArticulo(art13);
            AltaArticulo(art14);
            AltaArticulo(art15);
            AltaArticulo(art16);
            AltaArticulo(art17);
            AltaArticulo(art18);
            AltaArticulo(art19);
            AltaArticulo(art20);
            AltaArticulo(art21);
            AltaArticulo(art22);
            AltaArticulo(art23);
            AltaArticulo(art24);
            AltaArticulo(art25);
            AltaArticulo(art26);
            AltaArticulo(art27);
            AltaArticulo(art28);
            AltaArticulo(art29);
            AltaArticulo(art30);
            AltaArticulo(art31);
            AltaArticulo(art32);
            AltaArticulo(art33);
            AltaArticulo(art34);
            AltaArticulo(art35);
            AltaArticulo(art36);
            AltaArticulo(art37);
            AltaArticulo(art38);
            AltaArticulo(art39);
            AltaArticulo(art40);
            AltaArticulo(art41);
            AltaArticulo(art42);
            AltaArticulo(art43);
            AltaArticulo(art44);
            AltaArticulo(art45);
            AltaArticulo(art46);
            AltaArticulo(art47);
            AltaArticulo(art48);
            AltaArticulo(art49);
            AltaArticulo(art50);

            // --Creacion de las Ventas--
            Publicacion publicacion1 = new Venta("Verano en la playa", Estado.ABIERTA, DateTime.Now, null, null, null, true);
            Publicacion publicacion2 = new Venta("Escapada de invierno", Estado.ABIERTA, DateTime.Now.AddDays(-5), null, null, null, false);
            Publicacion publicacion3 = new Venta("Aventura en la montaña", Estado.ABIERTA, DateTime.Now.AddDays(2), null, null, null, true);
            Publicacion publicacion4 = new Venta("Curso de cocina", Estado.ABIERTA, DateTime.Now, null, null, null, true);
            Publicacion publicacion5 = new Venta("Concierto de rock", Estado.ABIERTA, DateTime.Now.AddDays(-1), null, null, null, true);
            Publicacion publicacion6 = new Venta("Exposición de arte", Estado.ABIERTA, DateTime.Now.AddDays(-10), null, null, null, false);
            Publicacion publicacion7 = new Venta("Taller de fotografía", Estado.ABIERTA, DateTime.Now.AddDays(3), null, null, null, true);
            Publicacion publicacion8 = new Venta("Maratón de películas", Estado.ABIERTA, DateTime.Now, null, null, null, true);
            Publicacion publicacion9 = new Venta("Feria de libros", Estado.ABIERTA, DateTime.Now.AddDays(-15), null, null, null, false);
            Publicacion publicacion10 = new Venta("Festival de música", Estado.ABIERTA, DateTime.Now.AddDays(1), null, null, null, true);

            // --Creacion de las Ofertas--
            Oferta oferta1 = new Oferta(usuario1, 150, DateTime.Now);
            Oferta oferta2 = new Oferta(usuario9, 2000, DateTime.Now.AddDays(-1));
            Oferta oferta3 = new Oferta(usuario8, 500, DateTime.Now.AddDays(5));
            Oferta oferta4 = new Oferta(usuario2, 300, DateTime.Now.AddDays(-8));
            Oferta oferta5 = new Oferta(usuario8, 100, DateTime.Now.AddDays(3));

            // --Creacion de las Subastas--
            Subasta publicacion11 = new Subasta("Festival de música", Estado.ABIERTA, DateTime.Now.AddDays(1), null, null, null);
            Subasta publicacion12 = new Subasta("Concierto de Rock", Estado.ABIERTA, DateTime.Now.AddDays(3), null, null, null);
            Subasta publicacion13 = new Subasta("Exposición de Arte", Estado.ABIERTA, DateTime.Now.AddDays(5), null, null, null);
            Subasta publicacion14 = new Subasta("Torneo de Videojuegos", Estado.ABIERTA, DateTime.Now.AddDays(2), null, null, null);
            Subasta publicacion15 = new Subasta("Feria Gastronómica", Estado.ABIERTA, DateTime.Now.AddDays(4), null, null, null);
            Subasta publicacion16 = new Subasta("Maratón de Cine", Estado.ABIERTA, DateTime.Now.AddDays(1), null, null, null);
            Subasta publicacion17 = new Subasta("Conferencia de Tecnología", Estado.ABIERTA, DateTime.Now.AddDays(6), null, null, null);
            Subasta publicacion18 = new Subasta("Festival de Danza", Estado.ABIERTA, DateTime.Now.AddDays(2), null, null, null);
            Subasta publicacion19 = new Subasta("Competencia de Cocina", Estado.ABIERTA, DateTime.Now.AddDays(3), null, null, null);
            Subasta publicacion20 = new Subasta("Feria de Libros", Estado.ABIERTA, DateTime.Now.AddDays(5), null, null, null);

            // --Agregar Articulos a las Publicaciones--
            publicacion1.AgregarArticulo(art1);
            publicacion1.AgregarArticulo(art50);
            publicacion11.AgregarArticulo(art10);
            publicacion11.AgregarArticulo(art15);
            publicacion13.AgregarArticulo(art29);
            publicacion13.AgregarArticulo(art14);
            publicacion19.AgregarArticulo(art43);
            publicacion19.AgregarArticulo(art38);

            // --Agregar Ofertas a las Subastas--
            publicacion11.AgregarOferta(oferta1);
            publicacion11.AgregarOferta(oferta5);
            publicacion13.AgregarOferta(oferta3);
            publicacion13.AgregarOferta(oferta2);
            publicacion19.AgregarOferta(oferta4);

            // --Alta de las Publicaciones--
            AltaPublicacion(publicacion1);
            AltaPublicacion(publicacion2);
            AltaPublicacion(publicacion3);
            AltaPublicacion(publicacion4);
            AltaPublicacion(publicacion5);
            AltaPublicacion(publicacion6);
            AltaPublicacion(publicacion7);
            AltaPublicacion(publicacion8);
            AltaPublicacion(publicacion9);
            AltaPublicacion(publicacion10);
            AltaPublicacion(publicacion11);
            AltaPublicacion(publicacion12);
            AltaPublicacion(publicacion13);
            AltaPublicacion(publicacion14);
            AltaPublicacion(publicacion15);
            AltaPublicacion(publicacion16);
            AltaPublicacion(publicacion17);
            AltaPublicacion(publicacion18);
            AltaPublicacion(publicacion19);
            AltaPublicacion(publicacion20);
        }

        // --Get de todas las Publicaciones--
        public List<Publicacion> GetPublicaciones()
        {
            return _publicaciones;
        }

        // --Get de todos los Usuarios--
        public List<Usuario> GetUsuarios()
        {
            return _usuarios;
        }

        // --Get de todos los Clientes--
        public List<Cliente> GetClientes()
        {
            List<Cliente> _clientes = new List<Cliente>();

            foreach (Usuario u in _usuarios)
            {
                if (u is Cliente c)
                {
                    _clientes.Add(c);
                }
            }
            return _clientes;
        }

        // --Alta de la Publicacion--
        public void AltaPublicacion(Publicacion p)
        {
            p.EsValido();
            _publicaciones.Add(p);
        }

        // --Alta del Usuario--
        public void AltaUsuario(Usuario u)
        {
            u.EsValido();
            _usuarios.Add(u);
        }

        // --Alta del Articulo--
        public void AltaArticulo(Articulo a)
        {
            try
            {
                a.EsValido();
                _articulos.Add(a);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        // --Get de todas las Categorias--
        public List<string> GetCategorias()
        {
            List<string> ret = new List<string>();
            foreach (Articulo a in _articulos)
            {
                if (!ret.Contains(a.Categoria))
                {
                    ret.Add(a.Categoria);
                }
            }
            return ret;
        }

        // --Get de los Articulos filtrado por Categoria ingresada--
        public List<Articulo> GetArticulosPorCategoria(string cat)
        {
            List<Articulo> ret = new List<Articulo>();

            foreach (Articulo a in _articulos)
            {
                if (a.Categoria == cat)
                {
                    ret.Add(a);
                }
            }
            return ret;
        }

        // --Get de las Publicaciones por 2 Fechas ingresadas--
        public List<Publicacion> GetPublicacionesPor2Fechas(DateTime f1, DateTime f2)
        {
            List<Publicacion> ret = new List<Publicacion>();

            foreach (Publicacion p in GetPublicaciones())
            {
                if (p.FechaPublicacion >= f1 && p.FechaPublicacion <= f2)
                {
                    ret.Add(p);
                }
            }
            return ret;
        }
    }
}
