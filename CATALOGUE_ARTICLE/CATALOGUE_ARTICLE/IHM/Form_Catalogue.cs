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
    public partial class Form_Catalogue : Form
    {
        List<Articles> articles = new List<Articles>();
        Articles current = new Articles();

        public Form_Catalogue()
        {
            InitializeComponent();
        }

        private void Form_Catalogue_FormClosed(object sender, FormClosedEventArgs e)
        {
            Constantes.f_catalogue = null;
            Constantes.f_last = "Catalogue";
            Utils.removeFrom(this.Name);
        }

        private void Form_Catalogue_Load(object sender, EventArgs e)
        {
            Utils.addFrom(this.Name);
            LoadArticle();
            LoadCatalogueMosaique();
        }

        private void LoadArticle()
        {
            string query = "select * from articles order by id";
            articles = ArticlesBLL.List(query);
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            lb_etat.Text = "Etat : Vue liste";
            LoadCatalogueList();
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            lb_etat.Text = "Etat : Vue détail";
            LoadCatalogueDetail();
        }

        private void btn_mosaique_Click(object sender, EventArgs e)
        {
            lb_etat.Text = "Etat : Vue mosaïque";
            LoadCatalogueMosaique();
        }

        private void LoadCatalogueDetail()
        {
            //data.Rows.Add(new object[] { c.Id, new Bitmap(c.Article.Image, new Size(16, 16)), c.Article.Designation, c.Prix, c.Quantite, c.Remise, c.PrixTotal, null });
            panel_parent.Controls.Clear();
            DataGridView data = new DataGridView();
            data.AllowUserToAddRows = false;
            data.AllowUserToDeleteRows = false;
            data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            data.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Dock = System.Windows.Forms.DockStyle.Fill;
            data.ReadOnly = true;

            DataGridViewImageColumn icon_ = new DataGridViewImageColumn();
            icon_.Width = 50;
            DataGridViewTextBoxColumn reference_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            reference_.FillWeight = 110.7445F;
            reference_.HeaderText = "Réference";
            reference_.Name = "reference_";
            reference_.ReadOnly = true;
            DataGridViewTextBoxColumn designation_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            designation_.FillWeight = 110.7445F;
            designation_.HeaderText = "Désignation";
            designation_.Name = "designation_";
            designation_.ReadOnly = true;
            DataGridViewTextBoxColumn marque_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            marque_.FillWeight = 110.7445F;
            marque_.HeaderText = "Marque";
            marque_.Name = "marque_";
            marque_.ReadOnly = true;
            DataGridViewTextBoxColumn pua_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pua_.FillWeight = 75.53299F;
            pua_.HeaderText = "Prix.A";
            pua_.Name = "pua_";
            pua_.ReadOnly = true;
            DataGridViewTextBoxColumn puv_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            puv_.FillWeight = 75.53299F;
            puv_.HeaderText = "Prix.V";
            puv_.Name = "puv_";
            puv_.ReadOnly = true;
            DataGridViewTextBoxColumn datesave_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            datesave_.FillWeight = 110.7445F;
            datesave_.HeaderText = "Date Création";
            datesave_.Name = "datesave_";
            datesave_.ReadOnly = true;
            DataGridViewTextBoxColumn dateupdate_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dateupdate_.FillWeight = 110.7445F;
            dateupdate_.HeaderText = "Date Modification";
            dateupdate_.Name = "dateupdate_";
            dateupdate_.ReadOnly = true;
            DataGridViewTextBoxColumn famille_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            famille_.FillWeight = 110.7445F;
            famille_.HeaderText = "Famille";
            famille_.Name = "famille_";
            famille_.ReadOnly = true;
            famille_.Visible = false;

            data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            reference_,
            designation_,
            marque_,
            pua_,
            puv_,
            famille_,
            datesave_,
            dateupdate_});

            foreach (Articles a in articles)
            {
                data.Rows.Add(new object[] { a.Reference, a.Designation, a.Marque, a.Pua, a.Puv, a.Famille != null ? a.Famille.Designation : "", a.DateSave, a.DateUpdate });
            }
            panel_parent.Controls.Add(data);
        }

        private void LoadCatalogueMosaique()
        {
            panel_parent.Controls.Clear();
            int x = 0, y = 0, x_ = 0, y_ = 0, c = 0;
            for (int i = 0; i < articles.Count; i++)
            {
                Articles a = articles[i];
                Panel p = new Panel();
                p.BorderStyle = BorderStyle.FixedSingle;
                p.Margin = new Padding(3, 3, 3, 3);
                p.Size = new Size(154, 180);
                p.Location = new Point(x_ + 12, y_ + 4);

                TextBox t = new TextBox();
                t.Text = a.Designation;
                t.TextAlign = HorizontalAlignment.Center;
                t.Size = new Size(140, 20);
                t.Margin = new Padding(3, 3, 3, 3);
                t.Location = new Point(6, 3);
                t.ReadOnly = true;
                p.Controls.Add(t);

                Panel p1 = new Panel();
                p1.Size = new Size(140, 118);
                p1.Margin = new Padding(3, 3, 3, 3);
                p1.Location = new Point(6, 26);
                PictureBox b = new PictureBox();
                b.BorderStyle = BorderStyle.FixedSingle;
                if (a.Photos != null ? a.Photos.Count > 0 : false)
                {
                    string chemin = Chemins.getCheminArticle(a.Id.ToString());
                    if (System.IO.File.Exists(chemin + a.Photos[0].Nom))
                    {
                        b.Image = Image.FromFile(chemin + a.Photos[0].Nom);
                    }
                    else
                    {
                        b.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                    }
                    b.Tag = 0;
                }
                else
                {
                    b.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                }
                b.SizeMode = PictureBoxSizeMode.StretchImage;
                b.Size = new Size(140, 118);
                b.Margin = new Padding(3, 3, 3, 3);
                b.Location = new Point(0, 0);
                p1.Controls.Add(b);
                p.Controls.Add(p1);

                Panel p2 = new Panel();
                p2.BorderStyle = BorderStyle.FixedSingle;
                p2.Size = new Size(140, 30);
                p2.Margin = new Padding(3, 3, 3, 3);
                p2.Location = new Point(6, 147);
                Button bp = new Button();
                bp.Size = new Size(24, 23);
                bp.Margin = new Padding(3, 3, 3, 3);
                bp.Location = new Point(3, 4);
                bp.Image = global::CATALOGUE_ARTICLE.Properties.Resources.prec;
                bp.Click += delegate(object sender, EventArgs e)
                {
                    if (b.Tag != null)
                    {
                        int j = (int)b.Tag;
                        if (j > 0)
                        {
                            j--;
                            string chemin = Chemins.getCheminArticle(a.Id.ToString());
                            if (System.IO.File.Exists(chemin + a.Photos[j].Nom))
                            {
                                b.Image = Image.FromFile(chemin + a.Photos[j].Nom);
                            }
                            else
                            {
                                b.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                            }
                            b.Tag = j;
                        }
                    }
                };
                p2.Controls.Add(bp);
                Button bn = new Button();
                bn.Size = new Size(24, 23);
                bn.Margin = new Padding(3, 3, 3, 3);
                bn.Location = new Point(112, 4);
                bn.Image = global::CATALOGUE_ARTICLE.Properties.Resources.next;
                bn.Click += delegate(object sender, EventArgs e)
                {
                    if (b.Tag != null)
                    {
                        int j = (int)b.Tag;
                        if (j < a.Photos.Count - 1)
                        {
                            j++;
                            string chemin = Chemins.getCheminArticle(a.Id.ToString());
                            if (System.IO.File.Exists(chemin + a.Photos[j].Nom))
                            {
                                b.Image = Image.FromFile(chemin + a.Photos[j].Nom);
                            }
                            else
                            {
                                b.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                            }
                            b.Tag = j;
                        }
                    }
                };
                p2.Controls.Add(bn);
                p.Controls.Add(p2);
                
                
                if (c < 3)
                {
                    x_ += 200;
                    c++;
                }
                else
                {
                    x_ = 0;
                    y_ += 205;
                    c = 0;
                }
                panel_parent.Controls.Add(p);
            }
        }

        private void LoadCatalogueList()
        {
            panel_parent.Controls.Clear();
            int i = 0 , y =0;
            foreach (Articles a in articles)
            {

                Panel p = new Panel();
                p.BorderStyle = BorderStyle.FixedSingle;
                p.Size = new Size(777, 160);
                p.Margin = new Padding(3, 3, 3, 3);
                p.Location = new Point(12, (13 + y) + (i * 160));

                Panel p1 = new Panel();
                p1.Size = new Size(140, 118);
                p1.Margin = new Padding(3, 3, 3, 3);
                p1.Location = new Point(6, 7);
                PictureBox b = new PictureBox();
                b.BorderStyle = BorderStyle.FixedSingle;
                if (a.Photos != null ? a.Photos.Count > 0 : false)
                {
                    string chemin = Chemins.getCheminArticle(a.Id.ToString());
                    if (System.IO.File.Exists(chemin + a.Photos[0].Nom))
                    {
                        b.Image = Image.FromFile(chemin + a.Photos[0].Nom);
                    }
                    else
                    {
                        b.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                    }
                    b.Tag = 0;
                }
                else
                {
                    b.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                }
                b.SizeMode = PictureBoxSizeMode.StretchImage;
                b.Size = new Size(140, 118);
                b.Margin = new Padding(3, 3, 3, 3);
                b.Location = new Point(0, 0);
                p1.Controls.Add(b);
                p.Controls.Add(p1);

                Panel p2 = new Panel();
                p2.BorderStyle = BorderStyle.FixedSingle;
                p2.Size = new Size(140, 30);
                p2.Margin = new Padding(3, 3, 3, 3);
                p2.Location = new Point(6, 127);
                Button bp = new Button();
                bp.Size = new Size(24, 23);
                bp.Margin = new Padding(3, 3, 3, 3);
                bp.Location = new Point(3, 4);
                bp.Image = global::CATALOGUE_ARTICLE.Properties.Resources.prec;
                bp.Click += delegate(object sender, EventArgs e)
                {
                    if (b.Tag != null)
                    {
                        int j = (int)b.Tag;
                        if (j > 0)
                        {
                            j--;
                            string chemin = Chemins.getCheminArticle(a.Id.ToString());
                            if (System.IO.File.Exists(chemin + a.Photos[j].Nom))
                            {
                                b.Image = Image.FromFile(chemin + a.Photos[j].Nom);
                            }
                            else
                            {
                                b.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                            }
                            b.Tag = j;
                        }
                    }
                };
                p2.Controls.Add(bp);
                Button bn = new Button();
                bn.Size = new Size(24, 23);
                bn.Margin = new Padding(3, 3, 3, 3);
                bn.Location = new Point(112, 4);
                bn.Image = global::CATALOGUE_ARTICLE.Properties.Resources.next;
                bn.Click += delegate(object sender, EventArgs e)
                {
                    if (b.Tag != null)
                    {
                        int j = (int)b.Tag;
                        if (j < a.Photos.Count - 1)
                        {
                            j++;
                            string chemin = Chemins.getCheminArticle(a.Id.ToString());
                            if (System.IO.File.Exists(chemin + a.Photos[0].Nom))
                            {
                                b.Image = Image.FromFile(chemin + a.Photos[j].Nom);
                            }
                            else
                            {
                                b.Image = global::CATALOGUE_ARTICLE.Properties.Resources.ajouter;
                            }
                            b.Tag = j;
                        }
                    }
                };
                p2.Controls.Add(bn);
                p.Controls.Add(p2);

                Label ld = new Label();
                ld.Text = "Désignation : ";
                ld.Size = new Size(72, 13);
                ld.Margin = new Padding(3, 0, 3, 0);
                ld.Location = new Point(152, 7);
                p.Controls.Add(ld);
                Label ld_ = new Label();
                ld_.Text = a.Designation;
                ld_.Size = new Size(130, 13);
                ld_.Margin = new Padding(3, 0, 3, 0);
                ld_.Location = new Point(236, 7);
                p.Controls.Add(ld_);
                Label lm = new Label();
                lm.Text = "Marque : ";
                lm.Size = new Size(52, 13);
                lm.Margin = new Padding(3, 0, 3, 0);
                lm.Location = new Point(152, 29);
                p.Controls.Add(lm);
                Label lm_ = new Label();
                lm_.Text = a.Marque;
                lm_.Size = new Size(130, 13);
                lm_.Margin = new Padding(3, 0, 3, 0);
                lm_.Location = new Point(236, 29);
                p.Controls.Add(lm_);
                Label lc = new Label();
                lc.Text = "Date Création : ";
                lc.Size = new Size(81, 13);
                lc.Margin = new Padding(3, 0, 3, 0);
                lc.Location = new Point(152, 52);
                p.Controls.Add(lc);
                Label lc_ = new Label();
                lc_.Text = a.DateSave.ToShortDateString();
                lc_.Size = new Size(130, 13);
                lc_.Margin = new Padding(3, 0, 3, 0);
                lc_.Location = new Point(236, 52);
                p.Controls.Add(lc_);
                Label lp = new Label();
                lp.Text = "Prix Vente : ";
                lp.Size = new Size(64, 13);
                lp.Margin = new Padding(3, 0, 3, 0);
                lp.Location = new Point(152, 77);
                p.Controls.Add(lp);
                Label lp_ = new Label();
                lp_.Text = string.Format("{0:#,##0}", a.Puv);
                lp_.Size = new Size(130, 13);
                lp_.Margin = new Padding(3, 0, 3, 0);
                lp_.Location = new Point(236, 77);
                p.Controls.Add(lp_);
                Label lf = new Label();
                lf.Text = "Famille : ";
                lf.Size = new Size(48, 13);
                lf.Margin = new Padding(3, 0, 3, 0);
                lf.Location = new Point(152, 101);
                p.Controls.Add(lf);
                Label lf_ = new Label();
                lf_.Text = a.Famille != null ? a.Famille.Designation : "";
                lf_.Size = new Size(130, 13);
                lf_.Margin = new Padding(3, 0, 3, 0);
                lf_.Location = new Point(236, 101);
                p.Controls.Add(lf_);

                RichTextBox r = new RichTextBox();
                r.Text = a.Description;
                r.Size = new Size(404, 118);
                r.Margin = new Padding(3, 3, 3, 3);
                r.Location = new Point(368, 7);
                r.ReadOnly = true;
                p.Controls.Add(r);

                panel_parent.Controls.Add(p);
                i++;
                y += 5;
            }
        }
        private void load()
        {
            if (articles != null ? articles.Count > 0 : false)
            {
                current = articles[0];
                lb_designation.Text = current.Designation;
                lb_marque.Text = current.Marque;
                lb_datesave.Text = current.DateSave.ToShortDateString();
                lb_puv.Text = current.Puv.ToString();
                lb_famille.Text = current.Famille != null ? current.Famille.Designation : "";
                txt_description.Text = current.Description;

                if (current.Photos != null ? current.Photos.Count > 0 : false)
                {
                    string chemin = Chemins.getCheminArticle(current.Id.ToString());
                    box_article.Image = Image.FromFile(chemin + current.Photos[0].Nom);
                    box_article.Tag = 0;
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (box_article.Tag != null)
            {
                int i = (int)box_article.Tag;
                if (i < current.Photos.Count - 1)
                {
                    i++;
                    string chemin = Chemins.getCheminArticle(current.Id.ToString());
                    box_article.Image = Image.FromFile(chemin + current.Photos[i].Nom);
                    box_article.Tag = i;
                }
            }
        }

        private void btn_prec_Click(object sender, EventArgs e)
        {
            if (box_article.Tag != null)
            {
                int i = (int)box_article.Tag;
                if (i > 0)
                {
                    i--;
                    string chemin = Chemins.getCheminArticle(current.Id.ToString());
                    box_article.Image = Image.FromFile(chemin + current.Photos[i].Nom);
                    box_article.Tag = i;
                }
            }
        }

    }
}
