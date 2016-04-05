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
    public partial class Form_Save_Marque : Form
    {
        Form_Article current = new Form_Article();

        public Form_Save_Marque(Form_Article current)
        {
            InitializeComponent();
            this.current = current;
            Configuration.Load(this);
        }

        private void Form_Save_Marque_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void LoadConfig()
        {
            LoadLangue();
        }

        private void LoadLangue()
        {
            this.Text = Mots.Save_Marque;
            lb_designation.Text = Mots.Designation + " :";
            lb_reference.Text = Mots.Reference + " :";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Marque f = new Marque();
            f.Reference = txt_reference.Text.Trim();
            f.Designation = txt_designation.Text.Trim();
            if (f.Control())
            {
                f = MarqueBLL.Save(f);
                if (f != null ? f.Id > 0 : false)
                {
                    current.marques.Add(f);
                    if (current.current != null ? current.current.Id > 0 : false)
                    {
                        current.current.Marque = f;
                    }

                    current.com_marque.Refresh();
                    current.com_marque.DisplayMember = "Designation";
                    current.com_marque.ValueMember = "Id";
                    current.com_marque.DataSource = new BindingSource(current.marques, null);
                    current.com_marque.Text = f.Designation;
                    current.com_marque.AutoCompleteCustomSource.Add(f.Designation);

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
