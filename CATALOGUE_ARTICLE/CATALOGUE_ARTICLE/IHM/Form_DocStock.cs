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
    public partial class Form_DocStock : Form
    {
        DocStock current = new DocStock();
        ContenuStock current_contenu = new ContenuStock();
        List<Articles> articles = new List<Articles>();

        public Form_DocStock()
        {
            InitializeComponent();
        }

        private void Form_DocStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            Constantes.f_docstock = null;
            Constantes.f_last = "Stock";
        }

        private void Form_DocStock_Load(object sender, EventArgs e)
        {
            LoadAllArticles();
            LoadGrille();
        }

        private void LoadAllArticles()
        {
            articles.Clear();
            string query = "select * from articles order by id";
            articles = ArticlesBLL.List(query);
            com_article.DisplayMember = "Designation";
            com_article.ValueMember = "Id";
            com_article.DataSource = new BindingSource(articles, null);

            foreach (Articles f in articles)
            {
                com_article.AutoCompleteCustomSource.Add(f.Designation);
            }
            com_article.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            com_article.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void AddRow(DocStock f)
        {
            dgv_liste.Rows.Add(new object[] { f.Id, f.Icon, f.Reference, f.Date, f.Type.ToString(), null });
        }

        private void UpdateRow(DocStock f)
        {
            dgv_liste.Rows.RemoveAt(Utils.GetRowData(dgv_liste, f.Id));
            AddRow(f);
        }

        private void DeleteRow(DocStock f)
        {
            dgv_liste.Rows.RemoveAt(Utils.GetRowData(dgv_liste, f.Id));
        }

        private void AddRowContenu(ContenuStock f)
        {
            dgv_contenu.Rows.Add(new object[] { f.Id, f.Article.Designation, f.Quantite, f.Prix, null });
        }

        private void UpdateRowContenu(ContenuStock f)
        {
            dgv_contenu.Rows.RemoveAt(Utils.GetRowData(dgv_contenu, f.Id));
            AddRowContenu(f);
        }

        private void DeleteRowContenu(ContenuStock f)
        {
            dgv_contenu.Rows.RemoveAt(Utils.GetRowData(dgv_contenu, f.Id));
        }

        private void LoadGrille()
        {
            dgv_liste.Rows.Clear();
            string query = "select * from doc_stocks order by id";
            List<DocStock> l = DocStockBLL.List(query);
            foreach (DocStock d in l)
            {
                AddRow(d);
            }
            Reset();
        }

        private void LoadGrilleContenu(DocStock d)
        {
            dgv_contenu.Rows.Clear();
            string query = "select * from contenu_stock where stock = " + d.Id + " order by id";
            current.Contenus = ContenuStockBLL.List(query);
            foreach (ContenuStock c in current.Contenus)
            {
                AddRowContenu(c);
            }
            ResetContenu();
        }

        private void Reset()
        {
            txt_reference.Text = Utils.ReferenceElement(Constantes.MOUV_ENTREE);
            rbtn_entree.Checked = true;
            date_save.Value = DateTime.Now;
            rbtn_entree.Enabled = true;
            rbtn_sortie.Enabled = true;
            current = new DocStock();
            dgv_contenu.Rows.Clear();
            ResetContenu();
        }

        private void ResetContenu()
        {
            com_article.Text = null;
            txt_prix.Value = 0;
            txt_qte.Value = 1;
            com_article.Enabled = true;
            current_contenu = new ContenuStock();
        }

        private void Recopie()
        {
            current.Reference = txt_reference.Text.Trim();
            current.Date = date_save.Value;
        }

        private void RecopieContenu()
        {
            current_contenu.Prix = Convert.ToDouble(txt_prix.Value);
            current_contenu.Quantite = Convert.ToDouble(txt_qte.Value);
            current_contenu.Stock = current;
        }

        private void Populate(DocStock d)
        {
            rbtn_entree.Checked = d.Type.Trim().Equals(Constantes.MOUV_ENTREE);
            rbtn_sortie.Checked = d.Type.Trim().Equals(Constantes.MOUV_SORTIE);
            rbtn_entree.Enabled = false;
            rbtn_sortie.Enabled = false;
            txt_reference.Text = d.Reference;
            date_save.Value = d.Date;
            current = d;
            LoadGrilleContenu(d);
        }

        private void PopulateContenu(ContenuStock c)
        {
            com_article.Text = c.Article.Designation;
            txt_prix.Value = Convert.ToDecimal(c.Prix);
            txt_qte.Value = Convert.ToDecimal(c.Quantite);
            com_article.Enabled = false;
            current_contenu = c;
        }

        private void rbtn_sortie_CheckedChanged(object sender, EventArgs e)
        {
            current.Type = Constantes.MOUV_SORTIE;
            txt_reference.Text = Utils.ReferenceElement(Constantes.MOUV_SORTIE);
        }

        private void rbtn_entree_CheckedChanged(object sender, EventArgs e)
        {
            current.Type = Constantes.MOUV_ENTREE;
            txt_reference.Text = Utils.ReferenceElement(Constantes.MOUV_ENTREE);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Recopie();
            if (current.Control())
            {
                if (!current.Update)
                {
                    DocStock f = DocStockBLL.Save(current);
                    if (f != null ? f.Id > 0 : false)
                    {
                        current.Id = f.Id;
                        current.Update = true;
                        rbtn_entree.Enabled = false;
                        rbtn_sortie.Enabled = false;
                        AddRow(f);
                        Messages.Succes();
                    }
                }
                else
                {
                    if (DocStockBLL.Update(current))
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
                    if (DocStockBLL.Delete(current))
                    {
                        DeleteRow(current);
                        Reset();
                        Messages.Succes();
                    }
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            RecopieContenu();
            if (current_contenu.Control())
            {
                if (!current_contenu.Update)
                {
                    ContenuStock f = ContenuStockBLL.Save(current_contenu);
                    if (f != null ? f.Id > 0 : false)
                    {
                        current.Id = f.Id;
                        current.Update = true;
                        AddRowContenu(f);
                        Messages.Succes();
                        ResetContenu();
                    }
                }
                else
                {
                    if (ContenuStockBLL.Update(current_contenu))
                    {
                        UpdateRowContenu(current_contenu);
                        Messages.Succes();
                        ResetContenu();
                    }
                }
            }
        }

        private void com_article_SelectedIndexChanged(object sender, EventArgs e)
        {
            Articles a = com_article.SelectedItem as Articles;
            a = articles.Find(x => x.Id == (a != null ? a.Id : 0));
            current_contenu.Article = a;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string search = txt_search.Text.Trim();
            if (search.Length > 0)
            {
                dgv_liste.Rows.Clear();
                string query = "select * from doc_stocks where reference like '" + search + "%'";
                List<DocStock> l = DocStockBLL.List(query);
                foreach (DocStock f in l)
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

        private void txt_search_art_TextChanged(object sender, EventArgs e)
        {
            string search = txt_search_art.Text.Trim();
            if (search.Length > 0)
            {
                dgv_contenu.Rows.Clear();
                string query = "select c.* from contenu_stock c inner join articles a on c.article = a.id where a.reference like '" + search + "%' or a.designation like '" + search + "%' and c.stock = " + current.Id;
                List<ContenuStock> l = ContenuStockBLL.List(query);
                foreach (ContenuStock f in l)
                {
                    AddRowContenu(f);
                }
                ResetContenu();
            }
            else
            {
                LoadGrilleContenu(current);
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
                        DocStock f = DocStockBLL.One(id);
                        if (e.ColumnIndex == 5)
                        {
                            if (DialogResult.Yes == Messages.Confirmation("Supprimer"))
                            {
                                if (DocStockBLL.Delete(f))
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
                            DocStock f = DocStockBLL.One(id);
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

        private void dgv_contenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_contenu.CurrentRow.Cells["_id_"].Value != null)
                {
                    Int32 id = Convert.ToInt32(dgv_contenu.CurrentRow.Cells["_id_"].Value);
                    if (id > 0)
                    {
                        ContenuStock f = ContenuStockBLL.One(id);
                        if (e.ColumnIndex == 4)
                        {
                            if (DialogResult.Yes == Messages.Confirmation("Supprimer"))
                            {
                                if (ContenuStockBLL.Delete(f))
                                {
                                    DeleteRowContenu(f);
                                    ResetContenu();
                                    Messages.Succes();
                                }
                            }
                        }
                        else
                        {
                            PopulateContenu(f);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Messages.Exception(ex);
            }
        }

        private void dgv_contenu_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_contenu.Rows.Count > 0)
                {
                    if (dgv_contenu.CurrentRow.Cells["_id_"].Value != null)
                    {
                        Int32 id = (Int32)dgv_contenu.CurrentRow.Cells["_id_"].Value;
                        if (id > 0)
                        {
                            ContenuStock f = ContenuStockBLL.One(id);
                            PopulateContenu(f);
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
