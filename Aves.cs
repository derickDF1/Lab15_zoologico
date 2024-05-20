using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15_zoologico
{
    public class Aves : Animal
    {
        public bool Vuela { get; set; }
        public string PeriodoIncubacion {get; set;}

        public Aves()
        {
            Vuela = false;
            PeriodoIncubacion = string.Empty;
        }
    }
}
