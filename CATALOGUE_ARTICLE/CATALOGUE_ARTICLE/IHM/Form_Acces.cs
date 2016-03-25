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
    public partial class Form_Acces : Form
    {
        public Form_Acces()
        {
            InitializeComponent();
        }

        private void Form_Acces_FormClosed(object sender, FormClosedEventArgs e)
        {
            Constantes.f_acces = null;
            Constantes.f_last = "Acces";
        }
    }
}
