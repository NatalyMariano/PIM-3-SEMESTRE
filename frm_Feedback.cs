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

        
        public frm_Feedback()
        {
            InitializeComponent();

            
        }
        private void frm_Feedback_Load(object sender, EventArgs e)
        {
            ExibirFeedbacks();
            List<(int id, int media)> feedbacks = ListaDeFeedback.Instance.FeedbackList;

            // Agrupe os feedbacks por ID
            var feedbacksPorID = feedbacks.GroupBy(f => f.id);

            // Construa uma string para armazenar o conteúdo da lista de médias gerais
            StringBuilder listaConteudo = new StringBuilder();

            // Itere sobre cada grupo de feedbacks
            foreach (var grupo in feedbacksPorID)
            {
                // Calcule a média das médias para o grupo atual
                double mediaGeral = grupo.Select(f => f.media).Average();

                // Adicione o ID e a média geral à string de conteúdo
                listaConteudo.AppendLine($"ID: {grupo.Key}, Média Geral: {mediaGeral:F2}");
            }

            // Exiba a string de conteúdo em uma MessageBox
            MessageBox.Show(listaConteudo.ToString(), "Média das Médias por ID");
        }
        private void ExibirFeedbacks()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            telaPrincipal = new Thread(abrirTelaPrincipal);
            telaPrincipal.SetApartmentState(ApartmentState.STA);
            telaPrincipal.Start();
        }

        private void abrirTelaPrincipal(object obj)
        {
            Application.Run(new frm_Principal());
        }

       
    }
}

