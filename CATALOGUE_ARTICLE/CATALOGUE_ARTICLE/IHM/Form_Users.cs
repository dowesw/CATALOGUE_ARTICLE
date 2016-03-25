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
    public partial class Form_Users : Form
    {
        Users current = new Users();
        List<NiveauAcces> niveaux = new List<NiveauAcces>();

        public Form_Users()
        {
            InitializeComponent();
        }

        private void Form_Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            Constantes.f_users = null;
            Constantes.f_last = "Users";
        }

        private void Form_Users_Load(object sender, EventArgs e)
        {
            LoadAllNiveau();
            LoadGrille();
        }

        private void Reset()
        {
            txt_identifiant.ResetText();
            txt_nom.ResetText();
            txt_password.ResetText();
            txt_prenom.ResetText();
            txt_repassword.ResetText();
            chk_actif.Checked = false;
            com_niveau.Text = "";
            current = new Users();
            LoadPhoto(null);
        }

        private void LoadPhoto(Users u)
        {
            if (u != null ? u.Id > 0 : false)
            {
                if (!(u.Photo == null || u.Photo.Trim().Equals("")))
                {
                    string chemin = Chemins.getCheminUsers(u.Id.ToString());
                    if (System.IO.File.Exists(chemin + u.Photo))
                    {
                        box_photo.Image = Image.FromFile(chemin + u.Photo);
                        box_photo.Tag = true;
                        lk_box_photo.Visible = true;
                        return;
                    }
                }
            }
            box_photo.Image.Dispose();
            box_photo.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
            box_photo.Tag = false;
            lk_box_photo.Visible = false;
        }

        private void Recopie()
        {
            current.Actif = chk_actif.Checked;
            current.Identifiant = txt_identifiant.Text.Trim();
            current.Nom = txt_nom.Text.Trim();
            current.Password = txt_password.Text.Trim();
            current.Prenom = txt_prenom.Text.Trim();
            current.Repassword = txt_repassword.Text.Trim();
        }

        private void Populate(Users u)
        {
            txt_repassword.Text = u.Repassword;
            txt_prenom.Text = u.Prenom;
            txt_password.Text = u.Password;
            txt_nom.Text = u.Nom;
            txt_identifiant.Text = u.Identifiant;
            chk_actif.Checked = u.Actif;
            com_niveau.Text = u.Niveau != null ? u.Niveau.Designation : "";
            current = u;
            LoadPhoto(u);
        }

        private void AddRow(Users a)
        {
            dgv_liste.Rows.Add(new object[] { a.Id, a.Nom, a.Prenom, a.Niveau != null ? a.Niveau.Designation : "", a.Actif, null });
        }

        private void UpdateRow(Users a)
        {
            dgv_liste.Rows.RemoveAt(Utils.GetRowData(dgv_liste, a.Id));
            AddRow(a);
        }

        private void DeleteRow(Users a)
        {
            dgv_liste.Rows.RemoveAt(Utils.GetRowData(dgv_liste, a.Id));
        }

        private void LoadGrille()
        {
            dgv_liste.Rows.Clear();
            string query = "select * from users order by id";
            List<Users> l = UsersBLL.List(query);
            foreach (Users a in l)
            {
                AddRow(a);
            }
            Reset();
        }

        private void LoadAllNiveau()
        {
            niveaux.Clear();
            string query = "select * from niveau_acces order by id";
            niveaux = NiveauAccesBLL.List(query);
            com_niveau.DisplayMember = "Designation";
            com_niveau.ValueMember = "Id";
            com_niveau.DataSource = new BindingSource(niveaux, null);

            foreach (NiveauAcces f in niveaux)
            {
                com_niveau.AutoCompleteCustomSource.Add(f.Designation);
            }
            com_niveau.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            com_niveau.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Recopie();
            if (current.Control())
            {
                if (!current.Update)
                {
                    Users f = UsersBLL.Save(current);
                    if (f != null ? f.Id > 0 : false)
                    {
                        current.Id = f.Id;
                        current.Update = true;
                        AddRow(f);
                        if (!(current.Photo == null || current.Photo.Trim().Equals("")))
                        {
                            box_photo.Tag = true;
                            lk_box_photo.Visible = true;
                        }
                                    
                        Messages.Succes();
                    }
                }
                else
                {
                    if (UsersBLL.Update(current))
                    {
                        UpdateRow(current);
                        Messages.Succes();
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text.Trim().Equals(""))
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
                    if (UsersBLL.Delete(current))
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
                string query = "select * from users where nom like '" + search + "%' or prenom like '" + search + "%' or identifiant like '" + search + "%'";
                List<Users> l = UsersBLL.List(query);
                foreach (Users f in l)
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

        private void box_photo_DoubleClick(object sender, EventArgs e)
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
                        current.Photo = path;
                        if (current != null ? current.Id > 0 : false)
                        {
                            if (DialogResult.Yes == Messages.Confirmation("Enregistrer"))
                            {
                                if (UsersBLL.UpdatePhoto(current))
                                {
                                    var t = current.Photo;
                                    box_photo.Image = Image.FromFile(Chemins.getCheminUsers(current.Id.ToString()) + current.Photo);
                                    box_photo.Tag = true;
                                    lk_box_photo.Visible = true;
                                    Messages.Succes();
                                }
                            }
                        }
                        else
                        {
                            box_photo.Image = Image.FromFile(current.Photo);
                        }
                    }
                }
            }
            else
            {
                Messages.Information("Vous avez déja associé cette photo");
            }
        }

        private void lk_box_photo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DialogResult.Yes == Messages.Confirmation("Confirmer"))
            {
                //Image i = box_photo.Image;
                box_photo.Image.Dispose();
                box_photo.Image = null;
                if (UsersBLL.DeletePhoto(current))
                {
                    box_photo.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                    current.Photo = "";
                    box_photo.Tag = false;
                    lk_box_photo.Visible = false;
                    Messages.Succes();
                }
                else
                {
                    //box_photo.Image = i;
                }
            }
        }

        private void dgv_liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_liste.CurrentRow.Cells["id_"].Value != null)
                {
                    Int32 id = Convert.ToInt32(dgv_liste.CurrentRow.Cells["id_"].Value);
                    if (id > 0)
                    {
                        Users f = UsersBLL.One(id);
                        if (e.ColumnIndex == 5)
                        {
                            if (DialogResult.Yes == Messages.Confirmation("Supprimer"))
                            {
                                LoadPhoto(null);
                                if (UsersBLL.Delete(f))
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

        private void dgv_liste_SelectionChanged(object sender, EventArgs e)
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
                            Users f = UsersBLL.One(id);
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

        private void com_niveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            NiveauAcces a = com_niveau.SelectedItem as NiveauAcces;
            a = niveaux.Find(x => x.Id == a.Id);
            current.Niveau = a;
        }


    }
}
