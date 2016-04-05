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
    public partial class Form_Mouvement : Form
    {
        public Form_Mouvement()
        {
            InitializeComponent();
            Configuration.Load(this);
        }

        private void Form_Mouvement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Constantes.f_mouvement = null;
            Constantes.f_last = "Mouvement";
        }

        private void Form_Mouvement_Load(object sender, EventArgs e)
        {
            LoadGrille();
            date_search.Value = Convert.ToDateTime("01/01/1970 00:00:00");
            LoadConfig();
        }

        private void LoadConfig()
        {
            LoadLangue();
        }

        private void LoadLangue()
        {
            this.Text = Mots.Mouvement_Stock;
            grp_search.Text = Mots.Recherche;
            article_.HeaderText = Mots.Article;
            qte_.HeaderText = Mots.Quantite;
            date_.HeaderText = Mots.Date_Creation;
        }

        private void AddRow(MouvementStock m)
        {
            dgv_liste.Rows.Add(new object[] { m.Id, m.Article != null ? m.Article.Designation : "", m.Quantite > -1 ? m.Quantite : -(m.Quantite), m.Date, m.Icon });
        }

        private void LoadGrille()
        {
            dgv_liste.Rows.Clear();
            string query = "select * from mouvements_stock order by date_save";
            List<MouvementStock> l = MouvementStockBLL.List(query);
            foreach (MouvementStock m in l)
            {
                AddRow(m);
            }
        }

        private void date_search_ValueChanged(object sender, EventArgs e)
        {
            string search = txt_search.Text.Trim();
            DateTime date = date_search.Value;
            if (!date.Equals(Convert.ToDateTime("01/01/1970 00:00:00")))
            {
                dgv_liste.Rows.Clear();
                string query = "select * from mouvements_stock where date_save between '" + date.ToShortDateString() + "' and '" + date.AddDays(1).ToShortDateString() + "'";
                if (search.Length > 0)
                {
                    query = "select c.* from mouvements_stock c inner join articles a on c.article = a.id where a.reference like '" + search + "%' or a.designation like '" + search + "%' and c.date_save ='" + date + "'";
                }

                List<MouvementStock> l = MouvementStockBLL.List(query);
                foreach (MouvementStock f in l)
                {
                    AddRow(f);
                }
            }
            else
            {
                LoadGrille();
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string search = txt_search.Text.Trim();
            DateTime date = date_search.Value;
            if (search.Length > 0)
            {
                dgv_liste.Rows.Clear();
                string query = "select c.* from mouvements_stock c inner join articles a on c.article = a.id where a.reference like '" + search + "%' or a.designation like '" + search + "%'";
                if (!date.Equals(Convert.ToDateTime("01/01/1970 00:00:00")))
                {
                    query = "select c.* from mouvements_stock c inner join articles a on c.article = a.id where a.reference like '" + search + "%' or a.designation like '" + search + "%' and c.date_save between '" + date.ToShortDateString() + "' and '" + date.AddDays(1).ToShortDateString() + "'";
                }
                
                List<MouvementStock> l = MouvementStockBLL.List(query);
                foreach (MouvementStock f in l)
                {
                    AddRow(f);
                }
            }
            else
            {
                LoadGrille();
            }
        }

        private void reinitialiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            date_search.Value = Convert.ToDateTime("01/01/1970 00:00:00");
        }
    }
}
