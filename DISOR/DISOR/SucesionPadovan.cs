using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISOR
{
    class SucesionPadovan : IOperador
    {
        private int terminoAnterior;
        private int terminoAnteriorAnterior;
        private int terminoActual;
        private int terminoSiguiente;
        private int valor;
        private int numeroVecesActualizado;

        public SucesionPadovan()
        {
            this.terminoAnterior = 1;
            this.terminoAnteriorAnterior = 1;
            this.terminoActual = 1;
            this.terminoSiguiente = 1;
            this.numeroVecesActualizado = 1;
            this.valor = 0;
        }

        public int Valor
        {
            get
            {
                return this.valor;
            }
        }

        public int pad(int n)
        {
            for (int i = 3; i <= n; i++)
            {
                this.terminoSiguiente = this.terminoAnteriorAnterior + this.terminoAnterior;
                this.terminoAnteriorAnterior = this.terminoAnterior;
                this.terminoAnterior = this.terminoActual;
                this.terminoActual = this.terminoSiguiente;
            }

            return this.terminoSiguiente;
        }

        public void Avanzar()
        {
            if (this.numeroVecesActualizado > 3)
            {
                this.terminoSiguiente = this.terminoAnteriorAnterior + this.terminoAnterior;
                this.terminoAnteriorAnterior = this.terminoAnterior;
                this.terminoAnterior = this.terminoActual;
                this.terminoActual = this.terminoSiguiente;
            }
            this.valor = this.terminoActual;
            this.numeroVecesActualizado += 1;
        }

        public void Retroceder()
        {
            if (this.numeroVecesActualizado > 3)
            {

                this.terminoAnteriorAnterior = this.terminoActual - this.terminoAnteriorAnterior;
                this.terminoActual = this.terminoAnterior;
                this.terminoAnterior = this.terminoAnteriorAnterior;
                this.terminoSiguiente = this.terminoActual;
            }
            this.valor = this.terminoActual;
            this.numeroVecesActualizado -= 1;
        }
    }
}
