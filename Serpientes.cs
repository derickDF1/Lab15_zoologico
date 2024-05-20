using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15_zoologico
{
    public class Serpientes
    {
        public bool Venenosa { get; set; }
        public string TiempoIncubacion { get; set; }

        public Serpientes()
        {
            Venenosa = false;
            TiempoIncubacion = string.Empty;
        }
    }
}
