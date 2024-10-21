using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    internal class Dueño
    {
        public string G11_nombre { get; set;}
        public string G11_direccion { get; set;}
        public string G11_telefono { get; set;}
        
        public Dueño()
        {
        }

        public Dueño(string g11_nombre, string g11_direccion, string g11_edad)
        {
            this.G11_nombre = g11_nombre;
            this.G11_direccion = g11_direccion;
            this.G11_telefono = g11_edad;
        }

        public string[] getData()
        {
            string[] r_data = new string[3];
            r_data[0] = G11_nombre;
            r_data[1] = G11_direccion;
            r_data[2] = G11_telefono;
            return r_data;
        }
    }
}
