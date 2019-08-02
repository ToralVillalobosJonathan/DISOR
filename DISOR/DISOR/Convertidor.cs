using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISOR
{
    class Convertidor
    {
        public Convertidor()
        {
        }

        public string Decimal(IOperador objeto)
        {
            return Convert.ToString(objeto.Valor, 10);
        }

        public string Binario(IOperador objeto)
        {
            return Convert.ToString(objeto.Valor, 2);
        }

        public string Hexadecimal(IOperador objeto)
        {
            return Convert.ToString(objeto.Valor, 16);
        }

        public bool Capicua(IOperador objeto)
        {
            if (objeto.Valor == _Capicua(objeto.Valor, 0)) return true;
            return false;
        }

        private int _Capicua(int valor, int temp)
        {
            // base case 
            if (valor == 0)
                return temp;

            temp = (temp * 10) + (valor % 10);

            return _Capicua(valor / 10, temp);
        } 
    }
}
