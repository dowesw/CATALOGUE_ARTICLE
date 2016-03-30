using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace CATALOGUE_ARTICLE.ENTITE
{
    class AutorisationFormulaire
    {

        public AutorisationFormulaire() { }

        public AutorisationFormulaire(NiveauAcces niveau, Formulaires formulaire)
        {
            this.niveau = niveau;
            this.formulaire = formulaire;
        }

        public AutorisationFormulaire(NiveauAcces niveau, Formulaires formulaire, bool update)
        {
            this.niveau = niveau;
            this.formulaire = formulaire;
            this.update = update;
        }

        public AutorisationFormulaire( Int32 id, NiveauAcces niveau, Formulaires formulaire, bool update)
        {
            this.id = id;
            this.niveau = niveau;
            this.formulaire = formulaire;
            this.update = update;
        }

        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        private NiveauAcces niveau = new NiveauAcces();

        internal NiveauAcces Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }

        private Formulaires formulaire = new Formulaires();

        internal Formulaires Formulaire
        {
            get { return formulaire; }
            set { formulaire = value; }
        }

        private bool update;

        public bool Update
        {
            get { return update; }
            set { update = value; }
        }
    }
}
