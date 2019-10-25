﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeRepuestosv2.Modelos
{
    class Persona
    {
        public string ID { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string FechaNac { get; set; }
        public char Sexo { get; set; }
        public char EstadoCivil { get; set; }
    }
}
