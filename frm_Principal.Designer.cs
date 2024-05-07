namespace PIM_3º_SEMESTRE
{
    partial class frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProximo = new Button();
            btnFinalizar = new Button();
            lblNome = new Label();
            lblDescricao = new Label();
            picImagem = new PictureBox();
            lblPergunta1 = new Label();
            lblPergunta2 = new Label();
            lblPergunta3 = new Label();
            txtPergunta1 = new TextBox();
            txtPergunta2 = new TextBox();
            txtPergunta3 = new TextBox();
            lblMensagem = new Label();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            SuspendLayout();
            // 
            // btnProximo
            // 
            btnProximo.Location = new Point(737, 589);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(193, 36);
            btnProximo.TabIndex = 0;
            btnProximo.Text = "AVANÇAR";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(737, 589);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(193, 36);
            btnFinalizar.TabIndex = 1;
            btnFinalizar.Text = "FINALIZAR";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(416, -1);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(130, 43);
            lblNome.TabIndex = 2;
            lblNome.Text = "TITULO";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.BackColor = Color.LightSlateGray;
            lblDescricao.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(362, 38);
            lblDescricao.MaximumSize = new Size(550, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(109, 24);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "DESCRIÇAO";
            lblDescricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picImagem
            // 
            picImagem.Location = new Point(31, 38);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(325, 287);
            picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagem.TabIndex = 4;
            picImagem.TabStop = false;
            // 
            // lblPergunta1
            // 
            lblPergunta1.AutoSize = true;
            lblPergunta1.Font = new Font("Arial Narrow", 12F);
            lblPergunta1.Location = new Point(31, 384);
            lblPergunta1.MaximumSize = new Size(500, 0);
            lblPergunta1.Name = "lblPergunta1";
            lblPergunta1.Size = new Size(52, 24);
            lblPergunta1.TabIndex = 5;
            lblPergunta1.Text = "label3";
            // 
            // lblPergunta2
            // 
            lblPergunta2.AutoSize = true;
            lblPergunta2.Font = new Font("Arial Narrow", 12F);
            lblPergunta2.Location = new Point(31, 458);
            lblPergunta2.MaximumSize = new Size(500, 0);
            lblPergunta2.Name = "lblPergunta2";
            lblPergunta2.Size = new Size(52, 24);
            lblPergunta2.TabIndex = 6;
            lblPergunta2.Text = "label4";
            // 
            // lblPergunta3
            // 
            lblPergunta3.AutoSize = true;
            lblPergunta3.Font = new Font("Arial Narrow", 12F);
            lblPergunta3.Location = new Point(31, 539);
            lblPergunta3.MaximumSize = new Size(500, 0);
            lblPergunta3.Name = "lblPergunta3";
            lblPergunta3.Size = new Size(52, 24);
            lblPergunta3.TabIndex = 7;
            lblPergunta3.Text = "label5";
            // 
            // txtPergunta1
            // 
            txtPergunta1.BackColor = Color.LightSteelBlue;
            txtPergunta1.BorderStyle = BorderStyle.FixedSingle;
            txtPergunta1.Location = new Point(31, 430);
            txtPergunta1.Name = "txtPergunta1";
            txtPergunta1.Size = new Size(52, 27);
            txtPergunta1.TabIndex = 8;
            // 
            // txtPergunta2
            // 
            txtPergunta2.BackColor = Color.LightSteelBlue;
            txtPergunta2.BorderStyle = BorderStyle.FixedSingle;
            txtPergunta2.Location = new Point(31, 509);
            txtPergunta2.Name = "txtPergunta2";
            txtPergunta2.Size = new Size(52, 27);
            txtPergunta2.TabIndex = 9;
            // 
            // txtPergunta3
            // 
            txtPergunta3.BackColor = Color.LightSteelBlue;
            txtPergunta3.BorderStyle = BorderStyle.FixedSingle;
            txtPergunta3.Location = new Point(31, 586);
            txtPergunta3.Name = "txtPergunta3";
            txtPergunta3.Size = new Size(52, 27);
            txtPergunta3.TabIndex = 10;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.BackColor = Color.Transparent;
            lblMensagem.Cursor = Cursors.IBeam;
            lblMensagem.ForeColor = Color.Red;
            lblMensagem.Location = new Point(460, 605);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 20);
            lblMensagem.TabIndex = 11;
            // 
            // frm_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(942, 653);
            Controls.Add(lblMensagem);
            Controls.Add(txtPergunta3);
            Controls.Add(txtPergunta2);
            Controls.Add(txtPergunta1);
            Controls.Add(lblPergunta3);
            Controls.Add(lblPergunta2);
            Controls.Add(lblPergunta1);
            Controls.Add(picImagem);
            Controls.Add(lblDescricao);
            Controls.Add(lblNome);
            Controls.Add(btnFinalizar);
            Controls.Add(btnProximo);
            MaximumSize = new Size(960, 700);
            MinimumSize = new Size(960, 700);
            Name = "frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Principal";
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProximo;
        private Button btnFinalizar;
        private Label lblNome;
        private Label lblDescricao;
        private PictureBox picImagem;
        private Label lblPergunta1;
        private Label lblPergunta2;
        private Label lblPergunta3;
        private TextBox txtPergunta1;
        private TextBox txtPergunta2;
        private TextBox txtPergunta3;
        private Label lblMensagem;
    }
}