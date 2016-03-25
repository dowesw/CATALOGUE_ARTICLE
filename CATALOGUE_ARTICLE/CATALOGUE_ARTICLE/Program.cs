using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CATALOGUE_ARTICLE.TOOLS;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.BLL;

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
            Application.Run(new IHM.Form_Users());
            //start();
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
                        Application.Run(new Form_Parent());
                    }
                }
                else
                {
                    if (Connexion.isConnection())
                    {
                        Application.Run(new Form_Parent());
                    }
                    else
                    {
                        if (Connexion.createDb())
                        {
                            Application.Run(new Form_Parent());
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
