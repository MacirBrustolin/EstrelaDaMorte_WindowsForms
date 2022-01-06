using System;
using System.Collections.Generic;
using System.Text;

namespace EstrelaDaMorte_WindowsForms.Entidades {
    public class Planeta {
        public int IdPlaneta { get; set; }
        public string Nome { get; set; }
        public double Rotacao { get; set; }
        public double Orbita { get; set; }
        public double Diametro { get; set; }
        public string Clima { get; set; }
        public int Populacao { get; set; }
    }
}