namespace PIM_3º_SEMESTRE
{
    partial class frm_Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Feedback));
            button1 = new Button();
            lblId1 = new Label();
            lblId2 = new Label();
            picId1 = new PictureBox();
            picId2 = new PictureBox();
            lblNome = new Label();
            lblAgradecimento = new Label();
            lblInfo = new Label();
            pictureBox1 = new PictureBox();
            lblId3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picId1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picId2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(916, 563);
            button1.Name = "button1";
            button1.Size = new Size(154, 36);
            button1.TabIndex = 1;
            button1.Text = "VOLTAR ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblId1
            // 
            lblId1.AutoSize = true;
            lblId1.BackColor = Color.Transparent;
            lblId1.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblId1.ForeColor = Color.White;
            lblId1.Location = new Point(56, 427);
            lblId1.MaximumSize = new Size(229, 100);
            lblId1.Name = "lblId1";
            lblId1.Size = new Size(60, 20);
            lblId1.TabIndex = 2;
            lblId1.Text = "label1";
            lblId1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblId2
            // 
            lblId2.AutoSize = true;
            lblId2.BackColor = Color.Transparent;
            lblId2.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblId2.ForeColor = Color.White;
            lblId2.Location = new Point(451, 427);
            lblId2.MaximumSize = new Size(229, 100);
            lblId2.Name = "lblId2";
            lblId2.Size = new Size(60, 20);
            lblId2.TabIndex = 3;
            lblId2.Text = "label2";
            lblId2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picId1
            // 
            picId1.ImageLocation = "C:\\Users\\mvc11\\OneDrive\\Área de Trabalho\\PIM 3º SEMESTRE\\SOFTWARE\\PIM 3º SEMESTRE\\PIM 3º SEMESTRE\\Images\\id5.png";
            picId1.Location = new Point(56, 128);
            picId1.Name = "picId1";
            picId1.Size = new Size(229, 278);
            picId1.SizeMode = PictureBoxSizeMode.StretchImage;
            picId1.TabIndex = 5;
            picId1.TabStop = false;
            // 
            // picId2
            // 
            picId2.ImageLocation = "C:\\Users\\mvc11\\OneDrive\\Área de Trabalho\\PIM 3º SEMESTRE\\SOFTWARE\\PIM 3º SEMESTRE\\PIM 3º SEMESTRE\\Images\\id5.png";
            picId2.Location = new Point(451, 128);
            picId2.Name = "picId2";
            picId2.Size = new Size(229, 278);
            picId2.SizeMode = PictureBoxSizeMode.StretchImage;
            picId2.TabIndex = 6;
            picId2.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(106, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(903, 43);
            lblNome.TabIndex = 8;
            lblNome.Text = "Ola Marcos! esse foi seu Feedback para as obras \r\n";
            lblNome.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAgradecimento
            // 
            lblAgradecimento.AutoSize = true;
            lblAgradecimento.BackColor = Color.Transparent;
            lblAgradecimento.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAgradecimento.ForeColor = Color.White;
            lblAgradecimento.Location = new Point(63, 563);
            lblAgradecimento.Name = "lblAgradecimento";
            lblAgradecimento.Size = new Size(586, 68);
            lblAgradecimento.TabIndex = 9;
            lblAgradecimento.Text = "Obrigado por participar! Volte sempre.\r\n\r\n";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(451, 52);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(169, 20);
            lblInfo.TabIndex = 10;
            lblInfo.Text = "Em uma escala de 0 a 5!";
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "C:\\Users\\mvc11\\OneDrive\\Área de Trabalho\\PIM 3º SEMESTRE\\SOFTWARE\\PIM 3º SEMESTRE\\PIM 3º SEMESTRE\\Images\\id5.png";
            pictureBox1.Location = new Point(816, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblId3
            // 
            lblId3.AutoSize = true;
            lblId3.BackColor = Color.Transparent;
            lblId3.Font = new Font("Arial Rounded MT Bold", 10.2F);
            lblId3.ForeColor = Color.White;
            lblId3.Location = new Point(816, 427);
            lblId3.MaximumSize = new Size(229, 100);
            lblId3.Name = "lblId3";
            lblId3.Size = new Size(60, 20);
            lblId3.TabIndex = 14;
            lblId3.Text = "label3";
            lblId3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frm_Feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 653);
            Controls.Add(lblId3);
            Controls.Add(pictureBox1);
            Controls.Add(lblInfo);
            Controls.Add(lblAgradecimento);
            Controls.Add(lblNome);
            Controls.Add(picId2);
            Controls.Add(picId1);
            Controls.Add(lblId2);
            Controls.Add(lblId1);
            Controls.Add(button1);
            MaximumSize = new Size(1100, 700);
            Name = "frm_Feedback";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Feedback";
            Load += frm_Feedback_Load;
            ((System.ComponentModel.ISupportInitialize)picId1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picId2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label lblId1;
        private Label lblId2;
        private PictureBox picId1;
        private PictureBox picId2;
        private Label lblAgradecimento;
        private Label lblInfo;
        private Label lblNome;
        private PictureBox pictureBox1;
        private Label lblId3;
    }
}