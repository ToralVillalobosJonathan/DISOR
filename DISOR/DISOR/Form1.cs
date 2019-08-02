using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISOR
{
    public partial class Form1 : Form
    {
        NumeroFibonacci nf = new NumeroFibonacci();
        SucesionPadovan sp = new SucesionPadovan();

        Convertidor co = new Convertidor();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            nf.Avanzar();
            textFibonacci.Text = Convert.ToString(nf.Valor);
            textBinario.Text = co.Binario(nf);
            textHexadecimal.Text = co.Hexadecimal(nf);
            textDecimal.Text = co.Decimal(nf);
        }

        private void btnPadovan_Click(object sender, EventArgs e)
        {
            sp.Avanzar();
            textPadovan.Text = Convert.ToString(sp.Valor);
            textBinario.Text = co.Binario(sp);
            textHexadecimal.Text = co.Hexadecimal(sp);
            textDecimal.Text = co.Decimal(sp);
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            
            nf.Retroceder();
            textFibonacci.Text = Convert.ToString(nf.Valor);
            textBinario.Text = co.Binario(nf);
            textHexadecimal.Text = co.Hexadecimal(nf);
            textDecimal.Text = co.Decimal(nf);
            
            sp.Retroceder();
            textPadovan.Text = Convert.ToString(sp.Valor);
            textBinario.Text = co.Binario(sp);
            textHexadecimal.Text = co.Hexadecimal(sp);
            textDecimal.Text = co.Decimal(sp);

        }
    }
}
