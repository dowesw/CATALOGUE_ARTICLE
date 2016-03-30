using System;
using System.Collections.Generic;
using System.Linq;
////using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using CATALOGUE_ARTICLE.TOOLS;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.BLL;
using CATALOGUE_ARTICLE.IHM;

namespace CATALOGUE_ARTICLE
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Licence.deleteLicence();
            //Application.Run(new Form_Parent());
            start();
        }

        static void start()
        {
            Licence.createLicence();
            if (Licence.verifyLicence())
            {
                if (!Utils.verifyParametre())
                {
                    if (ServeurBLL.CreateServeur(Serveur.getServeurDefault()))
                    {
                        new Acces();
                        new Form_Parent().Show();
                        //new Form_Login().Show();
                        Application.Run();
                    }
                }
                else
                {
                    if (Connexion.isConnection())
                    {
                        new Acces();
                        new Form_Parent().Show();
                        //new Form_Login().Show();
                        Application.Run();
                    }
                    else
                    {
                        if (Connexion.createDb())
                        {
                            new Acces();
                            new Form_Parent().Show();
                            //new Form_Login().Show();
                            Application.Run();
                        }
                    }
                }
            }
            else
            {
                Messages.ShowErreur("Vous devez activer votre compte");
            }
        }
    }
}
