using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_estudents.Models
{
    class studentt
    {
        public static List<studentt> StudentsList = new List<studentt>();

        public studentt(string name, string apellido, int edad)
        {
            this.name = name;
            this.apellido = apellido;
            this.edad = edad;
        }

        public string name { get; set; }
        public string apellido { get; set; }
        public int edad{ get; set; }
    }
}
