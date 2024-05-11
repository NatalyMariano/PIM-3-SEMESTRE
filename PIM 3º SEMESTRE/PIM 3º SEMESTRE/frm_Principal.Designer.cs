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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
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
            label1 = new Label();
            txtPergunta4 = new TextBox();
            txtPergunta5 = new TextBox();
            lblPergunta4 = new Label();
            lblPergunta5 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            SuspendLayout();
            // 
            // btnProximo
            // 
            btnProximo.Location = new Point(853, 589);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(193, 36);
            btnProximo.TabIndex = 0;
            btnProximo.Text = "AVANÇAR";
            btnProximo.UseVisualStyleBackColor = true;
            btnProximo.Click += btnProximo_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(853, 589);
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
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(362, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(130, 43);
            lblNome.TabIndex = 2;
            lblNome.Text = "TITULO";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Arial Rounded MT Bold", 7.8F);
            lblDescricao.ForeColor = Color.White;
            lblDescricao.Location = new Point(31, 375);
            lblDescricao.MaximumSize = new Size(650, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(589, 225);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = resources.GetString("lblDescricao.Text");
            lblDescricao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picImagem
            // 
            picImagem.Location = new Point(31, 9);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(325, 336);
            picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagem.TabIndex = 4;
            picImagem.TabStop = false;
            // 
            // lblPergunta1
            // 
            lblPergunta1.AutoSize = true;
            lblPergunta1.BackColor = Color.Transparent;
            lblPergunta1.Font = new Font("Arial Rounded MT Bold", 7.8F);
            lblPergunta1.ForeColor = Color.White;
            lblPergunta1.Location = new Point(837, 87);
            lblPergunta1.MaximumSize = new Size(600, 0);
            lblPergunta1.Name = "lblPergunta1";
            lblPergunta1.Size = new Size(169, 30);
            lblPergunta1.TabIndex = 5;
            lblPergunta1.Text = "esta é uma perginta com \r\nseu tamnho pre defindo?";
            // 
            // lblPergunta2
            // 
            lblPergunta2.AutoSize = true;
            lblPergunta2.BackColor = Color.Transparent;
            lblPergunta2.Font = new Font("Arial Rounded MT Bold", 7.8F);
            lblPergunta2.ForeColor = Color.White;
            lblPergunta2.Location = new Point(837, 166);
            lblPergunta2.MaximumSize = new Size(600, 0);
            lblPergunta2.Name = "lblPergunta2";
            lblPergunta2.Size = new Size(169, 30);
            lblPergunta2.TabIndex = 6;
            lblPergunta2.Text = "esta é uma perginta com \r\nseu tamnho pre defindo?";
            // 
            // lblPergunta3
            // 
            lblPergunta3.AutoSize = true;
            lblPergunta3.BackColor = Color.Transparent;
            lblPergunta3.Font = new Font("Arial Rounded MT Bold", 7.8F);
            lblPergunta3.ForeColor = Color.White;
            lblPergunta3.Location = new Point(837, 247);
            lblPergunta3.MaximumSize = new Size(600, 0);
            lblPergunta3.Name = "lblPergunta3";
            lblPergunta3.Size = new Size(169, 30);
            lblPergunta3.TabIndex = 7;
            lblPergunta3.Text = "esta é uma perginta com \r\nseu tamnho pre defindo?";
            // 
            // txtPergunta1
            // 
            txtPergunta1.BackColor = Color.White;
            txtPergunta1.BorderStyle = BorderStyle.FixedSingle;
            txtPergunta1.Location = new Point(843, 120);
            txtPergunta1.MaxLength = 1;
            txtPergunta1.Name = "txtPergunta1";
            txtPergunta1.Size = new Size(150, 27);
            txtPergunta1.TabIndex = 8;
            txtPergunta1.TextChanged += txtPergunta1_TextChanged;
            // 
            // txtPergunta2
            // 
            txtPergunta2.BackColor = Color.White;
            txtPergunta2.BorderStyle = BorderStyle.FixedSingle;
            txtPergunta2.Location = new Point(843, 199);
            txtPergunta2.MaxLength = 1;
            txtPergunta2.Name = "txtPergunta2";
            txtPergunta2.Size = new Size(150, 27);
            txtPergunta2.TabIndex = 9;
            // 
            // txtPergunta3
            // 
            txtPergunta3.BackColor = Color.White;
            txtPergunta3.BorderStyle = BorderStyle.FixedSingle;
            txtPergunta3.Location = new Point(843, 280);
            txtPergunta3.MaxLength = 1;
            txtPergunta3.Name = "txtPergunta3";
            txtPergunta3.Size = new Size(150, 27);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(758, 9);
            label1.Name = "label1";
            label1.Size = new Size(312, 27);
            label1.TabIndex = 12;
            label1.Text = "Questionário de satisfação";
            // 
            // txtPergunta4
            // 
            txtPergunta4.BackColor = Color.White;
            txtPergunta4.BorderStyle = BorderStyle.FixedSingle;
            txtPergunta4.Location = new Point(843, 364);
            txtPergunta4.MaxLength = 1;
            txtPergunta4.Name = "txtPergunta4";
            txtPergunta4.Size = new Size(150, 27);
            txtPergunta4.TabIndex = 13;
            // 
            // txtPergunta5
            // 
            txtPergunta5.BackColor = Color.White;
            txtPergunta5.BorderStyle = BorderStyle.FixedSingle;
            txtPergunta5.Location = new Point(843, 446);
            txtPergunta5.MaxLength = 1;
            txtPergunta5.Name = "txtPergunta5";
            txtPergunta5.Size = new Size(150, 27);
            txtPergunta5.TabIndex = 14;
            // 
            // lblPergunta4
            // 
            lblPergunta4.AutoSize = true;
            lblPergunta4.BackColor = Color.Transparent;
            lblPergunta4.Font = new Font("Arial Rounded MT Bold", 7.8F);
            lblPergunta4.ForeColor = Color.White;
            lblPergunta4.Location = new Point(837, 331);
            lblPergunta4.MaximumSize = new Size(600, 0);
            lblPergunta4.Name = "lblPergunta4";
            lblPergunta4.Size = new Size(169, 30);
            lblPergunta4.TabIndex = 15;
            lblPergunta4.Text = "esta é uma perginta com \r\nseu tamnho pre defindo?";
            // 
            // lblPergunta5
            // 
            lblPergunta5.AutoSize = true;
            lblPergunta5.BackColor = Color.Transparent;
            lblPergunta5.Font = new Font("Arial Rounded MT Bold", 7.8F);
            lblPergunta5.ForeColor = Color.White;
            lblPergunta5.Location = new Point(837, 413);
            lblPergunta5.MaximumSize = new Size(600, 0);
            lblPergunta5.Name = "lblPergunta5";
            lblPergunta5.Size = new Size(169, 30);
            lblPergunta5.TabIndex = 16;
            lblPergunta5.Text = "esta é uma perginta com \r\nseu tamnho pre defindo?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(771, 51);
            label2.MaximumSize = new Size(600, 0);
            label2.Name = "label2";
            label2.Size = new Size(262, 17);
            label2.TabIndex = 17;
            label2.Text = "Em uma escala de 0 a 5, responda:";
            // 
            // frm_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1082, 653);
            Controls.Add(label2);
            Controls.Add(lblPergunta5);
            Controls.Add(lblPergunta4);
            Controls.Add(txtPergunta5);
            Controls.Add(txtPergunta4);
            Controls.Add(label1);
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
            MaximumSize = new Size(1100, 700);
            MinimumSize = new Size(1100, 700);
            Name = "frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
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
        private Label label1;
        private TextBox txtPergunta4;
        private TextBox txtPergunta5;
        private Label lblPergunta4;
        private Label lblPergunta5;
        private Label label2;
    }
}