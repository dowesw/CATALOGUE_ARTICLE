using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CATALOGUE_ARTICLE.BLL;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.IHM
{
    public partial class Form_Setting : Form
    {
        NiveauAcces current = new NiveauAcces();

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
        }

        private void Reset()
        {
            txt_description.ResetText();
            txt_designation.ResetText();
            current = new NiveauAcces();
        }

        private void Recopie(){
            current.Description = txt_description.Text.Trim().Replace("'", "''");
            current.Designation = txt_designation.Text.Trim();
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

        private void LoadGrille()
        {
            dgv_liste.Rows.Clear();
            string query = "select * from niveau_acces order by id";
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
    }
}
