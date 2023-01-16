using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        public int Id {get; set;}
        public string NombreUsuario {get; set;}
        public string Contraseña {get; set;}
        public string ApellidoNombre {get; set;}
        public int Rol { get; set; }

        public Usuario() { 
        
        }

        public Usuario(int id, string nombreUsuario, string contraseña, string apellido, int rol)
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            ApellidoNombre = apellido;
            Rol = rol;
                
        }
    }
}
