using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controles
{
    class Persona
    {
        public string Nombre { get; set; }
        public DateTime Edad { get; set; }
        public string FechaNacimiento { get; set; }
        public string ColorFavorito { get; set; }
        public string Tipo { get; set; }
        public string Chocolate { get; set; }

        //metodo
        public string saludar()
        {
            return "Hola " + Nombre;
        }
    }
    
}
