using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace CATALOGUE_ARTICLE.ENTITE
{
    class AutorisationRessource
    {

        public AutorisationRessource() { }

        public AutorisationRessource(NiveauAcces niveau, Ressources ressource)
        {
            this.niveau = niveau; 
            this.ressource = ressource;
        }

        public AutorisationRessource(NiveauAcces niveau, Ressources ressource, bool update)
        {
            this.niveau = niveau;
            this.ressource = ressource;
            this.update = update;
        }

        public AutorisationRessource(Int32 id, NiveauAcces niveau, Ressources ressource, bool update)
        {
            this.id = id;
            this.niveau = niveau;
            this.ressource = ressource;
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

        private Ressources ressource = new Ressources();

        internal Ressources Ressource
        {
            get { return ressource; }
            set { ressource = value; }
        }

        private bool update;

        public bool Update
        {
            get { return update; }
            set { update = value; }
        }
    }
}
