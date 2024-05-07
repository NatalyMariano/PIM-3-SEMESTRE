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
            button1 = new Button();
            lblId1 = new Label();
            lblId2 = new Label();
            lblId3 = new Label();
            picId1 = new PictureBox();
            picId2 = new PictureBox();
            picId3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picId1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picId2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picId3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(816, 565);
            button1.Name = "button1";
            button1.Size = new Size(114, 76);
            button1.TabIndex = 1;
            button1.Text = "TELA PRINCIAL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblId1
            // 
            lblId1.AutoSize = true;
            lblId1.Location = new Point(134, 223);
            lblId1.Name = "lblId1";
            lblId1.Size = new Size(50, 20);
            lblId1.TabIndex = 2;
            lblId1.Text = "label1";
            // 
            // lblId2
            // 
            lblId2.AutoSize = true;
            lblId2.Location = new Point(433, 223);
            lblId2.Name = "lblId2";
            lblId2.Size = new Size(50, 20);
            lblId2.TabIndex = 3;
            lblId2.Text = "label2";
            // 
            // lblId3
            // 
            lblId3.AutoSize = true;
            lblId3.Location = new Point(739, 233);
            lblId3.Name = "lblId3";
            lblId3.Size = new Size(50, 20);
            lblId3.TabIndex = 4;
            lblId3.Text = "label3";
            // 
            // picId1
            // 
            picId1.Location = new Point(95, 146);
            picId1.Name = "picId1";
            picId1.Size = new Size(125, 62);
            picId1.TabIndex = 5;
            picId1.TabStop = false;
            // 
            // picId2
            // 
            picId2.Location = new Point(396, 146);
            picId2.Name = "picId2";
            picId2.Size = new Size(125, 62);
            picId2.TabIndex = 6;
            picId2.TabStop = false;
            // 
            // picId3
            // 
            picId3.Location = new Point(696, 146);
            picId3.Name = "picId3";
            picId3.Size = new Size(125, 62);
            picId3.TabIndex = 7;
            picId3.TabStop = false;
            // 
            // frm_Feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(942, 653);
            Controls.Add(picId3);
            Controls.Add(picId2);
            Controls.Add(picId1);
            Controls.Add(lblId3);
            Controls.Add(lblId2);
            Controls.Add(lblId1);
            Controls.Add(button1);
            MaximumSize = new Size(960, 700);
            Name = "frm_Feedback";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Feedback";
            Load += frm_Feedback_Load;
            ((System.ComponentModel.ISupportInitialize)picId1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picId2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picId3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label lblId1;
        private Label lblId2;
        private Label lblId3;
        private PictureBox picId1;
        private PictureBox picId2;
        private PictureBox picId3;
    }
}