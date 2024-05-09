namespace KitapMagazasiOtomasyonu1
{
    partial class SistemeGiris
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 318);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(296, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 318);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(281, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(426, 318);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 27);
            label1.TabIndex = 1;
            label1.Text = "Kitap Mağazası ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bookshopIcon;
            pictureBox1.Location = new Point(138, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 31);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(71, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(106, 31);
            textBox3.TabIndex = 5;
            textBox3.Text = "kullanıcı adı:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(71, 195);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(106, 31);
            textBox4.TabIndex = 6;
            textBox4.Text = "şifre:";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Location = new Point(148, 232);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "giriş yap";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 279);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 8;
            label2.Text = "admin";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 124);
            label3.Name = "label3";
            label3.Size = new Size(248, 25);
            label3.TabIndex = 2;
            label3.Text = "yardımsever personel burda!!!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 149);
            label4.Name = "label4";
            label4.Size = new Size(199, 25);
            label4.TabIndex = 3;
            label4.Text = "aradığınız kitap burda!!!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 174);
            label5.Name = "label5";
            label5.Size = new Size(203, 25);
            label5.TabIndex = 4;
            label5.Text = "her türlü hizmet burda!!!";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(403, 0);
            label6.Name = "label6";
            label6.Size = new Size(20, 25);
            label6.TabIndex = 9;
            label6.Text = "x";
            label6.Click += label6_Click;
            // 
            // SistemeGiris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(719, 362);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SistemeGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SistemeGiris";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox4;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
    }
}