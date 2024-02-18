using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_herencia
{
    public class suma : Operacion
    {
        public int operar()
        {
            Resultado = Valor1 + Valor2;
            return Resultado;
        }
    }
}