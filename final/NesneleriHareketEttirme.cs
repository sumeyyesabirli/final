using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class NesneleriHareketEttirme : Form
    {
        public NesneleriHareketEttirme()
        {
            InitializeComponent();
        }
        readonly int a = 10;
        private void NesneleriHareketEttirme_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.A)
                button1.Left -= 10;
            if (keyData == Keys.D)
                button1.Left += 10;
            if (keyData == Keys.W)
                button1.Top-= 10;
            if (keyData == Keys.S)
                button1.Top += 10;
            return base.ProcessCmdKey(ref msg, keyData);
        } 
    }
}
