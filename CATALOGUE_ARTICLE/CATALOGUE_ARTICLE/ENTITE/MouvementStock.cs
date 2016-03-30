using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace CATALOGUE_ARTICLE.ENTITE
{
    class MouvementStock
    {

        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime date = new DateTime();

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private double quantite;

        public double Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

        private Articles article = new Articles();

        internal Articles Article
        {
            get { return article; }
            set { article = value; }
        }

        private bool entree;

        public bool Entree
        {
            get { return entree; }
            set { entree = value; }
        }

        private ContenuStock contenu = new ContenuStock();

        internal ContenuStock Contenu
        {
            get { return contenu; }
            set { contenu = value; }
        }

        private bool update;

        public bool Update
        {
            get { return update; }
            set { update = value; }
        }

        private System.Drawing.Image icon;

        public System.Drawing.Image Icon
        {
            get
            {
                if (entree)
                {
                    icon = global::CATALOGUE_ARTICLE.Properties.Resources._in;
                }
                else
                {
                    icon = global::CATALOGUE_ARTICLE.Properties.Resources._out;
                }
                return icon;
            }
        }
    }
}
