using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    internal class Mascota
    {
        
        public string G11_nombre { get; set; }
        public string G11_edad { get; set; }
        public string G11_raza { get; set; }
        public string G11_dueño { get; set; }

        public Mascota()
        {
        }

        public Mascota(string g11_Nombre, string g11_Edad, string g11_Raza, string g11_Dueño)
        {
            G11_nombre = g11_Nombre;
            G11_edad = g11_Edad;
            G11_raza = g11_Raza;
            G11_dueño = g11_Dueño;
        }

        public string[] getData()
        {
            string[] r_data = new string[4];
            r_data[0] = G11_nombre;
            r_data[1] = G11_edad;
            r_data[2] = G11_raza;
            r_data[3] = G11_dueño;
            return r_data;
        }
    }
}
