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
    public partial class Form_Famille : Form
    {
        FamillesArticle current = new FamillesArticle();

        public Form_Famille()
        {
            InitializeComponent();
        }

        private void Form_Famille_FormClosed(object sender, FormClosedEventArgs e)
        {
            Constantes.f_famille = null;
            Constantes.f_last = "Familles";
            Utils.removeFrom(this.Name);
        }

        private void Form_Famille_Load(object sender, EventArgs e)
        {
            Utils.addFrom(this.Name);
            LoadGrille();
        }

        private void AddRow(FamillesArticle f)
        {
            dgv_liste.Rows.Add(new object[] { f.Id, f.Reference, f.Designation, f.Description, null });
        }

        private void UpdateRow(FamillesArticle f)
        {
            dgv_liste.Rows.RemoveAt(Utils.GetRowData(dgv_liste, f.Id));
            AddRow(f);
        }

        private void DeleteRow(FamillesArticle f)
        {
            dgv_liste.Rows.RemoveAt(Utils.GetRowData(dgv_liste, f.Id));
        }

        private void LoadGrille()
        {
            dgv_liste.Rows.Clear();
            string query = "select * from familles_article order by id";
            List<FamillesArticle> l = FamillesArticleBLL.List(query);
            foreach (FamillesArticle f in l)
            {
                AddRow(f);
            }
            Reset();
        }

        private void Populate(FamillesArticle f)
        {
            txt_reference.Text = f.Reference;
            txt_designation.Text = f.Designation;
            txt_description.Text = f.Description;
            current = f;
        }

        private void Recopie()
        {
            current.Reference = txt_reference.Text.Trim();
            current.Designation = txt_designation.Text.Trim().Replace("'","''");
            current.Description = txt_description.Text.Trim();
        }

        private void Reset()
        {
            txt_reference.ResetText();
            txt_designation.ResetText();
            txt_description.ResetText();
            current = new FamillesArticle();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Recopie();
            if (current.Control())
            {
                if (!current.Update)
                {
                    FamillesArticle f = FamillesArticleBLL.Save(current);
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
                    if (FamillesArticleBLL.Update(current))
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
                    if (FamillesArticleBLL.Delete(current))
                    {
                        DeleteRow(current);
                        Reset();
                        Messages.Succes();
                    }
                }
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
                            FamillesArticle f = FamillesArticleBLL.One(id);
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

        private void dgv_liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_liste.CurrentRow.Cells["id_"].Value != null)
                {
                    Int32 id =Convert.ToInt32(dgv_liste.CurrentRow.Cells["id_"].Value);
                    if (id>0)
                    {
                        FamillesArticle f = FamillesArticleBLL.One(id);
                        if (e.ColumnIndex == 4)
                        {
                                if (DialogResult.Yes == Messages.Confirmation("Supprimer"))
                                {
                                    if (FamillesArticleBLL.Delete(f))
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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string search = txt_search.Text.Trim();
            if (search.Length > 0)
            {
                dgv_liste.Rows.Clear();
                string query = "select * from familles_article where reference like '" + search + "%' or designation like '" + search + "%' or description like '" + search + "%'";
                List<FamillesArticle> l = FamillesArticleBLL.List(query);
                foreach (FamillesArticle f in l)
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


    }
}
