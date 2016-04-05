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
    public partial class Form_Save_Famille : Form
    {
        Form_Article current = new Form_Article();
        public List<FamillesArticle> familles = new List<FamillesArticle>();
        public FamillesArticle famille = new FamillesArticle();

        public Form_Save_Famille(Form_Article current)
        {
            InitializeComponent();
            this.current = current;
            Configuration.Load(this);
        }

        private void Form_Save_Famille_Load(object sender, EventArgs e)
        {
            LoadConfig();
            LoadAllFamilles();
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
            lb_reference.Text = Mots.Reference + " :";
        }


        private void LoadAllFamilles()
        {
            familles.Clear();
            string query = "select * from familles_article order by id";
            familles = FamillesArticleBLL.List(query);
            com_parent.DisplayMember = "Designation";
            com_parent.ValueMember = "Id";
            com_parent.DataSource = new BindingSource(familles, null);

            foreach (FamillesArticle f in familles)
            {
                com_parent.AutoCompleteCustomSource.Add(f.Designation);
            }
            com_parent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            com_parent.AutoCompleteSource = AutoCompleteSource.CustomSource;
            com_parent.ResetText();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            FamillesArticle f = new FamillesArticle();
            f.Reference = txt_reference.Text.Trim();
            f.Designation = txt_designation.Text.Trim();
            f.Description = txt_description.Text.Replace("'", "''");
            if (famille != null ? famille.Id > 0 : false)
            {
                f.Parent = famille;
            }
            if (f.Control())
            {
                f = FamillesArticleBLL.Save(f);
                if (f != null ? f.Id > 0 : false)
                {
                    current.familles.Add(f);
                    current.com_famille.Refresh();
                    if (current.current != null ? current.current.Id > 0 : false)
                    {
                        current.current.Famille = f;
                    }
                    current.com_famille.DataSource = new BindingSource(current.familles, null);
                    current.com_famille.Text = f.Designation;
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

        private void com_parent_SelectedIndexChanged(object sender, EventArgs e)
        {
            FamillesArticle a = com_parent.SelectedItem as FamillesArticle;
            a = familles.Find(x => x.Id == a.Id);
            famille = a;
        }
    }
}
