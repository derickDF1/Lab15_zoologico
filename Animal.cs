using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15_zoologico
{
    public class Animal
    {
        public string NombrePropio { get; set; }
        public string Especie { get; set; }
        public string TipoAlimentacion { get; set; }
        public string TiempoMaxVida { get; set; }

        public Animal()
        {
            NombrePropio = string.Empty;
            Especie = string.Empty;
            TipoAlimentacion = string.Empty;
            TiempoMaxVida = string.Empty;
        }
    }
}
