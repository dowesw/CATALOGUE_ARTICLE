using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CATALOGUE_ARTICLE.TOOLS;
using CATALOGUE_ARTICLE.BLL;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.IHM._2ND
{
    public partial class Form_Save_Niveau : Form
    {
        Form_Acces current = new Form_Acces();

        public Form_Save_Niveau(Form_Acces current)
        {
            InitializeComponent();
            this.current = current;
            Configuration.Load(this);
        }

        private void Form_Save_Famille_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void LoadConfig()
        {
            LoadLangue();
        }

        private void LoadLangue()
        {
            this.Text = Mots.Save_Famille;
            lb_description.Text = Mots.Description + " :";
            lb_designation.Text = Mots.Designation + " :";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            NiveauAcces f = new NiveauAcces();
            f.Designation = txt_designation.Text.Trim();
            f.Description = txt_description.Text.Replace("'", "''");
            if (f.Control())
            {
                f = NiveauAccesBLL.Save(f);
                if (f != null ? f.Id > 0 : false)
                {
                    current.niveaux.Add(f);
                    current.com_niveau.Refresh();
                    current.com_niveau.DataSource = new BindingSource(current.niveaux, null);
                    current.com_niveau.ResetText();
                    current.com_niveau.SelectedText = f.Designation;
                    current.current = f;
                    this.Close();
                }
            }
        }

        private void txt_description_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void txt_description_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = btn_save;
        }
    }
}
