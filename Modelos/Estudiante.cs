﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfvelascoComplementario.Modelos
{
    public class Estudiante
    {
        public int codigo { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public string curso { set; get; }
        public string paralelo { set; get; }

        public int notaFinal { set; get; }
    }
}
