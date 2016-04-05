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
    public partial class Form_Open : Form
    {
        public Form_Open()
        {
            InitializeComponent();
        }

        private void Form_Open_FormClosed(object sender, FormClosedEventArgs e)
        {
            Constantes.f_open = null;
            Utils.removeFrom(this.Name);
        }

        private void Form_Open_Load(object sender, EventArgs e)
        {
            Utils.addFrom(this.Name);
            LoadConfig();
        }

        private void LoadConfig()
        {
            LoadLangue();
        }

        private void LoadLangue()
        {
            this.Text = Mots.Ouvrir;
            lb_nom.Text = Mots.Nom;
            grp_article.Text = Mots.Article;
            grp_autorisation.Text = Mots.Autorisation;
            grp_catalogue.Text = Mots.Catalogue_Article;
            grp_doc_stock.Text = Mots.Document_Stock;
            grp_accessoire.Text = Mots.Accessoire_Article;
            grp_gestion_article.Text = Mots.Gestion_Article;
            grp_gestion_stock.Text = Mots.Gestion_Stock;
            grp_gestion_user.Text = Mots.Gestion_Utilisateur;
            grp_inventaire.Text = Mots.Inventaire;
            grp_mouv_stock.Text = Mots.Mouvement_Stock;
            grp_parametre.Text = Mots.Parametre;
            grp_users.Text = Mots.Utilisateurs;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            switch (txt_name_form.Text)
            {
                case "Mouvements Stock":
                    //if (!AccesFormulaires.form_mouvement)
                    //{
                    //    Messages.ShowErreur("Vous ne disposez pas des droits pour accéder à ce formulaire");
                    //    return;
                    //}
                    Form_Mouvement f_mouvement = new Form_Mouvement();
                    if (Constantes.f_mouvement == null)
                    {
                        f_mouvement.MdiParent = this.MdiParent;
                        f_mouvement.Show();
                        Constantes.f_mouvement = f_mouvement;
                    }
                    else
                    {
                        Constantes.f_mouvement.WindowState = FormWindowState.Normal;
                        Constantes.f_mouvement.BringToFront();
                        Utils.addFrom("Form_Mouvement");
                    }
                    break;
                case "Documents Stock":
                    //if (!AccesFormulaires.form_docstock)
                    //{
                    //    Messages.ShowErreur("Vous ne disposez pas des droits pour accéder à ce formulaire");
                    //    return;
                    //}
                    Form_DocStock f_docstock = new Form_DocStock();
                    if (Constantes.f_docstock == null)
                    {
                        f_docstock.MdiParent = this.MdiParent;
                        f_docstock.Show();
                        Constantes.f_docstock = f_docstock;
                    }
                    else
                    {
                        Constantes.f_docstock.WindowState = FormWindowState.Normal;
                        Constantes.f_docstock.BringToFront();
                        Utils.addFrom("Form_DocStock");
                    }
                    break;
                case "Autorisations":
                    //if (!AccesFormulaires.form_acces)
                    //{
                    //    Messages.ShowErreur("Vous ne disposez pas des droits pour accéder à ce formulaire");
                    //    return;
                    //}
                    Form_Acces f_acces = new Form_Acces();
                    if (Constantes.f_acces == null)
                    {
                        f_acces.MdiParent = this.MdiParent;
                        f_acces.Show();
                        Constantes.f_acces = f_acces;
                    }
                    else
                    {
                        Constantes.f_acces.WindowState = FormWindowState.Normal;
                        Constantes.f_acces.BringToFront();
                        Utils.addFrom("Form_Acces");
                    }
                    break;
                case "Utilisateurs":
                    //if (!AccesFormulaires.form_users)
                    //{
                    //    Messages.ShowErreur("Vous ne disposez pas des droits pour accéder à ce formulaire");
                    //    return;
                    //}
                    Form_Users f_users = new Form_Users();
                    if (Constantes.f_users == null)
                    {
                        f_users.MdiParent = this.MdiParent;
                        f_users.Show();
                        Constantes.f_users = f_users;
                    }
                    else
                    {
                        Constantes.f_users.WindowState = FormWindowState.Normal;
                        Constantes.f_users.BringToFront();
                        Utils.addFrom("Form_Users");
                    }
                    break;
                case "Paramètres":
                    //if (!AccesFormulaires.form_setting)
                    //{
                    //    Messages.ShowErreur("Vous ne disposez pas des droits pour accéder à ce formulaire");
                    //    return;
                    //}
                    Form_Setting f_setting = new Form_Setting();
                    if (Constantes.f_setting == null)
                    {
                        f_setting.MdiParent = this.MdiParent;
                        f_setting.Show();
                        Constantes.f_setting = f_setting;
                    }
                    else
                    {
                        Constantes.f_setting.WindowState = FormWindowState.Normal;
                        Constantes.f_setting.BringToFront();
                        Utils.addFrom("Form_Setting");
                    }
                    break;
                case "Catalogue Article":
                    Form_Catalogue f_catalogue = new Form_Catalogue();
                    if (Constantes.f_catalogue == null)
                    {
                        f_catalogue.MdiParent = this.MdiParent;
                        f_catalogue.Show();
                        Constantes.f_catalogue = f_catalogue;
                    }
                    else
                    {
                        Constantes.f_catalogue.WindowState = FormWindowState.Normal;
                        Constantes.f_catalogue.BringToFront();
                        Utils.addFrom("Form_Catalogue");
                    }
                    break;
                case "Accessoire Article":
                    //if (!AccesFormulaires.form_famille)
                    //{
                    //    Messages.ShowErreur("Vous ne disposez pas des droits pour accéder à ce formulaire");
                    //    return;
                    //}
                    Form_Accessoire_Article f_famille = new Form_Accessoire_Article();
                    if (Constantes.f_famille == null)
                    {
                        f_famille.MdiParent = this.MdiParent;
                        f_famille.Show();
                        Constantes.f_famille = f_famille;
                    }
                    else
                    {
                        Constantes.f_famille.WindowState = FormWindowState.Normal;
                        Constantes.f_famille.BringToFront();
                        Utils.addFrom("Form_Famille");
                    }
                    break;
                case "Articles":
                    //if (!AccesFormulaires.form_article)
                    //{
                    //    Messages.ShowErreur("Vous ne disposez pas des droits pour accéder à ce formulaire");
                    //    return;
                    //}
                    Form_Article f_article = new Form_Article();
                    if (Constantes.f_article == null)
                    {
                        f_article.MdiParent = this.MdiParent;
                        f_article.Show();
                        Constantes.f_article = f_article;
                    }
                    else
                    {
                        Constantes.f_article.WindowState = FormWindowState.Normal;
                        Constantes.f_article.BringToFront();
                        Utils.addFrom("Form_Article");
                    }
                    break;
                default:
                    break;
            }
            this.Close();
        }

        private void resetAllPicture()
        {
            box_article.BackColor = Color.White;
            box_catalogue.BackColor = Color.White;
            box_famille.BackColor = Color.White;
            box_doc.BackColor = Color.White;
            box_inventaire.BackColor = Color.White;
            box_mouv.BackColor = Color.White;
            box_users.BackColor = Color.White;
            box_acces.BackColor = Color.White;
            box_setting.BackColor = Color.White;
        }

        private void pic_famille_Click(object sender, EventArgs e)
        {
            txt_name_form.Text = "Accessoire Article";
            resetAllPicture();
            box_famille.BackColor = Color.LightSkyBlue;
        }

        private void pic_famille_DoubleClick(object sender, EventArgs e)
        {
            //if (!AccesFormulaires.form_famille)
            //{
            //    Messages.ShowErreur("Vous ne disposez pas des droits pour accéder à ce formulaire");
            //    return;
            //}
            Form_Accessoire_Article f_famille = new Form_Accessoire_Article();
            if (Constantes.f_famille == null)
            {
                f_famille.MdiParent = this.MdiParent;
                f_famille.Show();
                Constantes.f_famille = f_famille;
            }
            else
            {
                Constantes.f_famille.WindowState = FormWindowState.Normal;
                Constantes.f_famille.BringToFront();
                Utils.addFrom("Form_Famille");
            }
            this.Close();
        }

        private void pic_article_Click(object sender, EventArgs e)
        {
            txt_name_form.Text = "Articles";
            resetAllPicture();
            box_article.BackColor = Color.LightSkyBlue;
        }

        private void pic_article_DoubleClick(object sender, EventArgs e)
        {
            //if (!AccesFormulaires.form_article)
            //{
            //    Messages.ShowErreur("Vous ne disposez pas des droits pour accéder à ce formulaire");
            //    return;
            //}
            Form_Article f_article = new Form_Article();
            if (Constantes.f_article == null)
            {
                f_article.MdiParent = this.MdiParent;
                f_article.Show();
                Constantes.f_article = f_article;
            }
            else
            {
                Constantes.f_article.WindowState = FormWindowState.Normal;
                Constantes.f_article.BringToFront();
                Utils.addFrom("Form_Article");
            }
            this.Close();
        }

        private void pic_catalogue_Click(object sender, EventArgs e)
        {
            txt_name_form.Text = "Catalogue Article";
            resetAllPicture();
            box_catalogue.BackColor = Color.LightSkyBlue;
        }

        private void box_catalogue_DoubleClick(object sender, EventArgs e)
        {
            Form_Catalogue f_catalogue = new Form_Catalogue();
            if (Constantes.f_catalogue == null)
            {
                f_catalogue.MdiParent = this.MdiParent;
                f_catalogue.Show();
                Constantes.f_catalogue = f_catalogue;
            }
            else
            {
                Constantes.f_catalogue.WindowState = FormWindowState.Normal;
                Constantes.f_catalogue.BringToFront();
                Utils.addFrom("Form_Catalogue");
            }
            this.Close();
        }

        private void box_doc_Click(object sender, EventArgs e)
        {
            txt_name_form.Text = "Documents Stock";
            resetAllPicture();
            box_doc.BackColor = Color.LightSkyBlue;
        }

        private void box_doc_DoubleClick(object sender, EventArgs e)
        {
            //if (!AccesFormulaires.form_docstock)
            //{
            //    Messages.ShowErreur("Vous ne disposez pas des droits pour accéder à ce formulaire");
            //    return;
            //}
            Form_DocStock f_docstock = new Form_DocStock();
            if (Constantes.f_docstock == null)
            {
                f_docstock.MdiParent = this.MdiParent;
                f_docstock.Show();
                Constantes.f_docstock = f_docstock;
            }
            else
            {
                Constantes.f_docstock.WindowState = FormWindowState.Normal;
                Constantes.f_docstock.BringToFront();
                Utils.addFrom("Form_DocStock");
            }
            this.Close();
        }

        private void box_inventaire_Click(object sender, EventArgs e)
        {
            txt_name_form.Text = "Inventaire";
            resetAllPicture();
            box_inventaire.BackColor = Color.LightSkyBlue;
        }

        private void box_inventaire_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void box_mouv_Click(object sender, EventArgs e)
        {
            txt_name_form.Text = "Mouvements Stock";
            resetAllPicture();
            box_mouv.BackColor = Color.LightSkyBlue;
        }

        private void box_mouv_DoubleClick(object sender, EventArgs e)
        {

            //if (!AccesFormulaires.form_mouvement)
            //{
            //    Messages.ShowErreur("Vous ne disposez pas des droits pour accéder à ce formulaire");
            //    return;
            //}
            Form_Mouvement f_mouvement = new Form_Mouvement();
            if (Constantes.f_mouvement == null)
            {
                f_mouvement.MdiParent = this.MdiParent;
                f_mouvement.Show();
                Constantes.f_mouvement = f_mouvement;
            }
            else
            {
                Constantes.f_mouvement.WindowState = FormWindowState.Normal;
                Constantes.f_mouvement.BringToFront();
                Utils.addFrom("Form_Mouvement");
            }
            this.Close();
        }

        private void box_users_Click(object sender, EventArgs e)
        {
            txt_name_form.Text = "Utilisateurs";
            resetAllPicture();
            box_users.BackColor = Color.LightSkyBlue;
        }

        private void box_users_DoubleClick(object sender, EventArgs e)
        {
            //if (!AccesFormulaires.form_users)
            //{
            //    Messages.ShowErreur("Vous ne disposez pas des droits pour accéder à ce formulaire");
            //    return;
            //}
            Form_Users f_users = new Form_Users();
            if (Constantes.f_users == null)
            {
                f_users.MdiParent = this.MdiParent;
                f_users.Show();
                Constantes.f_users = f_users;
            }
            else
            {
                Constantes.f_users.WindowState = FormWindowState.Normal;
                Constantes.f_users.BringToFront();
                Utils.addFrom("Form_Users");
            }
            this.Close();
        }

        private void box_acces_Click(object sender, EventArgs e)
        {
            txt_name_form.Text = "Autorisations";
            resetAllPicture();
            box_acces.BackColor = Color.LightSkyBlue;
        }

        private void box_acces_DoubleClick(object sender, EventArgs e)
        {
            //if (!AccesFormulaires.form_acces)
            //{
            //    Messages.ShowErreur("Vous ne disposez pas des droits pour accéder à ce formulaire");
            //    return;
            //}
            Form_Acces f_acces = new Form_Acces();
            if (Constantes.f_acces == null)
            {
                f_acces.MdiParent = this.MdiParent;
                f_acces.Show();
                Constantes.f_acces = f_acces;
            }
            else
            {
                Constantes.f_acces.WindowState = FormWindowState.Normal;
                Constantes.f_acces.BringToFront();
                Utils.addFrom("Form_Acces");
            }
            this.Close();
        }

        private void box_setting_Click(object sender, EventArgs e)
        {
            txt_name_form.Text = "Paramètres";
            resetAllPicture();
            box_setting.BackColor = Color.LightSkyBlue;
        }

        private void box_setting_DoubleClick(object sender, EventArgs e)
        {
            //if (!AccesFormulaires.form_users)
            //{
            //    Messages.ShowErreur("Vous ne disposez pas des droits pour accéder à ce formulaire");
            //    return;
            //}
            Form_Setting f_setting = new Form_Setting();
            if (Constantes.f_setting == null)
            {
                f_setting.MdiParent = this.MdiParent;
                f_setting.Show();
                Constantes.f_setting = f_setting;
            }
            else
            {
                Constantes.f_setting.WindowState = FormWindowState.Normal;
                Constantes.f_setting.BringToFront();
                Utils.addFrom("Form_Setting");
            }
            this.Close();
        }
    }
}
