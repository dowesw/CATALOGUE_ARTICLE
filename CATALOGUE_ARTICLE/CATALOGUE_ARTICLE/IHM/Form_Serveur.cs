using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CATALOGUE_ARTICLE.TOOLS;
using CATALOGUE_ARTICLE.BLL;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.IHM
{
    public partial class Form_Serveur : Form
    {
        public Form_Serveur()
        {
            InitializeComponent();
        }

        private ENTITE.Serveur RecopiewView()
        {
            ENTITE.Serveur bean = new ENTITE.Serveur();
            bean.Adresse = txt_adress.Text.Trim();
            bean.Database = txt_db.Text.Trim();
            bean.Password = txt_pwd.Text.Trim();
            bean.User = txt_user.Text.Trim();
            try
            {
                bean.Port = Convert.ToInt16((!txt_port.Text.Trim().Equals("")) ? txt_port.Text.Trim() : "5432");
            }
            catch (Exception ex)
            {
                Messages.ShowErreur("Le port est une valeur numerique");
                bean.Port = 5432;
            }
            return bean;
        }

        private void Form_Serveur_Load(object sender, EventArgs e)
        {
            Serveur s = ServeurBLL.ReturnServeur();
            txt_adress.Text = s.Adresse;
            txt_db.Text = s.Database;
            txt_pwd.Text = s.Password;
            txt_port.Text = s.Port.ToString();
            txt_user.Text = s.User;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ENTITE.Serveur bean = RecopiewView();
            if (bean.Control())
            {
                if (BLL.ServeurBLL.CreateServeur(bean))
                {
                    Application.Restart();
                }
            }
        }
    }
}
