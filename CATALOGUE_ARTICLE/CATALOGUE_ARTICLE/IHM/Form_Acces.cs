using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using CATALOGUE_ARTICLE.TOOLS;
using CATALOGUE_ARTICLE.BLL;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.IHM
{
    public partial class Form_Acces : Form
    {
        public NiveauAcces current = new NiveauAcces();
        public List<NiveauAcces> niveaux = new List<NiveauAcces>();

        bool first;

        public Form_Acces()
        {
            InitializeComponent();
            Configuration.Load(this);
        }

        private void Form_Acces_FormClosed(object sender, FormClosedEventArgs e)
        {
            Constantes.f_acces = null;
            Constantes.f_last = "Acces";
        }

        private void Form_Acces_Load(object sender, EventArgs e)
        {
            LoadAllNiveau();
            com_niveau.Text = "";
            first = true;
            LoadConfig();
        }

        private void LoadConfig()
        {
            this.Text = Mots.Autorisation;
            lb_niveau.Text = Mots.Niveau;
            code_form_.HeaderText = Mots.Code;
            code_ress_.HeaderText = Mots.Code;
            nom_form_.HeaderText = Mots.Libelle;
            nom_ress_.HeaderText = Mots.Libelle;
            acces_form_.HeaderText = Mots.Acces;
            acces_ress_.HeaderText = Mots.Acces;
            tab_form.Text = Mots.Formulaire;
            tab_ress.Text = Mots.Ressource;
        }

        private void LoadAllNiveau()
        {
            niveaux.Clear();
            string query = "select * from niveau_acces where super = false order by id";
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

        public void com_niveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            NiveauAcces a = com_niveau.SelectedItem as NiveauAcces;
            a = niveaux.Find(x => x.Id == a.Id);
            current = a;
            if (first)
            {
                LoadFormulaire(a);
            }
        }

        private void AddRowFormulaire(Formulaires f)
        {
            dgv_form.Rows.Add(new object[] { f.Id, f.Code, f.Libelle, f.Update });
        }

        private void AddRowRessource(Ressources f)
        {
            dgv_ress.Rows.Add(new object[] { f.Id, f.Code, f.Libelle, f.Update });
        }

        private void LoadFormulaire(NiveauAcces n)
        {
            dgv_form.Rows.Clear();
            string query = "select * from formulaires order by code";
            List<Formulaires> l = FormulairesBLL.List(query);
            foreach (Formulaires f in l)
            {
                f.Update = AutorisationFormulaireBLL.One(AutorisationFormulaireBLL.Current(new AutorisationFormulaire(n, f))).Update;
                AddRowFormulaire(f);
            }
        }

        private void LoadRessource(NiveauAcces n, Formulaires f)
        {
            dgv_ress.Rows.Clear();
            string query = "select * from ressources where formulaire = " + f.Id + " order by code";
            List<Ressources> l = RessourcesBLL.List(query);
            foreach (Ressources r in l)
            {
                r.Update = AutorisationRessourceBLL.One(AutorisationRessourceBLL.Current(new AutorisationRessource(n, r))).Update;
                AddRowRessource(r);
            }
        }

        private void dgv_form_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_form.Rows.Count > 0)
                {
                    if (dgv_form.CurrentRow.Cells["id_form_"].Value != null)
                    {
                        Int32 id = (Int32)dgv_form.CurrentRow.Cells["id_form_"].Value;
                        if (id > 0)
                        {
                            Formulaires f = FormulairesBLL.One(id);
                            LoadRessource(current, f);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Messages.Exception(ex);
            }
        }

        private void dgv_form_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_form.Rows.Count > 0)
                {
                    if (dgv_form.CurrentRow.Cells["id_form_"].Value != null)
                    {
                        Int32 id = (Int32)dgv_form.CurrentRow.Cells["id_form_"].Value;
                        if (id > 0)
                        {
                            Formulaires f = new Formulaires(id);
                            bool b = (bool)dgv_form.CurrentRow.Cells[e.ColumnIndex].Value;
                            AutorisationFormulaire a = AutorisationFormulaireBLL.One(AutorisationFormulaireBLL.Current(new AutorisationFormulaire(current, f, b)));
                            if (a != null ? a.Id > 0 : false)
                            {
                                AutorisationFormulaireBLL.Update(new AutorisationFormulaire(a.Id, current, f, b));
                            }
                            else
                            {
                                AutorisationFormulaireBLL.Save(new AutorisationFormulaire(current, f, b));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Messages.Exception(ex);
            }
        }

        private void dgv_ress_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_ress.Rows.Count > 0)
                {
                    if (dgv_ress.CurrentRow.Cells["id_ress_"].Value != null)
                    {
                        Int32 id = (Int32)dgv_ress.CurrentRow.Cells["id_ress_"].Value;
                        if (id > 0)
                        {
                            Ressources r = new Ressources(id);
                            bool b = (bool)dgv_ress.CurrentRow.Cells[e.ColumnIndex].Value;
                            AutorisationRessource a = AutorisationRessourceBLL.One(AutorisationRessourceBLL.Current(new AutorisationRessource(current, r, b)));
                            if (a != null ? a.Id > 0 : false)
                            {
                                AutorisationRessourceBLL.Update(new AutorisationRessource(a.Id, current, r, b));
                            }
                            else
                            {
                                AutorisationRessourceBLL.Save(new AutorisationRessource(current, r, b));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Messages.Exception(ex);
            }
        }

        private void btn_add_niveau_Click(object sender, EventArgs e)
        {
            new _2ND.Form_Save_Niveau(this).ShowDialog();
        }
    }
}
