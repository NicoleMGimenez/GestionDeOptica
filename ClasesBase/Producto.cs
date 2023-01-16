using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Producto
    {
       public string Codigo { get; set; }
       public string Categoria { get; set; }
       public string Descripcion { get; set; }
       public decimal Precio { get; set; }

       public Producto() { 
       }
    }

}
