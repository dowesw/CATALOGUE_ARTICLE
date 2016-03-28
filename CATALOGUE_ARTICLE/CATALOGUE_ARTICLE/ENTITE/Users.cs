using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.ENTITE
{
    class Users
    {

        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        private string identifiant;

        public string Identifiant
        {
            get { return identifiant; }
            set { identifiant = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string repassword;

        public string Repassword
        {
            get { return repassword; }
            set { repassword = value; }
        }

        private bool actif;

        public bool Actif
        {
            get { return actif; }
            set { actif = value; }
        }

        private string photo;

        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        private NiveauAcces niveau = new NiveauAcces();

        internal NiveauAcces Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }

        private bool update;

        public bool Update
        {
            get { return update; }
            set { update = value; }
        }

        private bool admin;

        public bool Admin
        {
            get { return admin; }
            set { admin = value; }
        }

        public Boolean Control()
        {
            return Control(this);
        }

        public static Boolean Control(Users bean)
        {
            if (bean == null)
            {
                Messages.ShowErreur("Utilisateur Incorrect!");
                return false;
            }
            if (bean.nom == null || bean.nom.Trim().Equals(""))
            {
                Messages.ShowErreur("Le nom ne peut pas être null!");
                return false;
            }
            if (bean.identifiant == null || bean.identifiant.Trim().Equals(""))
            {
                Messages.ShowErreur("L'identifiant ne peut pas être null!");
                return false;
            }
            if (bean.password == null || bean.password.Trim().Equals(""))
            {
                Messages.ShowErreur("Le mot de passe ne peut pas être null!");
                return false;
            }
            if (bean.repassword == null || bean.repassword.Trim().Equals(""))
            {
                Messages.ShowErreur("Vous devez confirmer le mot de passe!");
                return false;
            }
            if (!bean.repassword.Trim().Equals(bean.password.Trim()))
            {
                Messages.ShowErreur("Echec de confirmation du mot de passe");
                return false;
            }
            if (bean.niveau != null ? bean.niveau.Id < 1 : true)
            {
                Messages.ShowErreur("Vous devez préciser le niveau!");
                return false;
            }
            return true;
        }

        public Boolean Control_()
        {
            return Control_(this);
        }

        public static Boolean Control_(Users bean)
        {
            if (bean == null)
            {
                Messages.ShowErreur("Utilisateur Incorrect!");
                return false;
            }
            if (bean.identifiant == null || bean.identifiant.Trim().Equals(""))
            {
                Messages.ShowErreur("L'identifiant ne peut pas être null!");
                return false;
            }
            if (bean.password == null || bean.password.Trim().Equals(""))
            {
                Messages.ShowErreur("Le mot de passe ne peut pas être null!");
                return false;
            }
            return true;
        }
    }
}
