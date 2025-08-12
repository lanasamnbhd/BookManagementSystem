namespace KitapMagazasiOtomasyonu1
{
    partial class Form1 :Form
    {
        /// <summary>
        ///  required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 24);
            label1.Name = "label1";
            label1.Size = new Size(283, 27);
            label1.TabIndex = 0;
            label1.Text = "Kitap Mağazası Otomasyonu";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bookshop1;
            pictureBox1.Location = new Point(183, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(569, 140);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(31, 352);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(845, 14);
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(31, 328);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 3;
            label2.Text = "loading...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(108, 328);
            label3.Name = "label3";
            label3.Size = new Size(23, 21);
            label3.TabIndex = 4;
            label3.Text = "%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 378);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private Label label2;
        private Label label3;
    }
}

