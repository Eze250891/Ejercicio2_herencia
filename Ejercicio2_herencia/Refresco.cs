using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_herencia
{
    public class Refresco: Bebida
    {
        public string Sabor { get; set; }
        public string Marca { get; set; }

        public string GaseosaDestapada()
        {
            return "La gaseosa esta destapada, tomala que se le va el gas";
        }
    }
}
