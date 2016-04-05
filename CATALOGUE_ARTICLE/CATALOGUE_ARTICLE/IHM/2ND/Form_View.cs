using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CATALOGUE_ARTICLE.BLL;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.IHM._2ND
{
    public partial class Form_View : Form
    {
        Articles current = new Articles();

        public Form_View(Articles article)
        {
            InitializeComponent();
            Configuration.Load(this);
            current = article;
        }

        private void Form_View_Load(object sender, EventArgs e)
        {
            current = ArticlesBLL.One(current.Id);
            Populate(current);
            LoadConfig();
        }

        private void LoadConfig(){
            LoadLangue();
        }

        private void LoadLangue()
        {
            this.Text = Mots.Vue_Article;
            grp_photo.Text = Mots.Photo;
            lb_description.Text = Mots.Description +" :";
            lb_designation.Text = Mots.Designation + " :";
            lb_famille.Text = Mots.Famille + " :";
            lb_marque.Text = Mots.Marque + " :";
            lb_pua.Text = Mots.Prix_Achat + " :";
            lb_puv.Text = Mots.Prix_Vente + " :";
            lb_reference.Text = Mots.Reference + " :";
            lb_stock.Text = Mots.Stock + " :";
        }

        private void Populate(Articles a)
        {
            txt_reference.Text = a.Reference;
            txt_designation.Text = a.Designation;
            if (a.Marque != null ? a.Marque.Id > 0 : false)
            {
                txt_marque.Text = a.Marque.Designation;
            }
            txt_description.Text = a.Description;
            txt_pua.Text = string.Format("{0:#,##0}", a.Pua);
            txt_puv.Text = string.Format("{0:#,##0}", a.Puv);
            if (a.Famille != null ? a.Famille.Id > 0 : false)
            {
                txt_famille.Text = a.Famille.Designation;
            }
            txt_stock.Text = string.Format("{0:#,##0}", a.Stock);
            LoadPhotoPrincipal();
        }

        private void LoadPhotoPrincipal()
        {
            box_photo.Image.Dispose();
            if (current != null ? current.Id > 0 : false)
            {
                if (current.Photos != null ? current.Photos.Count > 0 : false)
                {
                    string chemin = Chemins.getCheminArticle(current.Id.ToString());
                    box_photo.Image = Image.FromFile(chemin + current.Photos[0].Nom);
                    return;
                }
            }
            box_photo.Image = global::CATALOGUE_ARTICLE.Properties.Resources.article;
        }
    }
}
