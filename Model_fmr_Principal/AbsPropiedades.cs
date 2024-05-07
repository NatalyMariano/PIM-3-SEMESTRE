using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_3º_SEMESTRE.Model_fmr_Principal
{
    public abstract class AbsPropriedades
    {
        protected Form formulario;
        protected Label lblNome;
        protected Label lblDescricao;
        protected PictureBox picImagem;
        protected Label[] lblPerguntas;
        protected TextBox[] txtRespostas;
        protected Label lblMensagem;

        protected void InicializarElementos(Form formulario)
        {
            this.formulario = formulario;

            lblNome = formulario.Controls.Find("lblNome", true)[0] as Label;
            lblDescricao = formulario.Controls.Find("lblDescricao", true)[0] as Label;
            picImagem = formulario.Controls.Find("picImagem", true)[0] as PictureBox;
            lblMensagem = formulario.Controls.Find("lblMensagem", true)[0] as Label;

            lblPerguntas = new Label[3];
            txtRespostas = new TextBox[3];

            for (int i = 0; i < 3; i++)
            {
                lblPerguntas[i] = formulario.Controls.Find("lblPergunta" + (i + 1), true)[0] as Label;
                txtRespostas[i] = formulario.Controls.Find("txtPergunta" + (i + 1), true)[0] as TextBox;
            }
        }
    
    }
}
