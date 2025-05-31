namespace BatExplode___Falcari___Manuzzato
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            lbl_Result = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lbl_Result
            // 
            lbl_Result.AutoSize = true;
            lbl_Result.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Result.ForeColor = Color.Gold;
            lbl_Result.Location = new Point(154, 129);
            lbl_Result.Name = "lbl_Result";
            lbl_Result.Size = new Size(124, 38);
            lbl_Result.TabIndex = 1;
            lbl_Result.Text = "Settings";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(232, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(67, 210);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 125);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(3, 44);
            label1.Name = "label1";
            label1.Size = new Size(170, 32);
            label1.TabIndex = 4;
            label1.Text = "Sound Effects";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(64, 374);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 125);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 4;
            label2.Text = "Game Mode";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(232, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(126, 538);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(180, 114);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 40);
            ClientSize = new Size(432, 664);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbl_Result);
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Result;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}