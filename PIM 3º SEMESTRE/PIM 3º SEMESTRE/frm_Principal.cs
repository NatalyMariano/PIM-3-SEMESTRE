using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using PIM_3º_SEMESTRE.Model_fmr_Principal;

namespace PIM_3º_SEMESTRE
{
    public partial class frm_Principal : Form
    {
        private ExibirObras exibirObras;
        string nomeLocal;
        public frm_Principal(string nome)
        {
            InitializeComponent();
            nomeLocal = nome;
            exibirObras = new ExibirObras(this, btnProximo, btnFinalizar);
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            exibirObras.btnProximo_Click(sender, e);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            exibirObras.btnFinalizar_Click(sender, e, nomeLocal);
        }

        private void txtPergunta1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}