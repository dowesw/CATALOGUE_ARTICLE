using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.IHM
{
    public partial class Form_Licence : Form
    {
        public Form_Licence()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valide_Click(object sender, EventArgs e)
        {
            string text = txt_key.Text.Trim();
            if (!Constantes.ACTIVE)
            {
                if (Licence.verifyKeyLicence(text))
                {
                    Messages.Succes();
                    this.Close();
                }
                else
                {
                    Messages.ShowErreur(Mots.Msg_Licence_Erreur);
                }
            }
            else
            {
                Messages.Show(Mots.Msg_Activer_Licence_Erreur);
            }
        }

        private void Form_Licence_FormClosed(object sender, FormClosedEventArgs e)
        {
            Constantes.f_licence = null;
            Constantes.f_last = "Licence";
            Utils.removeFrom(this.Name);
        }

        private void Form_Licence_Load(object sender, EventArgs e)
        {
            Utils.addFrom(this.Name);
        }
    }
}
