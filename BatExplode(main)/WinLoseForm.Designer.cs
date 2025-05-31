namespace BatExplode___Falcari___Manuzzato
{
    partial class WinLoseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinLoseForm));
            lbl_Result = new Label();
            btn_Retry = new PictureBox();
            btn_Settings = new PictureBox();
            btn_Credits = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_Retry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Settings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Credits).BeginInit();
            SuspendLayout();
            // 
            // lbl_Result
            // 
            lbl_Result.AutoSize = true;
            lbl_Result.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Result.ForeColor = Color.Gold;
            lbl_Result.Location = new Point(141, 129);
            lbl_Result.Name = "lbl_Result";
            lbl_Result.Size = new Size(150, 38);
            lbl_Result.TabIndex = 0;
            lbl_Result.Text = "Hai perso!";
            lbl_Result.Click += lbl_Result_Click;
            // 
            // btn_Retry
            // 
            btn_Retry.Image = (Image)resources.GetObject("btn_Retry.Image");
            btn_Retry.Location = new Point(115, 234);
            btn_Retry.Name = "btn_Retry";
            btn_Retry.Size = new Size(203, 83);
            btn_Retry.TabIndex = 1;
            btn_Retry.TabStop = false;
            btn_Retry.Click += btn_Retry_Click;
            // 
            // btn_Settings
            // 
            btn_Settings.Image = (Image)resources.GetObject("btn_Settings.Image");
            btn_Settings.Location = new Point(90, 383);
            btn_Settings.Name = "btn_Settings";
            btn_Settings.Size = new Size(243, 122);
            btn_Settings.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Settings.TabIndex = 2;
            btn_Settings.TabStop = false;
            btn_Settings.Click += btn_Settings_Click;
            // 
            // btn_Credits
            // 
            btn_Credits.Image = (Image)resources.GetObject("btn_Credits.Image");
            btn_Credits.Location = new Point(115, 323);
            btn_Credits.Name = "btn_Credits";
            btn_Credits.Size = new Size(203, 83);
            btn_Credits.TabIndex = 3;
            btn_Credits.TabStop = false;
            // 
            // WinLoseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 40);
            ClientSize = new Size(432, 664);
            Controls.Add(btn_Credits);
            Controls.Add(btn_Settings);
            Controls.Add(btn_Retry);
            Controls.Add(lbl_Result);
            Name = "WinLoseForm";
            Text = "WinLoseForm";
            Load += WinLoseForm_Load;
            ((System.ComponentModel.ISupportInitialize)btn_Retry).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Settings).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Credits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Result;
        private PictureBox btn_Retry;
        private PictureBox btn_Settings;
        private PictureBox btn_Credits;
    }
}