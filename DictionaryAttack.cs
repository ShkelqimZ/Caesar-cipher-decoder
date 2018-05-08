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
    public partial class DictionaryAttack : Form
    {
        public DictionaryAttack()
        {
            InitializeComponent();
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

        public string mFjalorthi(string Teksti)
        {
            string[] varg = new string[26];
            string[] fjalorthi = { "ESHTE", "JANE", "VITI", "EDHE", "DHE", "NGA","MOS","PER","SHUME","ISHTE",
                               "MUND","DUKE","DUHET","PREJ","SIPAS","SEPSE","MIRE","NUK","KUR"};
            for (int i = 0; i < 26; i++)
            {
                varg[i] += Dekripto(Teksti, i);

                foreach (string anetari in fjalorthi)
                {
                    if (varg[i].Contains(anetari))
                    {
                        return varg[i];
                    }
                }
                
            }
            return "Dictionary has no word like those !";
        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            rtbTekstiDekriptuar.Text = mFjalorthi(txtEnkriptuar.Text.ToUpper());
        }

        private void DictionaryAttack_Load(object sender, EventArgs e)
        {
            rtbTekstiDekriptuar.ReadOnly = true;
        }

        private void rtbTekstiDekriptuar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
