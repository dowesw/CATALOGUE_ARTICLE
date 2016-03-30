using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.ENTITE
{
    class Formulaires
    {
        public Formulaires() { }

        public Formulaires(Int32 id)
        {
            this.id = id;
        }

        public Formulaires(string code, string libelle)
        {
            this.code = code;
            this.libelle = libelle;
        }

        public Formulaires(Int32 id, string code, string libelle)
        {
            this.id = id;
            this.code = code;
            this.libelle = libelle;
        }

        public Formulaires(string code, string libelle, Ressources[] ressources)
        {
            this.code = code;
            this.libelle = libelle;
            this.ressources = ressources;
        }

        public Formulaires(Int32 id, string code, string libelle, Ressources[] ressources)
        {
            this.id = id;
            this.code = code;
            this.libelle = libelle;
            this.ressources = ressources;
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

        Ressources[] ressources = new Ressources[]{};

        internal Ressources[] Ressources
        {
            get { return ressources; }
            set { ressources = value; }
        }
    }
}
