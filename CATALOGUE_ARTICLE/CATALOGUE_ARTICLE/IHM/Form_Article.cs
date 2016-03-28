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
using CATALOGUE_ARTICLE.BLL;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.IHM
{
    public partial class Form_Article : Form
    {
        Articles current = new Articles();
        List<FamillesArticle> familles = new List<FamillesArticle>();

        public Form_Article()
        {
            InitializeComponent();
        }

        private void Form_Article_FormClosed(object sender, FormClosedEventArgs e)
        {
            Constantes.f_article = null;
            Constantes.f_last = "Articles";
            Utils.removeFrom(this.Name);
        }

        private void Form_Article_Load(object sender, EventArgs e)
        {
            Utils.addFrom(this.Name);
            LoadAllFamilles();
            LoadGrille();
        }

        private void AddRow(Articles a)
        {
            dgv_liste.Rows.Add(new object[] { a.Id, a.Reference, a.Designation, a.Marque, a.Pua, a.Puv, a.Famille != null ? a.Famille.Designation : "", null });
        }

        private void UpdateRow(Articles a)
        {
            dgv_liste.Rows.RemoveAt(Utils.GetRowData(dgv_liste, a.Id));
            AddRow(a);
        }

        private void DeleteRow(Articles a)
        {
            dgv_liste.Rows.RemoveAt(Utils.GetRowData(dgv_liste, a.Id));
        }

        private void LoadGrille()
        {
            dgv_liste.Rows.Clear();
            string query = "select * from articles order by id";
            List<Articles> l = ArticlesBLL.List(query);
            foreach (Articles a in l)
            {
                AddRow(a);
            }
            Reset();
        }

        private void LoadAllFamilles()
        {
            familles.Clear();
            string query = "select * from familles_article order by id";
            familles = FamillesArticleBLL.List(query);
            com_famille.DisplayMember = "Designation";
            com_famille.ValueMember = "Id";
            com_famille.DataSource = new BindingSource(familles, null);

            foreach (FamillesArticle f in familles)
            {
                com_famille.AutoCompleteCustomSource.Add(f.Designation);
            }
            com_famille.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            com_famille.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }



        private void Reset()
        {
            txt_reference.ResetText();
            txt_designation.ResetText();
            txt_marque.ResetText();
            txt_description.ResetText();
            txt_pua.Value = 0;
            txt_puv.Value = 0;
            txt_stock.Text = "0";
            com_famille.ResetText();
            dat_save.Value = DateTime.Now;
            dat_update.Value = DateTime.Now;
            current = new Articles();
            LoadPhoto(null);
        }

        private void Populate(Articles a)
        {
            txt_reference.Text = a.Reference;
            txt_designation.Text = a.Designation;
            txt_marque.Text = a.Marque;
            txt_description.Text = a.Description;
            txt_pua.Text = a.Pua.ToString();
            txt_puv.Text = a.Puv.ToString();
            if (a.Famille != null ? a.Famille.Id > 0 : false)
            {
                com_famille.Text = a.Famille.Designation;
            }
            txt_stock.Text = string.Format("{0:#,##0}", a.Stock);
            dat_save.Value = a.DateSave;
            dat_update.Value = a.DateUpdate;
            current = a;
            LoadPhoto(null);
            LoadPhoto(a);
        }

        private void Recopie()
        {
            current.Reference = txt_reference.Text.Trim();
            current.Designation = txt_designation.Text.Trim();
            current.Description = txt_description.Text.Trim().Replace("'", "''");
            current.Marque = txt_marque.Text.Trim();
            current.Pua = Convert.ToDouble(txt_pua.Text);
            current.Puv = Convert.ToDouble(txt_puv.Text);
            current.DateSave = dat_save.Value;
            current.DateUpdate = DateTime.Now;
        }

        private void LoadPhoto(Articles a)
        {
            if (a != null ? a.Id > 0 : false)
            {
                if (a.Photos != null)
                {
                    string chemin = Chemins.getCheminArticle(a.Id.ToString());
                    if(a.Photos.Count > 0){
                        if (System.IO.File.Exists(chemin + a.Photos[0].Nom))
                        {
                            box_add_1.Image = Image.FromFile(chemin + a.Photos[0].Nom);
                            box_add_1.Tag = true;
                            lk_box_add_1.Visible = true;
                        }
                    }
                    if (a.Photos.Count >1)
                    {
                        if (System.IO.File.Exists(chemin + a.Photos[1].Nom))
                        {
                            box_add_2.Image = Image.FromFile(chemin + a.Photos[1].Nom);
                            box_add_2.Tag = true;
                            lk_box_add_2.Visible = true;
                        }
                    } 
                    if (a.Photos.Count >2)
                    {
                        if (System.IO.File.Exists(chemin + a.Photos[2].Nom))
                        {
                            box_add_3.Image = Image.FromFile(chemin + a.Photos[2].Nom);
                            box_add_3.Tag = true;
                            lk_box_add_3.Visible = true;
                        }
                    }
                    if (a.Photos.Count >3)
                    {
                        if (System.IO.File.Exists(chemin + a.Photos[3].Nom))
                        {
                            box_add_4.Image = Image.FromFile(chemin + a.Photos[3].Nom);
                            box_add_4.Tag = true;
                            lk_box_add_4.Visible = true;
                        }
                    }
                    if (a.Photos.Count >4)
                    {
                        if (System.IO.File.Exists(chemin + a.Photos[4].Nom))
                        {
                            box_add_5.Image = Image.FromFile(chemin + a.Photos[4].Nom);
                            box_add_5.Tag = true;
                            lk_box_add_5.Visible = true;
                        }
                    }
                    if (a.Photos.Count >5)
                    {
                        if (System.IO.File.Exists(chemin + a.Photos[5].Nom))
                        {
                            box_add_6.Image = Image.FromFile(chemin + a.Photos[5].Nom);
                            box_add_6.Tag = true;
                            lk_box_add_6.Visible = true;
                        }
                    }
                    if (a.Photos.Count >6)
                    {
                        if (System.IO.File.Exists(chemin + a.Photos[6].Nom))
                        {
                            box_add_7.Image = Image.FromFile(chemin + a.Photos[6].Nom);
                            box_add_7.Tag = true;
                            lk_box_add_7.Visible = true;
                        }
                    }
                    if (a.Photos.Count >7)
                    {
                        if (System.IO.File.Exists(chemin + a.Photos[7].Nom))
                        {
                            box_add_8.Image = Image.FromFile(chemin + a.Photos[7].Nom);
                            box_add_8.Tag = true;
                            lk_box_add_8.Visible = true;
                        }
                    }
                }
            }
            else
            {
                box_add_1.Image.Dispose();
                box_add_1.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                box_add_1.Tag = false;
                lk_box_add_1.Visible = false;

                box_add_2.Image.Dispose();
                box_add_2.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                box_add_2.Tag = false;
                lk_box_add_2.Visible = false;

                box_add_3.Image.Dispose();
                box_add_3.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                box_add_3.Tag = false;
                lk_box_add_3.Visible = false;

                box_add_4.Image.Dispose();
                box_add_4.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                box_add_4.Tag = false;
                lk_box_add_4.Visible = false;

                box_add_5.Image.Dispose();
                box_add_5.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                box_add_5.Tag = false;
                lk_box_add_5.Visible = false;

                box_add_6.Image.Dispose();
                box_add_6.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                box_add_6.Tag = false;
                lk_box_add_6.Visible = false;

                box_add_7.Image.Dispose();
                box_add_7.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                box_add_7.Tag = false;
                lk_box_add_7.Visible = false;

                box_add_8.Image.Dispose();
                box_add_8.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                box_add_8.Tag = false;
                lk_box_add_8.Visible = false;
            }
        }

        private void dgv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_liste.CurrentRow.Cells["id_"].Value != null)
                {
                    Int32 id = Convert.ToInt32(dgv_liste.CurrentRow.Cells["id_"].Value);
                    if (id > 0)
                    {
                        Articles f = ArticlesBLL.One(id);
                        if (e.ColumnIndex == 7)
                        {
                            if (DialogResult.Yes == Messages.Confirmation("Supprimer"))
                            {
                                LoadPhoto(null);
                                if (ArticlesBLL.Delete(f))
                                {
                                    DeleteRow(f);
                                    Reset();
                                    Messages.Succes();
                                }
                            }
                        }
                        else
                        {
                            Populate(f);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Messages.Exception(ex);
            }
        }

        private void dgv_list_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_liste.Rows.Count > 0)
                {
                    if (dgv_liste.CurrentRow.Cells["id_"].Value != null)
                    {
                        Int32 id = (Int32)dgv_liste.CurrentRow.Cells["id_"].Value;
                        if (id > 0)
                        {
                            Articles f = ArticlesBLL.One(id);
                            Populate(f);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Messages.Exception(ex);
            }
        }

        private void com_famille_SelectedIndexChanged(object sender, EventArgs e)
        {
            FamillesArticle a = com_famille.SelectedItem as FamillesArticle;
            a = familles.Find(x => x.Id == a.Id);
            current.Famille = a;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Recopie();
            if (current.Control())
            {
                if (!current.Update)
                {
                    Articles f = ArticlesBLL.Save(current);
                    if (f != null ? f.Id > 0 : false)
                    {
                        current.Id = f.Id;
                        current.Update = true;
                        AddRow(f);
                        Messages.Succes();
                    }
                }
                else
                {
                    if (ArticlesBLL.Update(current))
                    {
                        UpdateRow(current);
                        Messages.Succes();
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (txt_reference.Text.Trim().Equals(""))
            {
                Reset();
            }
            else
            {
                if (DialogResult.Yes == Messages.Confirmation("Annuler"))
                {
                    Reset();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (current != null ? current.Id > 0 : false)
            {
                if (DialogResult.Yes == Messages.Confirmation("Supprimer"))
                {
                    if (ArticlesBLL.Delete(current))
                    {
                        DeleteRow(current);
                        Reset();
                        Messages.Succes();
                    }
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string search = txt_search.Text.Trim();
            if (search.Length > 0)
            {
                dgv_liste.Rows.Clear();
                string query = "select * from articles where reference like '" + search + "%' or designation like '" + search + "%' or description like '" + search + "%'";
                List<Articles> l = ArticlesBLL.List(query);
                foreach (Articles f in l)
                {
                    AddRow(f);
                }
                Reset();
            }
            else
            {
                LoadGrille();
            }
        }

        private void box_add_1_DoubleClick(object sender, EventArgs e)
        {
            if (current != null ? current.Id > 0 : false)
            {
                bool add = (bool)(((PictureBox)sender).Tag);
                if (!add)
                {
                    OpenFileDialog file = new OpenFileDialog();
                    file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    file.Filter = "Fichiers jpg (*.jpg)|*.jpg|Fichiers png (*.png)|*.png|Fichiers bmp (*.bmp)|*.bmp|Tous les images (*.*)|*.jpg;*.png;*.bmp";
                    if (file.ShowDialog(this) == DialogResult.OK)
                    {
                        string path = file.FileName;
                        if (path != null ? !path.Trim().Equals("") : false)
                        {
                            if (DialogResult.Yes == Messages.Confirmation("Enregistrer"))
                            {
                                PhotosArticle p = PhotosArticleBLL.Save(new PhotosArticle(path, current));
                                if (p != null ? p.Id > 0 : false)
                                {
                                    current.Photos.Add(p);
                                    box_add_1.Image = Image.FromFile(Chemins.getCheminArticle(current.Id.ToString()) + p.Nom);
                                    box_add_1.Tag = true;
                                    lk_box_add_1.Visible = true;
                                    Messages.Succes();
                                }
                            }
                        }
                    }
                }
                else
                {
                    Messages.Information("Vous avez déja associé cette photo");
                }
            }
            else
            {
                Messages.ShowErreur("Vous devez selectionner l'article");
            }
        }

        private void box_add_2_DoubleClick(object sender, EventArgs e)
        {
            if (current != null ? current.Id > 0 : false)
            {
                bool add = (bool)(((PictureBox)sender).Tag);
                if (!add)
                {
                    OpenFileDialog file = new OpenFileDialog();
                    file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    file.Filter = "Fichiers jpg (*.jpg)|*.jpg|Fichiers png (*.png)|*.png|Fichiers bmp (*.bmp)|*.bmp|Tous les images (*.*)|*.jpg;*.png;*.bmp";
                    if (file.ShowDialog(this) == DialogResult.OK)
                    {
                        string path = file.FileName;
                        if (path != null ? !path.Trim().Equals("") : false)
                        {
                            if (DialogResult.Yes == Messages.Confirmation("Enregistrer"))
                            {
                                PhotosArticle p = PhotosArticleBLL.Save(new PhotosArticle(path, current));
                                if (p != null ? p.Id > 0 : false)
                                {
                                    current.Photos.Add(p);
                                    box_add_2.Image = Image.FromFile(Chemins.getCheminArticle(current.Id.ToString()) + p.Nom);
                                    box_add_2.Tag = true;
                                    lk_box_add_2.Visible = true;
                                    Messages.Succes();
                                }
                            }
                        }
                    }
                }
                else
                {
                    Messages.Information("Vous avez déja associé cette photo");
                }
            }
            else
            {
                Messages.ShowErreur("Vous devez selectionner l'article");
            }
        }

        private void box_add_3_DoubleClick(object sender, EventArgs e)
        {
            if (current != null ? current.Id > 0 : false)
            {
                bool add = (bool)(((PictureBox)sender).Tag);
                if (!add)
                {
                    OpenFileDialog file = new OpenFileDialog();
                    file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    file.Filter = "Fichiers jpg (*.jpg)|*.jpg|Fichiers png (*.png)|*.png|Fichiers bmp (*.bmp)|*.bmp|Tous les images (*.*)|*.jpg;*.png;*.bmp";
                    if (file.ShowDialog(this) == DialogResult.OK)
                    {
                        string path = file.FileName;
                        if (path != null ? !path.Trim().Equals("") : false)
                        {
                            if (DialogResult.Yes == Messages.Confirmation("Enregistrer"))
                            {
                                PhotosArticle p = PhotosArticleBLL.Save(new PhotosArticle(path, current));
                                if (p != null ? p.Id > 0 : false)
                                {
                                    current.Photos.Add(p);
                                    box_add_3.Image = Image.FromFile(Chemins.getCheminArticle(current.Id.ToString()) + p.Nom);
                                    box_add_3.Tag = true;
                                    lk_box_add_3.Visible = true;
                                    Messages.Succes();
                                }
                            }
                        }
                    }
                }
                else
                {
                    Messages.Information("Vous avez déja associé cette photo");
                }
            }
            else
            {
                Messages.ShowErreur("Vous devez selectionner l'article");
            }
        }

        private void box_add_4_DoubleClick(object sender, EventArgs e)
        {
            if (current != null ? current.Id > 0 : false)
            {
                bool add = (bool)(((PictureBox)sender).Tag);
                if (!add)
                {
                    OpenFileDialog file = new OpenFileDialog();
                    file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    file.Filter = "Fichiers jpg (*.jpg)|*.jpg|Fichiers png (*.png)|*.png|Fichiers bmp (*.bmp)|*.bmp|Tous les images (*.*)|*.jpg;*.png;*.bmp";
                    if (file.ShowDialog(this) == DialogResult.OK)
                    {
                        string path = file.FileName;
                        if (path != null ? !path.Trim().Equals("") : false)
                        {
                            if (DialogResult.Yes == Messages.Confirmation("Enregistrer"))
                            {
                                PhotosArticle p = PhotosArticleBLL.Save(new PhotosArticle(path, current));
                                if (p != null ? p.Id > 0 : false)
                                {
                                    current.Photos.Add(p);
                                    box_add_4.Image = Image.FromFile(Chemins.getCheminArticle(current.Id.ToString()) + p.Nom);
                                    box_add_4.Tag = true;
                                    lk_box_add_4.Visible = true;
                                    Messages.Succes();
                                }
                            }
                        }
                    }
                }
                else
                {
                    Messages.Information("Vous avez déja associé cette photo");
                }
            }
            else
            {
                Messages.ShowErreur("Vous devez selectionner l'article");
            }
        }

        private void box_add_5_DoubleClick(object sender, EventArgs e)
        {
            if (current != null ? current.Id > 0 : false)
            {
                bool add = (bool)(((PictureBox)sender).Tag);
                if (!add)
                {
                    OpenFileDialog file = new OpenFileDialog();
                    file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    file.Filter = "Fichiers jpg (*.jpg)|*.jpg|Fichiers png (*.png)|*.png|Fichiers bmp (*.bmp)|*.bmp|Tous les images (*.*)|*.jpg;*.png;*.bmp";
                    if (file.ShowDialog(this) == DialogResult.OK)
                    {
                        string path = file.FileName;
                        if (path != null ? !path.Trim().Equals("") : false)
                        {
                            if (DialogResult.Yes == Messages.Confirmation("Enregistrer"))
                            {
                                PhotosArticle p = PhotosArticleBLL.Save(new PhotosArticle(path, current));
                                if (p != null ? p.Id > 0 : false)
                                {
                                    current.Photos.Add(p);
                                    box_add_5.Image = Image.FromFile(Chemins.getCheminArticle(current.Id.ToString()) + p.Nom);
                                    box_add_5.Tag = true;
                                    lk_box_add_5.Visible = true;
                                    Messages.Succes();
                                }
                            }
                        }
                    }
                }
                else
                {
                    Messages.Information("Vous avez déja associé cette photo");
                }
            }
            else
            {
                Messages.ShowErreur("Vous devez selectionner l'article");
            }
        }

        private void box_add_6_DoubleClick(object sender, EventArgs e)
        {
            if (current != null ? current.Id > 0 : false)
            {
                bool add = (bool)(((PictureBox)sender).Tag);
                if (!add)
                {
                    OpenFileDialog file = new OpenFileDialog();
                    file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    file.Filter = "Fichiers jpg (*.jpg)|*.jpg|Fichiers png (*.png)|*.png|Fichiers bmp (*.bmp)|*.bmp|Tous les images (*.*)|*.jpg;*.png;*.bmp";
                    if (file.ShowDialog(this) == DialogResult.OK)
                    {
                        string path = file.FileName;
                        if (path != null ? !path.Trim().Equals("") : false)
                        {
                            if (DialogResult.Yes == Messages.Confirmation("Enregistrer"))
                            {
                                PhotosArticle p = PhotosArticleBLL.Save(new PhotosArticle(path, current));
                                if (p != null ? p.Id > 0 : false)
                                {
                                    current.Photos.Add(p);
                                    box_add_6.Image = Image.FromFile(Chemins.getCheminArticle(current.Id.ToString()) + p.Nom);
                                    box_add_6.Tag = true;
                                    lk_box_add_6.Visible = true;
                                    Messages.Succes();
                                }
                            }
                        }
                    }
                }
                else
                {
                    Messages.Information("Vous avez déja associé cette photo");
                }
            }
            else
            {
                Messages.ShowErreur("Vous devez selectionner l'article");
            }
        }

        private void box_add_7_DoubleClick(object sender, EventArgs e)
        {
            if (current != null ? current.Id > 0 : false)
            {
                bool add = (bool)(((PictureBox)sender).Tag);
                if (!add)
                {
                    OpenFileDialog file = new OpenFileDialog();
                    file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    file.Filter = "Fichiers jpg (*.jpg)|*.jpg|Fichiers png (*.png)|*.png|Fichiers bmp (*.bmp)|*.bmp|Tous les images (*.*)|*.jpg;*.png;*.bmp";
                    if (file.ShowDialog(this) == DialogResult.OK)
                    {
                        string path = file.FileName;
                        if (path != null ? !path.Trim().Equals("") : false)
                        {
                            if (DialogResult.Yes == Messages.Confirmation("Enregistrer"))
                            {
                                PhotosArticle p = PhotosArticleBLL.Save(new PhotosArticle(path, current));
                                if (p != null ? p.Id > 0 : false)
                                {
                                    current.Photos.Add(p);
                                    box_add_7.Image = Image.FromFile(Chemins.getCheminArticle(current.Id.ToString()) + p.Nom);
                                    box_add_7.Tag = true;
                                    lk_box_add_7.Visible = true;
                                    Messages.Succes();
                                }
                            }
                        }
                    }
                }
                else
                {
                    Messages.Information("Vous avez déja associé cette photo");
                }
            }
            else
            {
                Messages.ShowErreur("Vous devez selectionner l'article");
            }
        }

        private void box_add_8_DoubleClick(object sender, EventArgs e)
        {
            if (current != null ? current.Id > 0 : false)
            {
                bool add = (bool)(((PictureBox)sender).Tag);
                if (!add)
                {
                    OpenFileDialog file = new OpenFileDialog();
                    file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    file.Filter = "Fichiers jpg (*.jpg)|*.jpg|Fichiers png (*.png)|*.png|Fichiers bmp (*.bmp)|*.bmp|Tous les images (*.*)|*.jpg;*.png;*.bmp";
                    if (file.ShowDialog(this) == DialogResult.OK)
                    {
                        string path = file.FileName;
                        if (path != null ? !path.Trim().Equals("") : false)
                        {
                            if (DialogResult.Yes == Messages.Confirmation("Enregistrer"))
                            {
                                PhotosArticle p = PhotosArticleBLL.Save(new PhotosArticle(path, current));
                                if (p != null ? p.Id > 0 : false)
                                {
                                    current.Photos.Add(p);
                                    box_add_8.Image = Image.FromFile(Chemins.getCheminArticle(current.Id.ToString()) + p.Nom);
                                    box_add_8.Tag = true;
                                    lk_box_add_8.Visible = true;
                                    Messages.Succes();
                                }
                            }
                        }
                    }
                }
                else
                {
                    Messages.Information("Vous avez déja associé cette photo");
                }
            }
            else
            {
                Messages.ShowErreur("Vous devez selectionner l'article");
            }
        }

        private void lk_box_add_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.Yes == Messages.Confirmation("Confirmer"))
            {
                
                PhotosArticle p = current.Photos[0];
                p.Article = current;
                Image i = box_add_1.Image;
                box_add_1.Image.Dispose();
                if (PhotosArticleBLL.Delete(p))
                {
                    box_add_1.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                    current.Photos.Remove(p);
                    box_add_1.Tag = false;
                    lk_box_add_1.Visible = false;
                    Messages.Succes();
                }
                else
                {
                    box_add_1.Image = i;
                }
            }
        }

        private void lk_box_add_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.Yes == Messages.Confirmation("Confirmer"))
            {

                PhotosArticle p = current.Photos[1];
                p.Article = current;
                Image i = box_add_2.Image;
                box_add_2.Image.Dispose();
                if (PhotosArticleBLL.Delete(p))
                {
                    box_add_2.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                    current.Photos.Remove(p);
                    box_add_2.Tag = false;
                    lk_box_add_2.Visible = false;
                    Messages.Succes();
                }
                else
                {
                    box_add_2.Image = i;
                }
            }
        }

        private void lk_box_add_3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.Yes == Messages.Confirmation("Confirmer"))
            {

                PhotosArticle p = current.Photos[2];
                p.Article = current;
                Image i = box_add_3.Image;
                box_add_3.Image.Dispose();
                if (PhotosArticleBLL.Delete(p))
                {
                    box_add_3.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                    current.Photos.Remove(p);
                    box_add_3.Tag = false;
                    lk_box_add_3.Visible = false;
                    Messages.Succes();
                }
                else
                {
                    box_add_1.Image = i;
                }
            }
        }

        private void lk_box_add_4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.Yes == Messages.Confirmation("Confirmer"))
            {

                PhotosArticle p = current.Photos[3];
                p.Article = current;
                Image i = box_add_4.Image;
                box_add_4.Image.Dispose();
                if (PhotosArticleBLL.Delete(p))
                {
                    box_add_4.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                    current.Photos.Remove(p);
                    box_add_4.Tag = false;
                    lk_box_add_4.Visible = false;
                    Messages.Succes();
                }
                else
                {
                    box_add_4.Image = i;
                }
            }
        }

        private void lk_box_add_6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.Yes == Messages.Confirmation("Confirmer"))
            {

                PhotosArticle p = current.Photos[5];
                p.Article = current;
                Image i = box_add_6.Image;
                box_add_6.Image.Dispose();
                if (PhotosArticleBLL.Delete(p))
                {
                    box_add_6.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                    current.Photos.Remove(p);
                    box_add_6.Tag = false;
                    lk_box_add_6.Visible = false;
                    Messages.Succes();
                }
                else
                {
                    box_add_6.Image = i;
                }
            }
        }

        private void lk_box_add_5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.Yes == Messages.Confirmation("Confirmer"))
            {

                PhotosArticle p = current.Photos[4];
                p.Article = current;
                Image i = box_add_5.Image;
                box_add_5.Image.Dispose();
                if (PhotosArticleBLL.Delete(p))
                {
                    box_add_5.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                    current.Photos.Remove(p);
                    box_add_5.Tag = false;
                    lk_box_add_5.Visible = false;
                    Messages.Succes();
                }
                else
                {
                    box_add_5.Image = i;
                }
            }
        }

        private void lk_box_add_7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.Yes == Messages.Confirmation("Confirmer"))
            {

                PhotosArticle p = current.Photos[6];
                p.Article = current;
                Image i = box_add_7.Image;
                box_add_7.Image.Dispose();
                if (PhotosArticleBLL.Delete(p))
                {
                    box_add_7.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                    current.Photos.Remove(p);
                    box_add_7.Tag = false;
                    lk_box_add_7.Visible = false;
                    Messages.Succes();
                }
                else
                {
                    box_add_7.Image = i;
                }
            }
        }

        private void lk_box_add_8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.Yes == Messages.Confirmation("Confirmer"))
            {

                PhotosArticle p = current.Photos[7];
                p.Article = current;
                Image i = box_add_8.Image;
                box_add_8.Image.Dispose();
                if (PhotosArticleBLL.Delete(p))
                {
                    box_add_8.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                    current.Photos.Remove(p);
                    box_add_8.Tag = false;
                    lk_box_add_8.Visible = false;
                    Messages.Succes();
                }
                else
                {
                    box_add_8.Image = i;
                }
            }
        }
    }
}
