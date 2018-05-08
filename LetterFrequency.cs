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
    public partial class LetterFrequency : Form
    {
        public LetterFrequency()
        {
            InitializeComponent();
        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            rtbETekstiDekriptuar.Text = DekriptoE(txtEnkriptuar.Text.ToUpper());
            rtbATekstiDekriptuar.Text = DekriptoA(txtEnkriptuar.Text.ToUpper());
            rtbITekstiDekriptuar.Text = DekriptoI(txtEnkriptuar.Text.ToUpper());
        }

        //SHKRONJA E
        public string DekriptoE(string ciphertext)
        {
            StringBuilder plaintext = new StringBuilder(ciphertext);
            int NrShkronjave = 0;
            int MaxShkronjave = 0;
            char ShkronjaMax = '.';
            for (int i = 0; i < ciphertext.Length; i++)
            {
                if (plaintext[i] != ' ')
                {
                    int shkronjaASCII = (int)ciphertext[i];
                    NrShkronjave = 0;
                    for (int j = 0; j < ciphertext.Length; j++)
                    {
                        if (shkronjaASCII == (int)ciphertext[j])
                        {
                            NrShkronjave++;
                            if (NrShkronjave > MaxShkronjave)
                            {
                                MaxShkronjave = NrShkronjave;
                                ShkronjaMax = ciphertext[i];
                            }
                        }
                    }
                }
            }

            int Fshkronja = ((int)ShkronjaMax - (int)'E');  
            for (int i = 0; i < ciphertext.Length; i++)
            {

                if (plaintext[i] != ' ')
                {
                    int pozitaShkronjes = ciphertext[i] - 'A';
                    int pozitaReshkronjes = (pozitaShkronjes - Fshkronja + 26) % 26;

                    plaintext[i] = (char)(pozitaReshkronjes + 'A');
                }

            }

            return plaintext.ToString();
        }

        //SHKRONJA A
        public string DekriptoA(string ciphertext)
        {
            StringBuilder plaintext = new StringBuilder(ciphertext);
            int NrShkronjave = 0;
            int MaxShkronjave = 0;
            char ShkronjaMax = '.';
            for (int i = 0; i < ciphertext.Length; i++)
            {
                if (plaintext[i] != ' ')
                {
                    int shkronjaASCII = (int)ciphertext[i];
                    NrShkronjave = 0;
                    for (int j = 0; j < ciphertext.Length; j++)
                    {
                        if (shkronjaASCII == (int)ciphertext[j])
                        {
                            NrShkronjave++;
                            if (NrShkronjave > MaxShkronjave)
                            {
                                MaxShkronjave = NrShkronjave;
                                ShkronjaMax = ciphertext[i];
                            }
                        }
                    }
                }
            }

            int Fshkronja = ((int)ShkronjaMax - (int)'A');
            for (int i = 0; i < ciphertext.Length; i++)
            {

                if (plaintext[i] != ' ')
                {
                    int pozitaShkronjes = ciphertext[i] - 'A';
                    int pozitaReshkronjes = (pozitaShkronjes - Fshkronja + 26) % 26;

                    plaintext[i] = (char)(pozitaReshkronjes + 'A');
                }

            }

            return plaintext.ToString();
        }

        //SHKRONJA I
        public string DekriptoI(string ciphertext)
        {
            StringBuilder plaintext = new StringBuilder(ciphertext);
            int NrShkronjave = 0;
            int MaxShkronjave = 0;
            char ShkronjaMax = '.';
            for (int i = 0; i < ciphertext.Length; i++)
            {
                if (plaintext[i] != ' ')
                {
                    int shkronjaASCII = (int)ciphertext[i];
                    NrShkronjave = 0;
                    for (int j = 0; j < ciphertext.Length; j++)
                    {
                        if (shkronjaASCII == (int)ciphertext[j])
                        {
                            NrShkronjave++;
                            if (NrShkronjave > MaxShkronjave)
                            {
                                MaxShkronjave = NrShkronjave;
                                ShkronjaMax = ciphertext[i];
                            }
                        }
                    }
                }
            }

            int Fshkronja = ((int)ShkronjaMax - (int)'I');
            for (int i = 0; i < ciphertext.Length; i++)
            {

                if (plaintext[i] != ' ')
                {
                    int pozitaShkronjes = ciphertext[i] - 'A';
                    int pozitaReshkronjes = (pozitaShkronjes - Fshkronja + 26) % 26;

                    plaintext[i] = (char)(pozitaReshkronjes + 'A');
                }

            }

            return plaintext.ToString();
        }

        private void LetterFrequency_Load(object sender, EventArgs e)
        {
            rtbETekstiDekriptuar.ReadOnly = true;
            rtbATekstiDekriptuar.ReadOnly=true;
            rtbITekstiDekriptuar.ReadOnly = true;
        }
    }
}
