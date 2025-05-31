using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatExplode___Falcari___Manuzzato
{
    public partial class PlayForm : Form
    {

        public PlayForm()
        {
            InitializeComponent();
        }

        Cella[,] matrice;
        int mines;
        

        private void PlayForm_Load_1(object sender, EventArgs e)
        {
            InizializeGrid();
            matrice = new Cella[9, 9];
            mines = 10; // sistemare calcolo in base alla difficoltà scelta
            InizializeMatrix();
            //PiccoloDebug();

            
        }

        
        private void PiccoloDebug()
        {
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    dgv_Campo.Rows[i].Cells[j].Value = matrice[i, j].value.ToString();
                }
            }
        }

        private void InizializeGrid()
        {
            dgv_Campo.ClearSelection();

            dgv_Campo.ColumnCount = 9;
            dgv_Campo.RowCount = 9;

            foreach (DataGridViewColumn col in dgv_Campo.Columns)
            {
                col.Width = 50;
            }

            foreach (DataGridViewRow row in dgv_Campo.Rows)
            {
                row.Height = 50;
            }

            for (int i = 0; i < dgv_Campo.ColumnCount; i++)
            {
                for (int j = 0; j < dgv_Campo.RowCount; j++)
                {
                    dgv_Campo.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(15, 15, 25);
                    dgv_Campo.Rows[j].Cells[i].Style.ForeColor = Color.FromArgb(255, 255, 255);
                }
            }
        }

        private void InizializeMatrix()
        {
            //inizializzo tutto a 0
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    matrice[i, j] = new Cella(i, j, 0);
                }
            }

            //genero mine
            GenerateMines();

            //valori per ogni cella
            SetValues();
        }

        private void dgv_Campo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cella cella = matrice[e.RowIndex, e.ColumnIndex];

            dgv_Campo.ClearSelection();

            if (e.Button == MouseButtons.Right)
            {
                Flag(cella);
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                switch (cella.value)
                {
                    case 0:
                        Explode(cella);
                        break;
                    case -1:
                        Sconfitta();
                        break;
                    default:
                        Scopri(cella);
                        break;
                }

                CheckVictory();
            }
        }

        private void Flag(Cella cella)
        {
            if (cella.scoperta) return;

            if (cella.flag)
            {
                cella.flag = false;
                dgv_Campo.Rows[cella.x].Cells[cella.y].Style.BackColor = Color.FromArgb(15, 15, 25);
                dgv_Campo.Rows[cella.x].Cells[cella.y].Value = "";

                mines++;
                lbl_MineRimanenti.Text = $"Mine rimanenti: {mines}";

                return;
            }

            cella.flag = true;
            dgv_Campo.Rows[cella.x].Cells[cella.y].Style.BackColor = Color.FromArgb(255, 100, 100);
            dgv_Campo.Rows[cella.x].Cells[cella.y].Value = "🏴";
            mines--;
            lbl_MineRimanenti.Text = $"Mine rimanenti: {mines}";
        }


        private void GenerateMines()
        {
            Random random = new Random();
            int minesToGenerate = mines;
            while (minesToGenerate > 0)
            {
                int y = random.Next(0, 9);
                int x = random.Next(0, 9);
                if (matrice[x, y].value == 0)
                {
                    matrice[x, y].value = -1;
                    minesToGenerate--;
                }
            }
        }

        private void SetValues()
        {
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    if (matrice[i, j].value == -1) continue;
                    int counter = 0;
                    for (int k = -1; k <= 1; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            int x = i + k;
                            int y = j + l;
                            if (x >= 0 && x < matrice.GetLength(0) && y >= 0 && y < matrice.GetLength(1))
                            {
                                if (matrice[x, y].value == -1)
                                {
                                    counter++;
                                }
                            }
                        }

                    }

                    matrice[i, j].value = counter;
                }
            }
        }




        private void Scopri(Cella cella)
        {
            if (cella.scoperta) return;

            cella.scoperta = true;

            switch (cella.value)
            {
                case 0:
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Style.BackColor = Color.FromArgb(60, 60, 80);
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Style.ForeColor = Color.FromArgb(255, 255, 255);
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Value = "";
                    break;
                case 1:
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Style.ForeColor = Color.FromArgb(100, 150, 255);
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Style.BackColor = Color.FromArgb(25, 25, 40);
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Value = "1";
                    break;
                case 2:
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Style.ForeColor = Color.FromArgb(120, 200, 120);
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Style.BackColor = Color.FromArgb(25, 30, 25);
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Value = "2";
                    break;
                case 3:
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Style.ForeColor = Color.FromArgb(255, 100, 100);
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Style.BackColor = Color.FromArgb(40, 25, 25);
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Value = "3";
                    break;
                default:
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Style.ForeColor = Color.FromArgb(100, 100, 200);
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Style.BackColor = Color.FromArgb(20, 5, 5);
                    dgv_Campo.Rows[cella.x].Cells[cella.y].Value = cella.value.ToString();
                    break;
            }
        }

        private void Explode(Cella cella)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int x = cella.x + i;
                    int y = cella.y + j;

                    if (x < 0 || x >= matrice.GetLength(0) || y < 0 || y >= matrice.GetLength(1)) continue;

                    if (matrice[x, y].scoperta) continue;

                    switch (matrice[x, y].value)
                    {
                        case 0:
                            Scopri(matrice[x, y]);
                            Explode(matrice[x, y]);
                            break;
                        case -1:
                            break;
                        default:
                            Scopri(matrice[x, y]);
                            break;
                    }
                }
            }
        }

        private void CheckVictory()
        {
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    if (matrice[i, j].value != -1 && !matrice[i, j].scoperta)
                    {
                        return;
                    }
                }
            }

            Vittoria();

        }

        private void Vittoria()
        {
            WinLoseForm procione = new WinLoseForm(true);
            procione.Show();
            this.Hide();
        }

        private void Sconfitta()
        {
            WinLoseForm procione = new WinLoseForm(false);
            procione.Show();
            this.Hide();
        }

        
    }
}
