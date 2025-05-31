namespace BatExplode___Falcari___Manuzzato
{
    partial class PlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            lbl_Tempo = new Label();
            lbl_MineRimanenti = new Label();
            panel2 = new Panel();
            dgv_Campo = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Campo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(465, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 670);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbl_Tempo);
            panel3.Controls.Add(lbl_MineRimanenti);
            panel3.Location = new Point(72, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 210);
            panel3.TabIndex = 3;
            // 
            // lbl_Tempo
            // 
            lbl_Tempo.AutoSize = true;
            lbl_Tempo.Font = new Font("Amiri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Tempo.ForeColor = SystemColors.ButtonHighlight;
            lbl_Tempo.Location = new Point(3, 120);
            lbl_Tempo.Name = "lbl_Tempo";
            lbl_Tempo.Size = new Size(93, 55);
            lbl_Tempo.TabIndex = 1;
            lbl_Tempo.Text = "Tempo: ";
            // 
            // lbl_MineRimanenti
            // 
            lbl_MineRimanenti.AutoSize = true;
            lbl_MineRimanenti.Font = new Font("Amiri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_MineRimanenti.ForeColor = SystemColors.ButtonHighlight;
            lbl_MineRimanenti.Location = new Point(3, 44);
            lbl_MineRimanenti.Name = "lbl_MineRimanenti";
            lbl_MineRimanenti.Size = new Size(145, 55);
            lbl_MineRimanenti.TabIndex = 0;
            lbl_MineRimanenti.Text = "Mine rimaste:";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(12, 367);
            panel2.Name = "panel2";
            panel2.Size = new Size(716, 481);
            panel2.TabIndex = 1;
            // 
            // dgv_Campo
            // 
            dgv_Campo.AllowUserToAddRows = false;
            dgv_Campo.AllowUserToDeleteRows = false;
            dgv_Campo.AllowUserToResizeColumns = false;
            dgv_Campo.AllowUserToResizeRows = false;
            dgv_Campo.BackgroundColor = Color.FromArgb(15, 15, 25);
            dgv_Campo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Campo.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_Campo.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_Campo.Location = new Point(48, 39);
            dgv_Campo.MultiSelect = false;
            dgv_Campo.Name = "dgv_Campo";
            dgv_Campo.RowHeadersVisible = false;
            dgv_Campo.RowHeadersWidth = 51;
            dgv_Campo.RowTemplate.Height = 29;
            dgv_Campo.ScrollBars = ScrollBars.None;
            dgv_Campo.Size = new Size(450, 450);
            dgv_Campo.TabIndex = 2;
            dgv_Campo.CellMouseClick += dgv_Campo_CellMouseClick;
            // 
            // PlayForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 40);
            ClientSize = new Size(914, 600);
            Controls.Add(dgv_Campo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PlayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlayForm";
            Load += PlayForm_Load_1;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Campo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgv_Campo;
        private Panel panel3;
        private Label lbl_Tempo;
        private Label lbl_MineRimanenti;
    }
}