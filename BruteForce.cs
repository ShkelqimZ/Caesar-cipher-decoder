using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekti_Siguria_te_dhenave
{
    public partial class BruteForce : Form
    {
        public BruteForce()
        {
            InitializeComponent();
        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            rtxtRastet.Text = Rastet(txtEnkriptuar.Text.ToUpper());
        }

        public string Dekripto(string ciphertext, int celsi)
        {
            StringBuilder plaintext = new StringBuilder(ciphertext);

            for (int i = 0; i < ciphertext.Length; i++)
            {

                if (plaintext[i] != ' ')
                {
                    int pozitaShkronjes = ciphertext[i] - 'A';
                    int pozitaReshkronjes = (pozitaShkronjes - celsi + 26) % 26;

                    plaintext[i] = (char)(pozitaReshkronjes + 'A');
                }


            }
            return plaintext.ToString();
        }

        public string Rastet(string Teksti)
        {
            string varg = "";

            for (int i = 0; i < 26; i++)
            {

                varg += "  " + Dekripto(Teksti, i) + "-----------KEY IS : " + i + "\n\n";
            }
            return varg;
        }

        private void BruteForce_Load(object sender, EventArgs e)
        {
            rtxtRastet.ReadOnly = true;
        }
    }
}
