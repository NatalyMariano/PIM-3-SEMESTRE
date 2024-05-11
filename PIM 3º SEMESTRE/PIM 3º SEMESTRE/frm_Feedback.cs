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

namespace PIM_3º_SEMESTRE
{
    public partial class frm_Feedback : Form
    {
        Thread telaPrincipal;
        string nomeLocal;
        List<(int id, int media)> feedbacksLocal;

        public frm_Feedback(string nome, List<(int id, int media)> feedbacks)
        {
            InitializeComponent();
            nomeLocal = nome;
            feedbacksLocal = feedbacks;
        }

        private void frm_Feedback_Load(object sender, EventArgs e)
        {
            lblNome.Text ="Ola! "+nomeLocal+ " esse foi seu Feedbacks para as obras";

            foreach (var feedback in feedbacksLocal)
            {
                string nomeLabel = $"lblId{feedback.id}";

                Label label = Controls.Find(nomeLabel, true).FirstOrDefault() as Label;

                label.Text = $"Seu Feedback para esta obra foi de: {feedback.media}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            telaPrincipal = new Thread(abrirTelaPrincipal);
            telaPrincipal.SetApartmentState(ApartmentState.STA);
            telaPrincipal.Start();
        }

        private void abrirTelaPrincipal()
        {
            Application.Run(new frm_Home());
        }
    }
}
