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
    public partial class Kryesore : Form
    {
        public Kryesore()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetodat.SelectedIndex==0)
            {
                BruteForce objBrute = new BruteForce();
                objBrute.Show();
            }
            else if (cmbMetodat.SelectedIndex==1)
            {
                LetterFrequency objf = new LetterFrequency();
                objf.Show();
            }
            else if (cmbMetodat.SelectedIndex==2)
            {
                DictionaryAttack objFr = new DictionaryAttack();
                objFr.Show();
            }
        }

        private void Kryesore_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            About objP = new About();
            objP.Show();
        }
    }
}
