using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_herencia
{
    public class Cerveza : Bebida
    {
        //Atributos
        public int Grado { get; set; }
        public int Amargor { get; set; }

        //Metodos
        public string EstaSerida()
        {
            return "La cervaza ya esta servida, apurate que se calienta y parece un meo";
        }
    }
}
