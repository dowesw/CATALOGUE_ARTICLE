using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using CATALOGUE_ARTICLE.BLL;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.IHM
{
    public partial class Form_Setting : Form
    {
        NiveauAcces current = new NiveauAcces();
        Serveur serveur = new Serveur();

        public Form_Setting()
        {
            InitializeComponent();
        }

        private void Form_Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Constantes.f_setting = null;
            Constantes.f_last = "Setting";
        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {
            LoadGrille();
            LoadServeur();
        }

        private void ResetServeur()
        {
            txt_adresse.Text = "127.0.0.1";
            txt_database.Text = "catalogue_article";
            txt_password.Text = "yves1910/";
            txt_port.Text = "5432";
            txt_users.Text = "postgres";
        }

        private void Reset()
        {
            txt_description.ResetText();
            txt_designation.ResetText();
            current = new NiveauAcces();
        }

        private void RecopieServeur()
        {
            serveur.Adresse = txt_adresse.Text.Trim();
            serveur.Database = txt_database.Text.Trim();
            serveur.Password = txt_password.Text.Trim();
            try
            {
                serveur.Port = Convert.ToInt32(txt_port.Text.Trim());
            }
            catch (Exception ex)
            {
                Messages.ShowErreur("Le port est une valeur numerique");
                serveur.Port = 5432;
            }
            serveur.User = txt_users.Text.Trim();
        }

        private void Recopie(){
            current.Description = txt_description.Text.Trim().Replace("'", "''");
            current.Designation = txt_designation.Text.Trim();
        }

        private void PopulateServeur(Serveur s)
        {
            txt_adresse.Text = s.Adresse;
            txt_database.Text = s.Database;
            txt_password.Text = s.Password;
            txt_port.Text = s.Port.ToString();
            txt_users.Text = s.User;
        }

        private void Populate(NiveauAcces y)
        {
            txt_designation.Text = y.Designation;
            txt_description.Text = y.Description;
            current = y;
        }

        private void AddRow(NiveauAcces y)
        {
            dgv_liste.Rows.Add(new object[] { y.Id, y.Designation, y.Description, null });
        }

        private void UpdateRow(NiveauAcces f)
        {
            dgv_liste.Rows.RemoveAt(Utils.GetRowData(dgv_liste, f.Id));
            AddRow(f);
        }

        private void DeleteRow(NiveauAcces f)
        {
            dgv_liste.Rows.RemoveAt(Utils.GetRowData(dgv_liste, f.Id));
        }

        private void LoadServeur()
        {
            Serveur s = ServeurBLL.ReturnServeur();
            if (s != null)
            {
                PopulateServeur(s);
            }
        }

        private void LoadGrille()
        {
            dgv_liste.Rows.Clear();
            string query = "select * from niveau_acces where super = false order by id";
            List<NiveauAcces> l = NiveauAccesBLL.List(query);
            foreach (NiveauAcces n in l)
            {
                AddRow(n);
            }
            Reset();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Recopie();
            if (current.Control())
            {
                if (!current.Update)
                {
                    NiveauAcces f = NiveauAccesBLL.Save(current);
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
                    if (NiveauAccesBLL.Update(current))
                    {
                        UpdateRow(current);
                        Messages.Succes();
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (txt_designation.Text.Trim().Equals(""))
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
                    if (NiveauAccesBLL.Delete(current))
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
                string query = "select * from niveau_acces where designation like '" + search + "%' or description like '" + search + "%'";
                List<NiveauAcces> l = NiveauAccesBLL.List(query);
                foreach (NiveauAcces f in l)
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

        private void dgv_liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_liste.CurrentRow.Cells["id_"].Value != null)
                {
                    Int32 id = Convert.ToInt32(dgv_liste.CurrentRow.Cells["id_"].Value);
                    if (id > 0)
                    {
                        NiveauAcces f = NiveauAccesBLL.One(id);
                        if (e.ColumnIndex == 3)
                        {
                            if (DialogResult.Yes == Messages.Confirmation("Supprimer"))
                            {
                                if (NiveauAccesBLL.Delete(f))
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
                            NiveauAcces f = NiveauAccesBLL.One(id);
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

        private void btn_reset_serveur_Click(object sender, EventArgs e)
        {
            if (txt_adresse.Text.Trim().Equals(""))
            {
                ResetServeur();
            }
            else
            {
                if (DialogResult.Yes == Messages.Confirmation("Annuler"))
                {
                    ResetServeur();
                }
            }
        }

        private void btn_save_serveur_Click(object sender, EventArgs e)
        {
            RecopieServeur();
            if (serveur.Control())
            {
                if (ServeurBLL.CreateServeur(serveur))
                {
                    Messages.Succes();
                }
            }
        }
    }
}
