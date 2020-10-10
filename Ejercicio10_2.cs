using System;

namespace Ejer.Cap10_Y_12
{
    class Estudiantes
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int OrdenL { get; set; }
        public String Telefono { get; set; }
        public String Celular { get; set; }
        public String Direccion { get; set; }

        public Estudiantes()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            OrdenL = 0;
            Telefono = string.Empty;
            Celular = string.Empty;
            Direccion = string.Empty;
        }

    }
}