using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.IHM
{
    public partial class Form_Propos : Form
    {
        public Form_Propos()
        {
            InitializeComponent();
        }

        private void Form_Propos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Constantes.f_propos = null;
            Constantes.f_last = "Propos";
            Utils.removeFrom(this.Name);
        }

        private void Form_Propos_Load(object sender, EventArgs e)
        {
            Utils.addFrom(this.Name);
        }
    }
}
