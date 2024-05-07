using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace PIM_3º_SEMESTRE.Model_fmr_Principal
{
    internal class ExibirObras : AbsPropriedades
    {
        private List<Item> listaDeObras;

        private int currentIndex = 0;

        private Validacao validacao = new Validacao();

        private Button btnProximo;
        private Button btnFinalizar;

        public ExibirObras(Form formulario, Button btnProximo, Button btnFinalizar)
        {
    
            this.btnProximo = btnProximo;
            this.btnFinalizar = btnFinalizar;

            ListaDeObras listaDeObras = new ListaDeObras();
            this.listaDeObras = listaDeObras.CriarListaDeObras();

            InicializarElementos(formulario);
            Exibir(currentIndex);
            AtualizarVisibilidadeBotoes();
        }       

        private void Exibir(int index)
        {
            if (index >= 0 && index < listaDeObras.Count)
            {
                ExibirDadosObra(listaDeObras[index]);
            }
        }

        private void ExibirDadosObra(Item obra)
        {
            lblMensagem.Text = "";
            lblNome.Text = obra.Nome;
            lblDescricao.Text = "Descrição: " + obra.Descricao;   
            picImagem.Image = Image.FromFile($"C:\\Images\\{obra.Imagem}");

            for (int i = 0; i < 3; i++)
            {
                if (i < obra.Perguntas.Count)
                {
                    lblPerguntas[i].Text = obra.Perguntas[i];
                    txtRespostas[i].Text = "";
                    lblPerguntas[i].Visible = true;
                    txtRespostas[i].Visible = true;
                }
                else
                {
                    lblPerguntas[i].Visible = false;
                    txtRespostas[i].Visible = false;
                }
            }
        }

        // abaixo os eventos dos botoes
        private void AtualizarVisibilidadeBotoes()
        {
            btnProximo.Visible = (currentIndex < listaDeObras.Count - 1);
            btnFinalizar.Visible = (currentIndex == listaDeObras.Count - 1);
        }

        public void btnProximo_Click(object sender, EventArgs e)
        {
            if (validacao.ValidarTextBoxes(txtRespostas) == "")
            {
                int obraId = listaDeObras[currentIndex].Id;
                List<int> respostas = txtRespostas.Select(txt => int.Parse(txt.Text)).ToList();
                Salvar(obraId, respostas);

                if (currentIndex < listaDeObras.Count - 1)
                {
                    currentIndex++;
                    Exibir(currentIndex);
                    AtualizarVisibilidadeBotoes();
                }
            }
            else
            {
                 lblMensagem.Text =  validacao.ValidarTextBoxes(txtRespostas);
            }
        }

        public void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (validacao.ValidarTextBoxes(txtRespostas) == "")
            {
                int obraId = listaDeObras[currentIndex].Id;
                List<int> respostas = txtRespostas.Select(txt => int.Parse(txt.Text)).ToList();
                Salvar(obraId, respostas);
               

                formulario.Close();
                Thread telaObra = new Thread(() => abrirTelaObras());
                telaObra.SetApartmentState(ApartmentState.STA);
                telaObra.Start();
        }
            else
            {
                lblMensagem.Text = validacao.ValidarTextBoxes(txtRespostas);
            }
        }
        private static void abrirTelaObras()
        {
            Application.Run(new frm_Feedback());
        }

        private void Salvar(int id, List<int> respostas)
        {

            double media = respostas.Average();
            int mediaInt = Convert.ToInt32(Math.Round(media));

            ListaDeFeedback.Instance.AdicionarFeedback(id, mediaInt);
        }
    }
}