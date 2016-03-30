using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.ENTITE
{
    class ContenuStock
    {
        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        private double prix;

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
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

        private DocStock stock = new DocStock();

        internal DocStock Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        private bool update;

        public bool Update
        {
            get { return update; }
            set { update = value; }
        }

        public Boolean Control()
        {
            return Control(this);
        }

        public static Boolean Control(ContenuStock bean)
        {
            if (bean == null)
            {
                Messages.ShowErreur("Contenu Stock Incorrect!");
                return false;
            }
            if (bean.quantite < 0)
            {
                Messages.ShowErreur("La quantitée ne peut pas etre < 1!");
                return false;
            }
            if (bean.article !=null?bean.article.Id<1:true)
            {
                Messages.ShowErreur("Vous devez entrer l'article!");
                return false;
            }
            if (bean.stock != null ? bean.stock.Id < 1 : true)
            {
                Messages.ShowErreur("Le document de stock est incorrect!");
                return false;
            }
            return true;
        }
    }
}
