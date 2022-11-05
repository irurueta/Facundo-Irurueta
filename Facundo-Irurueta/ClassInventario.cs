using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facundo_Irurueta
{
    public class Usuario
    {
        public int Id;// { get; set; } 
        public string Nombre;// { get; set; }
        public string Apellido;// { get; set; }
        public string NombreUsuario;// { get; set; }
        public string Contraseña;// { get; set; }
        public string Mail;// { get; set; }
    }



    public class Producto
    {
        public int Id;// { get; set; }
        public string descripcion;// { get; set; }
        public double Costo;//{ get; set; }   
        public double PrecioVenta;// { get; set; }
        public double Stock;// { get; set; } //Stock double porque un stock por ejemplo puede ser por metro 0.58mts
        public int idUsuario;// { get; set; }


    }



    public class ProductoVendido
    {
        public int Id;// { get; set; }
        public int IdProducto;// { get; set; } 
        public double Stock;// { get; set; }
        public int IdVenta;// { get; set; }

    }
    public class Venta
    {
        public int Id;// { get; set; }
        public string Descripcion;// { get; set; }

    }
}


