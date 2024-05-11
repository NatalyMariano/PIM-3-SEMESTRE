using PIM_3º_SEMESTRE.Model_fmr_Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_3º_SEMESTRE
{
    public partial class frm_Home : Form
    {
        ValidaNome validar = new ValidaNome();
        string nomeValidado;
        public frm_Home()
        {
            InitializeComponent();

            List<(int id, int media)> feedbacks = ListaDeFeedback.Instance.FeedbackList;

            var feedbacksPorID = feedbacks.GroupBy(f => f.id);

            foreach (var grupo in feedbacksPorID)
            {
                double mediaGeral = grupo.Select(f => f.media).Average();

                string nomeLabel = $"lblId{grupo.Key}";
                Label? label = Controls.Find(nomeLabel, true).FirstOrDefault() as Label;
                label.Text = $"O Feedback atual é de: {mediaGeral:F2}";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string validacao = validar.validaNome(txtNome.Text);

            if (validacao.Equals(""))
            {
                nomeValidado = txtNome.Text;

                this.Close();
                Thread telaObra = new Thread(() => abrirTelaObras(nomeValidado));
                telaObra.SetApartmentState(ApartmentState.STA);
                telaObra.Start();
            }
            else
            {
                lblResposta.Text = "Nome invalido! Tente novamente.";
            }
        }
        private static void abrirTelaObras(string nome)
        {
            Application.Run(new frm_Principal(nome));
        }
    }
}
