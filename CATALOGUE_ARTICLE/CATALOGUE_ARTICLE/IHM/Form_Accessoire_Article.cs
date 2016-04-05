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
    public partial class Form_Accessoire_Article : Form
    {
        FamillesArticle current = new FamillesArticle();
        List<FamillesArticle> familles = new List<FamillesArticle>();
        Marque current_ = new Marque();

        public Form_Accessoire_Article()
        {
            InitializeComponent();
            Configuration.Load(this);
            var t = "0";
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
            LoadGrille_();
            LoadConfig();
            LoadFamille();
        }

        private void LoadFamille()
        {
            string query = "select * from familles_article order by reference";
            if (current != null ? current.Id > 0 : false)
            {
                query = "select * from familles_article where id != " + current.Id + " order by reference";
            }
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

        private void LoadConfig()
        {
            LoadLangue();
            this.AcceptButton = btn_save;
        }

        private void LoadLangue()
        {
            this.Text = Mots.Accessoire_Article;
            tab_famille.Text = Mots.Famille_Article;
            tab_marque.Text = Mots.Marque_Article;

            grp_action.Text = Mots.Actions;
            grp_infos.Text = Mots.Informations;
            grp_liste.Text = Mots.Liste;
            grp_search.Text = Mots.Recherche;
            lb_reference.Text = Mots.Reference + " :";
            lb_designation.Text = Mots.Designation + " :";
            lb_description.Text = Mots.Description + " :";
            reference_.HeaderText = Mots.Reference;
            description_.HeaderText = Mots.Description;
            designation_.HeaderText = Mots.Designation;

            grp_action1.Text = Mots.Actions;
            grp_infos1.Text = Mots.Informations;
            grp_liste1.Text = Mots.Liste;
            grp_search1.Text = Mots.Recherche;
            lb_reference1.Text = Mots.Reference + " :";
            lb_designation1.Text = Mots.Designation + " :";
            lb_description1.Text = Mots.Description + " :";
            _reference_.HeaderText = Mots.Reference;
            _designation_.HeaderText = Mots.Designation;
            _description_.HeaderText = Mots.Description;
        }

        private void AddRow(FamillesArticle f)
        {
            dgv_liste.Rows.Add(new object[] { f.Id, f.Reference, f.Designation, f.Parent != null ? f.Parent.Designation : "", f.Description, null });
        }

        private void UpdateRow(FamillesArticle f)
        {
            dgv_liste.Rows.RemoveAt(Utils.GetRowData(dgv_liste, f.Id));
            f = FamillesArticleBLL.One(f.Id);
            AddRow(f);
        }

        private void DeleteRow(FamillesArticle f)
        {
            dgv_liste.Rows.RemoveAt(Utils.GetRowData(dgv_liste, f.Id));
        }

        private void AddRow_(Marque f)
        {
            dgv_liste_.Rows.Add(new object[] { f.Id, f.Reference, f.Designation, f.Description, null });
        }

        private void UpdateRow_(Marque f)
        {
            dgv_liste_.Rows.RemoveAt(Utils.GetRowData(dgv_liste_, f.Id));
            AddRow_(f);
        }

        private void DeleteRow_(Marque f)
        {
            dgv_liste_.Rows.RemoveAt(Utils.GetRowData(dgv_liste_, f.Id));
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

        private void LoadGrille_()
        {
            dgv_liste_.Rows.Clear();
            string query = "select * from marque order by id";
            List<Marque> l = MarqueBLL.List(query);
            foreach (Marque f in l)
            {
                AddRow_(f);
            }
            Reset_();
        }

        private void Populate(FamillesArticle f)
        {
            FamillesArticle f_ = FamillesArticleBLL.One(f.Id);
            txt_reference.Text = f_.Reference;
            txt_designation.Text = f_.Designation;
            txt_description.Text = f_.Description;
            current = f;
            LoadFamille();
            if (f_.Parent != null ? f_.Parent.Id > 0 : false)
            {
                com_parent.Text = f_.Parent.Designation;
                current.Parent = f_.Parent;
            }
            else
            {
                com_parent.ResetText();
                current.Parent = null;
            }
        }

        private void Populate_(Marque f)
        {
            txt_reference_.Text = f.Reference;
            txt_designation_.Text = f.Designation;
            txt_description_.Text = f.Description;
            current_ = f;
        }

        private void Recopie()
        {
            current.Reference = txt_reference.Text.Trim();
            current.Designation = txt_designation.Text.Trim();
            current.Description = txt_description.Text.Trim().Replace("'", "''");
        }

        private void Recopie_()
        {
            current_.Reference = txt_reference_.Text.Trim();
            current_.Designation = txt_designation_.Text.Trim();
            current_.Description = txt_description_.Text.Trim().Replace("'", "''");
        }

        private void Reset()
        {
            txt_reference.ResetText();
            txt_designation.ResetText();
            txt_description.ResetText();
            com_parent.ResetText();
            current = new FamillesArticle();
            LoadFamille();
        }

        private void Reset_()
        {
            txt_reference_.ResetText();
            txt_designation_.ResetText();
            txt_description_.ResetText();
            current_ = new Marque();
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
                Reset();
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
                if (DialogResult.Yes == Messages.Confirmation(Mots.Annuler.ToLower()))
                {
                    Reset();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (current != null ? current.Id > 0 : false)
            {
                if (DialogResult.Yes == Messages.Confirmation(Mots.Supprimer.ToLower()))
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
                        if (e.ColumnIndex == 5)
                        {
                            if (DialogResult.Yes == Messages.Confirmation(Mots.Supprimer.ToLower()))
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
            dgv_liste.Rows.Clear();
            string query = "select * from familles_article where reference like '" + search + "%' or designation like '" + search + "%' or description like '" + search + "%'";
            List<FamillesArticle> l = FamillesArticleBLL.List(query);
            foreach (FamillesArticle f in l)
            {
                AddRow(f);
            }
            Reset();
        }

        private void txt_description_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void txt_description_Leave(object sender, EventArgs e)
        {
            this.AcceptButton = btn_save;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                this.AcceptButton = btn_save;
                Reset();
            }
            else
            {
                this.AcceptButton = btn_save_;
                Reset_();
            }
        }

        private void btn_save__Click(object sender, EventArgs e)
        {
            Recopie_();
            if (current_.Control())
            {
                if (!current_.Update)
                {
                    Marque f = MarqueBLL.Save(current_);
                    if (f != null ? f.Id > 0 : false)
                    {
                        current_.Id = f.Id;
                        current_.Update = true;
                        AddRow_(f);
                        Messages.Succes();
                    }
                }
                else
                {
                    if (MarqueBLL.Update(current_))
                    {
                        UpdateRow_(current_);
                        Messages.Succes();
                    }
                }
                Reset_();
            }
        }

        private void btn_cancel__Click(object sender, EventArgs e)
        {
            if (txt_reference_.Text.Trim().Equals(""))
            {
                Reset_();
            }
            else
            {
                if (DialogResult.Yes == Messages.Confirmation(Mots.Annuler.ToLower()))
                {
                    Reset_();
                }
            }
        }

        private void btn_delete__Click(object sender, EventArgs e)
        {
            if (current_ != null ? current_.Id > 0 : false)
            {
                if (DialogResult.Yes == Messages.Confirmation(Mots.Supprimer.ToLower()))
                {
                    if (MarqueBLL.Delete(current_))
                    {
                        DeleteRow_(current_);
                        Reset_();
                        Messages.Succes();
                    }
                }
            }
        }

        private void dgv_liste__CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_liste_.CurrentRow.Cells["_id_"].Value != null)
                {
                    Int32 id = Convert.ToInt32(dgv_liste_.CurrentRow.Cells["_id_"].Value);
                    if (id > 0)
                    {
                        Marque f = MarqueBLL.One(id);
                        if (e.ColumnIndex == 4)
                        {
                            if (DialogResult.Yes == Messages.Confirmation(Mots.Supprimer.ToLower()))
                            {
                                if (MarqueBLL.Delete(f))
                                {
                                    DeleteRow_(f);
                                    Reset_();
                                    Messages.Succes();
                                }
                            }
                        }
                        else
                        {
                            Populate_(f);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Messages.Exception(ex);
            }
        }

        private void dgv_liste__SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_liste_.Rows.Count > 0)
                {
                    if (dgv_liste_.CurrentRow.Cells["_id_"].Value != null)
                    {
                        Int32 id = (Int32)dgv_liste_.CurrentRow.Cells["_id_"].Value;
                        if (id > 0)
                        {
                            Marque f = MarqueBLL.One(id);
                            Populate_(f);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Messages.Exception(ex);
            }
        }

        private void txt_search__TextChanged(object sender, EventArgs e)
        {
            string search = txt_search_.Text.Trim();
            dgv_liste_.Rows.Clear();
            string query = "select * from marque where reference like '" + search + "%' or designation like '" + search + "%' or description like '" + search + "%'";
            List<Marque> l = MarqueBLL.List(query);
            foreach (Marque f in l)
            {
                AddRow_(f);
            }
            Reset_();
        }

        private void com_parent_SelectedIndexChanged(object sender, EventArgs e)
        {
            FamillesArticle a = com_parent.SelectedItem as FamillesArticle;
            a = familles.Find(x => x.Id == a.Id);
            current.Parent = a;
        }

        private void txt_description__Enter(object sender, EventArgs e)
        {
            this.AcceptButton = null;
        }

        private void txt_description__Leave(object sender, EventArgs e)
        {
            this.AcceptButton = btn_save_;
        }
    }
}
