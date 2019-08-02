using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISOR
{
    class NumeroFibonacci : IOperador
    {
        private int terminoAnterior;
        private int terminoAnteriorAnterior;
        private int terminoActual;
        private int numeroVecesActualizado;
        private int valor;

        public NumeroFibonacci()
        {
            this.terminoAnterior = 0;
            this.terminoAnteriorAnterior = 0;
            this.terminoActual = 0;
            this.numeroVecesActualizado = 0;
            this.valor = 0;
        }

        public int Valor
        {
            get
            {
                return this.valor;
            }
        }
    
        public void Avanzar()
        {
            if (this.numeroVecesActualizado == 0)
            {
                this.terminoAnterior = 0;
                this.terminoAnteriorAnterior = 0;
                this.terminoActual = 1;
            }
            if (this.numeroVecesActualizado == 1)
            {
                this.terminoAnterior = 1;
                this.terminoAnteriorAnterior = 0;
                this.terminoActual = 1;
            }
            if (this.numeroVecesActualizado >= 2)
            {
                this.terminoAnteriorAnterior = this.terminoAnterior;
                this.terminoAnterior = this.terminoActual;
                this.terminoActual = this.terminoAnterior + this.terminoAnteriorAnterior;
            }
            this.valor = this.terminoActual;
            this.numeroVecesActualizado += 1;
        }

        public void Retroceder()
        {
            try
            {
                if (this.numeroVecesActualizado > 0)
                {
                    if (this.numeroVecesActualizado == 1)
                    {
                        this.terminoActual = this.terminoAnterior;
                        this.terminoAnterior = 0;
                        this.terminoAnteriorAnterior = -1;
                    }

                    if (this.numeroVecesActualizado >= 2)
                    {
                        int respaldoTerminoActual = this.terminoActual;
                        this.terminoActual = respaldoTerminoActual - this.terminoAnteriorAnterior;
                        this.terminoAnterior = this.terminoAnteriorAnterior;
                        this.terminoAnteriorAnterior = this.terminoActual - this.terminoAnterior;
                    }
                    this.valor = this.terminoActual;
                    this.numeroVecesActualizado -= 1;
                }
                else throw new System.InvalidOperationException();
            }
            catch
            {
                throw new System.InvalidOperationException();
            }

        }


        public void reiniciar()
        {
            this.terminoAnterior = 0;
            this.terminoAnteriorAnterior = 0;
            this.terminoActual = 0;
            this.numeroVecesActualizado = 0;
            this.valor = 0;
        }
    }
}
