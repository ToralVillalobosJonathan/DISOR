using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISOR
{
    interface IOperador
    {
        int Valor
        {
            get;
        }
        void Avanzar();
        void Retroceder();
    }
}
