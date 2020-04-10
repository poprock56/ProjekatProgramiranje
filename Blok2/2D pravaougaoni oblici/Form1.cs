using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TREBA DA NAPRAVIM DA RADI AKO PISE 68 PRAVOUGAOIKA I ISCRAT 64 A 4 MOGU DA SE POLOZE;
namespace _2D_pravaougaoni_oblici
{
    public partial class frmRadnaPovrsina : Form
    {
        public frmRadnaPovrsina()
        {
            InitializeComponent();    
           
        }

        private void rbKvadrat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKvadrat.Checked)//nisam mogao da nadjem checked medju eventovima
            {
                pnlRadnaPovrsina.Controls.Clear();
                int povrsina = pnlRadnaPovrsina.Width * pnlRadnaPovrsina.Height;
                int aDimenzija = 1;

                try
                {
                    aDimenzija = Int32.Parse(tbADimenzija.Text);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Nije broj: '{tbADimenzija.Text}'");
                }

                int povrsinaOblika = aDimenzija * aDimenzija;
                int staje = povrsina / povrsinaOblika;
                MessageBox.Show(($"Staje {staje} kvadrata u nas oblik"));
                IscrtajKvadar(aDimenzija, aDimenzija, staje);
            }   
        }

        private void rbPravougaonik_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPravougaonik.Checked)//nisam mogao da nadjem checked medju eventovima
            {
                pnlRadnaPovrsina.Controls.Clear();
                int povrsina = pnlRadnaPovrsina.Width * pnlRadnaPovrsina.Height;
                int aDimenzija = 1, bDimenzija = 1;

                try
                {
                    aDimenzija = Int32.Parse(tbADimenzija.Text);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Nije broj: '{tbADimenzija.Text}'");
                }
                try
                {
                    bDimenzija = Int32.Parse(tbBDimenzija.Text);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Nije broj: '{tbBDimenzija.Text}'");
                }

                int povrsinaOblika = aDimenzija * bDimenzija;
                int staje = povrsina / povrsinaOblika;
                MessageBox.Show(($"Staje {staje} pravougaonika u nas oblik"));
                IscrtajKvadar(aDimenzija, bDimenzija, staje);
            }
        }
        private void IscrtajKvadar(int aDimenzija,int bDimenzija, int staje)
        {
            int brojac = 1;
            if ((pnlRadnaPovrsina.Height * pnlRadnaPovrsina.Width % (aDimenzija * bDimenzija )) == 0)
            {
            Graphics g2 = pnlRadnaPovrsina.CreateGraphics();
            g2.FillRectangle(Brushes.White, 0, 0, pnlRadnaPovrsina.Width, pnlRadnaPovrsina.Height);
                for (int i = 0; i < pnlRadnaPovrsina.Width / aDimenzija; i++)
                {
                    for (int j = 0; j < pnlRadnaPovrsina.Height / bDimenzija; j++)
                    {
                        g2.FillRectangle(Brushes.White, aDimenzija * i, bDimenzija * j, aDimenzija, bDimenzija);
                        g2.DrawRectangle(new Pen(Color.Black), aDimenzija * i, bDimenzija * j, aDimenzija, bDimenzija);
                        System.Drawing.Font font = new System.Drawing.Font("Arial", 8);
                        g2.DrawString(brojac.ToString(), font, Brushes.Black, aDimenzija * i + aDimenzija / 2 - 4, bDimenzija * j + bDimenzija / 2 - 4);
                        brojac++;
                    }
                }
            }
            brojac--;
            int brojIzostalih = staje - brojac;
            if(brojIzostalih > 0)
            {
                MessageBox.Show(brojIzostalih.ToString());

            }

        }
    }
}
