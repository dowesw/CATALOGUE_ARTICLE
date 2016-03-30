using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.ENTITE
{
    class DocStock
    {
        public DocStock() { }

        public DocStock(Int32 id)
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

        private string type = Constantes.MOUV_ENTREE;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private System.Drawing.Image icon;

        public System.Drawing.Image Icon
        {
            get {
                if (type.Equals(Constantes.MOUV_ENTREE))
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

        private DateTime date = new DateTime();

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private List<ContenuStock> contenus = new List<ContenuStock>();

        internal List<ContenuStock> Contenus
        {
            get { return contenus; }
            set { contenus = value; }
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

        public static Boolean Control(DocStock bean)
        {
            if (bean == null)
            {
                Messages.ShowErreur("Document Stock Incorrect!");
                return false;
            }
            if (bean.reference == null || bean.reference.Trim().Equals(""))
            {
                Messages.ShowErreur("La réference ne peut pas être null!");
                return false;
            }
            if (bean.type == null || bean.type.Trim().Equals(""))
            {
                Messages.ShowErreur("Le type ne peut pas être null!");
                return false;
            }
            return true;
        }
    }
}
