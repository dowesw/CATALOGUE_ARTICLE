using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.IHM;
using CATALOGUE_ARTICLE.IHM._2ND;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE
{
    public partial class Form_Parent : Form
    {

        public Form_Parent()
        {
            InitializeComponent();
        }

        private void Form_Parent_Load(object sender, EventArgs e)
        {
            lb_trial.Visible = !Constantes.ACTIVE;
            indexToolStripMenuItem.Visible = !Constantes.ACTIVE;
            activerToolStripMenuItem.Visible = !Constantes.ACTIVE;
            btn_deconnect.Visible = false;
            bubble.Text = Mots.Catalogue_Article;
            //bubble.ShowBalloonTip(10,"Catalogue Articles", "Bienvenu", System.Windows.Forms.ToolTipIcon.Info);
            LoadConfig();
        }

        private void LoadConfig()
        {
            this.Text = Mots.Catalogue_Article;
            lb_trial.Text = Constantes.TRIAL_ESSAIE + Mots.Delai;
            fileMenu.Text = Mots.Fichier;
            viewMenu.Text = Mots.Affichage;
            toolsMenu.Text = Mots.Outil;
            windowsMenu.Text = Mots.Fenetre;
            helpMenu.Text = Mots.Aide;
            newToolStripMenuItem.Text = Mots.Nouveau;
            newToolStripButton.Text = Mots.Nouveau;
            openToolStripButton.Text = Mots.Ouvrir;
            openToolStripMenuItem.Text = Mots.Ouvrir;
            saveToolStripButton.Text = Mots.Enregistrer;
            saveToolStripMenuItem.Text = Mots.Enregistrer;
            exitToolStripMenuItem.Text = Mots.Quitter;
            exitToolStripMenuItem1.Text = Mots.Quitter;
            toolStripStatusLabel.Text = Mots.Etat;
            toolBarToolStripMenuItem.Text = Mots.BarOutil;
            statusBarToolStripMenuItem.Text = Mots.BarEtat;
            optionsToolStripMenuItem.Text = Mots.Parametre;
            activerToolStripMenuItem.Text = Mots.Activer;
            settingToolStripMenuItem.Text = Mots.Parametre;
            newWindowToolStripMenuItem.Text = Mots.Nouv_Fenetre;
            cascadeToolStripMenuItem.Text = Mots.Cascade;
            closeAllToolStripMenuItem.Text = Mots.Fermer_Tout;
            arrangeIconsToolStripMenuItem.Text = Mots.Reorganiser_Fenetre;
            indexToolStripMenuItem.Text = Mots.Licence;
            aboutToolStripMenuItem.Text = Mots.A_Propos;
            redémarerToolStripMenuItem.Text = Mots.Restart;
            redémarerToolStripMenuItem1.Text = Mots.Restart;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            if (Constantes.f_last != null)
            {
                switch (Constantes.f_last)
                {
                    case "Mouvement":
                        Form_Mouvement f_mouvement = new Form_Mouvement();
                        if (Constantes.f_mouvement == null)
                        {
                            f_mouvement.MdiParent = this;
                            f_mouvement.Show();
                            Constantes.f_mouvement = f_mouvement;
                        }
                        else
                        {
                            Constantes.f_mouvement.WindowState = FormWindowState.Normal;
                            Constantes.f_mouvement.BringToFront();
                        }
                        break;
                    case "Stock":
                        Form_DocStock f_docstock = new Form_DocStock();
                        if (Constantes.f_docstock == null)
                        {
                            f_docstock.MdiParent = this;
                            f_docstock.Show();
                            Constantes.f_docstock = f_docstock;
                        }
                        else
                        {
                            Constantes.f_docstock.WindowState = FormWindowState.Normal;
                            Constantes.f_docstock.BringToFront();
                        }
                        break;
                    case "Setting":
                        Form_Setting f_setting = new Form_Setting();
                        if (Constantes.f_setting == null)
                        {
                            f_setting.MdiParent = this;
                            f_setting.Show();
                            Constantes.f_setting = f_setting;
                        }
                        else
                        {
                            Constantes.f_setting.WindowState = FormWindowState.Normal;
                            Constantes.f_setting.BringToFront();
                        }
                        break;
                    case "users":
                        Form_Users f_users = new Form_Users();
                        if (Constantes.f_users == null)
                        {
                            f_users.MdiParent = this;
                            f_users.Show();
                            Constantes.f_users = f_users;
                        }
                        else
                        {
                            Constantes.f_users.WindowState = FormWindowState.Normal;
                            Constantes.f_users.BringToFront();
                        }
                        break;
                    case "Propos":
                        Form_Propos f_propos = new Form_Propos();
                        if (Constantes.f_propos == null)
                        {
                            f_propos.MdiParent = this;
                            f_propos.Show();
                            Constantes.f_propos = f_propos;
                        }
                        else
                        {
                            Constantes.f_propos.WindowState = FormWindowState.Normal;
                            Constantes.f_propos.BringToFront();
                        }
                        break;
                    case "Catalogue":
                        Form_Catalogue f_catalogue = new Form_Catalogue();
                        if (Constantes.f_catalogue == null)
                        {
                            f_catalogue.MdiParent = this;
                            f_catalogue.Show();
                            Constantes.f_catalogue = f_catalogue;
                        }
                        else
                        {
                            Constantes.f_catalogue.WindowState = FormWindowState.Normal;
                            Constantes.f_catalogue.BringToFront();
                        }
                        break;
                    case "Articles":
                        Form_Article f_article = new Form_Article();
                        if (Constantes.f_article == null)
                        {
                            f_article.MdiParent = this;
                            f_article.Show();
                            Constantes.f_article = f_article;
                        }
                        else
                        {
                            Constantes.f_article.WindowState = FormWindowState.Normal;
                            Constantes.f_article.BringToFront();
                        }
                        break;
                    case "Familles":
                        Form_Accessoire_Article f_famille = new Form_Accessoire_Article();
                        if (Constantes.f_famille == null)
                        {
                            f_famille.MdiParent = this;
                            f_famille.Show();
                            Constantes.f_famille = f_famille;
                        }
                        else
                        {
                            Constantes.f_famille.WindowState = FormWindowState.Normal;
                            Constantes.f_famille.BringToFront();
                        }
                        break;
                    case "Licence":
                        Form_Licence f_licence = new Form_Licence();
                        if (Constantes.f_licence == null)
                        {
                            f_licence.MdiParent = this;
                            f_licence.Show();
                            Constantes.f_licence = f_licence;
                        }
                        else
                        {
                            Constantes.f_licence.WindowState = FormWindowState.Normal;
                            Constantes.f_licence.BringToFront();
                        }
                        break;
                    default:
                        break;
                }
            }
            Constantes.f_last = null;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            IHM.Form_Open f_open = new IHM.Form_Open();
            if (Constantes.f_open == null)
            {
                f_open.MdiParent = this;
                Constantes.f_open = f_open;
                f_open.Show();
            }
            else
            {
                Constantes.f_open.WindowState = FormWindowState.Normal;
                Constantes.f_open.BringToFront();
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void activerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IHM.Form_Licence f_licence = new IHM.Form_Licence();
            if (Constantes.f_licence == null)
            {
                f_licence.MdiParent = this;
                Constantes.f_licence = f_licence;
                f_licence.Show();
            }
            else
            {
                Constantes.f_licence.WindowState = FormWindowState.Normal;
                Constantes.f_licence.BringToFront();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Propos f_propos = new Form_Propos();
            if (Constantes.f_propos == null)
            {
                f_propos.MdiParent = this;
                f_propos.Show();
                Constantes.f_propos = f_propos;
            }
            else
            {
                Constantes.f_propos.WindowState = FormWindowState.Normal;
                Constantes.f_propos.BringToFront();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Setting f_setting = new Form_Setting();
            if (Constantes.f_setting == null)
            {
                f_setting.MdiParent = this;
                f_setting.Show();
                Constantes.f_setting = f_setting;
            }
            else
            {
                Constantes.f_setting.WindowState = FormWindowState.Normal;
                Constantes.f_setting.BringToFront();
                Utils.addFrom("Form_Setting");
            }
        }

        private void Form_Parent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_deconnect_Click(object sender, EventArgs e)
        {
            this.Hide();
            bubble.Dispose();
            new Form_Login().Show();
        }

        private void box_users_MouseEnter(object sender, EventArgs e)
        {
            Form_Photo f_photo = new Form_Photo();
            f_photo.MdiParent = this;
            f_photo.box_users.Image = box_users.Image;
            f_photo.Show();
            Constantes.f_photo = f_photo;
        }

        private void box_users_MouseLeave(object sender, EventArgs e)
        {
            Constantes.f_photo.Close();
        }

        private void redémarerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
