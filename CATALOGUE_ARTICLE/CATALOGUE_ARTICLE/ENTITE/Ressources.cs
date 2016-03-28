using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.ENTITE
{
    class Ressources
    {
        public Ressources() { }

        public Ressources(Int32 id)
        {
            this.id = id;
        }

        public Ressources(string code, string libelle)
        {
            this.code = code;
            this.libelle = libelle;
        }

        public Ressources(Int32 id, string code, string libelle)
        {
            this.id = id;
            this.code = code;
            this.libelle = libelle;
        }


        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private string libelle;

        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }

        private bool update;

        public bool Update
        {
            get { return update; }
            set { update = value; }
        }

        private Formulaires formulaire = new Formulaires();

        internal Formulaires Formulaire
        {
            get { return formulaire; }
            set { formulaire = value; }
        }

        public static Boolean Control(Ressources bean)
        {
            if (bean == null)
            {
                Messages.ShowErreur("Ressource Incorrects!");
                return false;
            }
            if (bean.code == null || bean.code.Trim().Equals(""))
            {
                Messages.ShowErreur("Le code ne peut pas être null!");
                return false;
            }
            if (bean.libelle == null || bean.libelle.Trim().Equals(""))
            {
                Messages.ShowErreur("Le libelle ne peut pas être null!");
                return false;
            }
            if (bean.formulaire != null ? bean.formulaire.Id < 1 : true)
            {
                Messages.ShowErreur("Vous devez préciser le formulaire!");
                return false;
            }
            return true;
        }
    }
}
