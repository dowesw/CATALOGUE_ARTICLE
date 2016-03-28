using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.ENTITE
{
    class Articles
    {
        public Articles() { }

        public Articles(Int32 id)
        {
            this.id = id;
        }

        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        private string reference;

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string marque;

        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }

        private double pua;

        public double Pua
        {
            get { return pua; }
            set { pua = value; }
        }

        private double puv;

        public double Puv
        {
            get { return puv; }
            set { puv = value; }
        }

        private DateTime dateSave = new DateTime();

        public DateTime DateSave
        {
            get { return dateSave; }
            set { dateSave = value; }
        }

        private DateTime dateUpdate = new DateTime();

        public DateTime DateUpdate
        {
            get { return dateUpdate; }
            set { dateUpdate = value; }
        }

        private FamillesArticle famille = new FamillesArticle();

        internal FamillesArticle Famille
        {
            get { return famille; }
            set { famille = value; }
        }

        private double stock;

        public double Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        private List<PhotosArticle> photos = new List<PhotosArticle>();

        internal List<PhotosArticle> Photos
        {
            get { return photos; }
            set { photos = value; }
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

        public static Boolean Control(Articles bean)
        {
            if (bean == null)
            {
                Messages.ShowErreur("Famille Article Incorrecte!");
                return false;
            }
            if (bean.reference == null || bean.reference.Trim().Equals(""))
            {
                Messages.ShowErreur("La réference ne peut pas être null!");
                return false;
            }
            if (bean.designation == null || bean.designation.Trim().Equals(""))
            {
                Messages.ShowErreur("La désignation ne peut pas être null!");
                return false;
            }
            return true;
        }
    }
}
