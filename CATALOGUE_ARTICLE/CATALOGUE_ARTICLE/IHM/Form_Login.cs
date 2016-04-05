using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CATALOGUE_ARTICLE.BLL;
using CATALOGUE_ARTICLE.TOOLS;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.IHM
{
    public partial class Form_Login : Form
    {
        int i = 0, j = 0, nbreerror = 0;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void MiseZero()
        {
            txt_identifiant.ResetText();
            txt_pwd.ResetText();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            txt_identifiant.Focus();
            Constantes.users = null;
            //timer2.Start();
            LoadConfig();
        }

        private void LoadConfig()
        {
            LoadLangue();
        }

        private void LoadLangue()
        {
            this.Text = Mots.Login;
            lb_connexion.Text = Mots.Connexion;
            lb_identifiant.Text = Mots.Identifiant + " :";
            lb_password.Text = Mots.Password + " :";
            lb_temps.Text = Mots.Temps_Connexion;
        }

        private Users RecopiewView()
        {
            Users u = new Users();
            u.Identifiant = txt_identifiant.Text.Trim();
            u.Password = Echapper(txt_pwd.Text.Trim());
            return u;
        }

        private bool ConnectLog()
        {
            try
            {
                Users u = RecopiewView();
                if (u.Control_())
                {
                    if (u.Identifiant.Equals(Constantes.NAME_ADMIN) && u.Password.Equals(Constantes.NAME_ADMIN))
                    {
                        u.Identifiant = "Administrateur";
                        u.Nom = "Administrateur";
                        u.Niveau = SuperNiveau();
                        u.Admin = true;
                        if (Constantes.users == null)
                            Constantes.users = new ENTITE.Users();
                        Constantes.users = u;
                        return true;
                    }
                    else
                    {
                        Users u_ = UsersBLL.Verify(u);
                        if ((u_ != null) ? u_.Id > 0 : false)
                        {
                            if (u_.Actif)
                            {
                                if (Constantes.users == null)
                                    Constantes.users = new ENTITE.Users();
                                Constantes.users = u_;
                                return true;
                            }
                            else
                            {
                                Messages.ShowErreur(Mots.Msg_Compte_Erreur);
                            }
                        }
                        else
                        {
                            Messages.ShowErreur(Mots.Msg_identfiant_Erreur);
                        }
                    }

                }
                return false;
            }
            catch (Exception ex)
            {
                Messages.Exception(ex);
                return false;
            }
        }

        private string Echapper(string chaine)
        {
            int i = 0;
            string vr = null;
            vr = chaine;
            foreach (char t in chaine)
            {
                if (t == '\'')
                {
                    vr = vr.Insert(i + 1, "'");
                    i++;
                }
                else if (t == '\\')
                {
                    vr = vr.Insert(i + 1, @"\");
                    i++;
                }
                i++;
            }
            return vr;
        }

        private void btn_connecter_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConnectLog())
                {
                    timer1.Stop();
                    timer2.Stop();
                    this.Close();
                    Form_Parent f_parent = new Form_Parent();
                    if (Constantes.f_parent == null)
                    {
                        f_parent.Show();
                        Constantes.f_parent = f_parent;
                    }
                    else
                    {
                        Constantes.f_parent.InitializeComponent();
                        Constantes.f_parent.Show();
                    }
                    if (Constantes.users != null)
                    {
                        Acces.LoadAcces(Constantes.users.Niveau);
                        Constantes.f_parent.txt_users.Text = Constantes.users.Prenom + " " + Constantes.users.Nom;
                        if (!(Constantes.users.Photo == null || Constantes.users.Photo.Trim().Equals("")))
                        {
                            string chemin = Chemins.getCheminUsers(Constantes.users.Id.ToString());
                            if (System.IO.File.Exists(chemin + Constantes.users.Photo))
                            {
                                Constantes.f_parent.box_users.Image = Image.FromFile(chemin + Constantes.users.Photo);
                                return;
                            }
                        }
                    }
                    Constantes.f_parent.box_users.Image.Dispose();
                    Constantes.f_parent.box_users.Image = global::CATALOGUE_ARTICLE.Properties.Resources.contact;
                }
            }
            catch (Exception ex)
            {
                Messages.Exception(ex);
            }
        }

        public void btn_annuler_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == Messages.FermerApplication())
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i != Constantes.MAX_TIME_CONNECT)
            {
                lb_temps.Text = "Il reste " + (Constantes.MAX_TIME_CONNECT - i).ToString() + " secondes";
                timer1.Stop();
                timer2.Start();
                System.Threading.Thread.Sleep(1000);
                i++;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (j == 3)
            {
                timer2.Stop();
                timer1.Start();
                if (i == Constantes.MAX_TIME_CONNECT)
                {
                    progressBar1.Value += 100 - progressBar1.Value;
                    if (DialogResult.OK == MessageBox.Show("Temps de connexion expiré. Merci", Constantes.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Exclamation))
                    {
                        Application.Exit();
                    }
                }
                j = 0;
            }
            else
            {
                progressBar1.Value += 1;
                j++;
            }
        }

        private NiveauAcces SuperNiveau()
        {
            NiveauAcces n = new NiveauAcces();
            string query = "select * from niveau_acces where super = true limit 1";
            List<NiveauAcces> l = NiveauAccesBLL.List(query);
            if (l != null ? l.Count > 0 : false)
            {
                n = l[0];
            }
            else
            {
                n.Super = true;
                n.Description = "Super Administrateur";
                n.Designation = "Super Administrateur";
                n = NiveauAccesBLL.Save(n);
            }

            query = "select * from formulaires";
            List<Formulaires> lf = FormulairesBLL.List(query);
            foreach (Formulaires f in lf)
            {
                AutorisationFormulaire a = AutorisationFormulaireBLL.One(AutorisationFormulaireBLL.Current(new AutorisationFormulaire(n, f, true)));
                if (a != null ? a.Id < 1 : true)
                {
                    AutorisationFormulaireBLL.Save(new AutorisationFormulaire(n, f, true));
                }
            }

            query = "select * from ressources";
            List<Ressources> lr = RessourcesBLL.List(query);
            foreach (Ressources r in lr)
            {
                AutorisationRessource a = AutorisationRessourceBLL.One(AutorisationRessourceBLL.Current(new AutorisationRessource(n, r, true)));
                if (a != null ? a.Id < 1 : true)
                {
                    AutorisationRessourceBLL.Save(new AutorisationRessource(n, r, true));
                }
            }
            return n;
        }
    }
}
