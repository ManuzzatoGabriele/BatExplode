using System.Windows.Forms;

namespace BatExplode___Falcari___Manuzzato
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_PlayIniziale = new PictureBox();
            btn_OptionsIniziale = new PictureBox();
            btn_CreditsIniziale = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)btn_PlayIniziale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_OptionsIniziale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_CreditsIniziale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_PlayIniziale
            // 
            btn_PlayIniziale.BackgroundImageLayout = ImageLayout.Zoom;
            btn_PlayIniziale.Image = (Image)resources.GetObject("btn_PlayIniziale.Image");
            btn_PlayIniziale.Location = new Point(25, 168);
            btn_PlayIniziale.Margin = new Padding(3, 4, 3, 4);
            btn_PlayIniziale.Name = "btn_PlayIniziale";
            btn_PlayIniziale.Size = new Size(229, 107);
            btn_PlayIniziale.SizeMode = PictureBoxSizeMode.Zoom;
            btn_PlayIniziale.TabIndex = 1;
            btn_PlayIniziale.TabStop = false;
            btn_PlayIniziale.Click += btn_PlayIniziale_Click;
            // 
            // btn_OptionsIniziale
            // 
            btn_OptionsIniziale.Image = (Image)resources.GetObject("btn_OptionsIniziale.Image");
            btn_OptionsIniziale.Location = new Point(25, 283);
            btn_OptionsIniziale.Margin = new Padding(3, 4, 3, 4);
            btn_OptionsIniziale.Name = "btn_OptionsIniziale";
            btn_OptionsIniziale.Size = new Size(229, 107);
            btn_OptionsIniziale.SizeMode = PictureBoxSizeMode.CenterImage;
            btn_OptionsIniziale.TabIndex = 2;
            btn_OptionsIniziale.TabStop = false;
            // 
            // btn_CreditsIniziale
            // 
            btn_CreditsIniziale.Image = (Image)resources.GetObject("btn_CreditsIniziale.Image");
            btn_CreditsIniziale.Location = new Point(25, 398);
            btn_CreditsIniziale.Margin = new Padding(3, 4, 3, 4);
            btn_CreditsIniziale.Name = "btn_CreditsIniziale";
            btn_CreditsIniziale.Size = new Size(229, 107);
            btn_CreditsIniziale.SizeMode = PictureBoxSizeMode.CenterImage;
            btn_CreditsIniziale.TabIndex = 3;
            btn_CreditsIniziale.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(332, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(1340, 1116);
            panel1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 40);
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_CreditsIniziale);
            Controls.Add(btn_OptionsIniziale);
            Controls.Add(btn_PlayIniziale);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BAT Explode 💣";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)btn_PlayIniziale).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_OptionsIniziale).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_CreditsIniziale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox btn_PlayIniziale;
        private PictureBox btn_OptionsIniziale;
        private PictureBox btn_CreditsIniziale;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}