using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CATALOGUE_ARTICLE.TOOLS
{
    class Chemins
    {
        public static string cheminDefault = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        public static string cheminSystem = Environment.GetFolderPath(Environment.SpecialFolder.System);
        public static string cheminStart = Application.StartupPath;
        public static string domainName = Environment.UserDomainName;
        public static string usersName = Environment.UserName;

        public static string getCheminInformation()
        {
            return "Software" + Constantes.FILE_SEPARATOR + Constantes.APP_NAME + Constantes.FILE_SEPARATOR + "Informations";
        }

        public static string getCheminParametre()
        {
            return "Software" + Constantes.FILE_SEPARATOR + Constantes.APP_NAME + Constantes.FILE_SEPARATOR + "Parametres";
        }

        public static string getCheminArticle()
        {
            string chemin = cheminDefault + Constantes.FILE_SEPARATOR + Constantes.APP_NAME;
            chemin += Constantes.FILE_SEPARATOR + "documents" + Constantes.FILE_SEPARATOR + "articles";
            DirectoryInfo dossier = new DirectoryInfo(chemin);
            if (!dossier.Exists)
                dossier.Create();
            return chemin + Constantes.FILE_SEPARATOR;
        }

        public static string getCheminArticle(String article)
        {
            string chemin = getCheminArticle() + article;
            DirectoryInfo dossier = new DirectoryInfo(chemin);
            if (!dossier.Exists)
                dossier.Create();
            return chemin + Constantes.FILE_SEPARATOR;
        }

        public static string getCheminUsers()
        {
            string chemin = cheminDefault + Constantes.FILE_SEPARATOR + Constantes.APP_NAME;
            chemin += Constantes.FILE_SEPARATOR + "documents" + Constantes.FILE_SEPARATOR + "users";
            DirectoryInfo dossier = new DirectoryInfo(chemin);
            if (!dossier.Exists)
                dossier.Create();
            return chemin + Constantes.FILE_SEPARATOR;
        }

        public static string getCheminUsers(String users)
        {
            string chemin = getCheminUsers() + users;
            DirectoryInfo dossier = new DirectoryInfo(chemin);
            if (!dossier.Exists)
                dossier.Create();
            return chemin + Constantes.FILE_SEPARATOR;
        }

        public static string getCheminClass()
        {
            string fullPathName = (typeof(Chemins).FullName).Replace(".", Constantes.FILE_SEPARATOR);
            return fullPathName;
        }

        public static string getCheminScript()
        {
            String chemin = cheminStart + Constantes.FILE_SEPARATOR + "Parametres";
            return chemin;
        }
    }
}
