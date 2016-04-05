using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.ENTITE
{
    public class Serie
    {
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

        private Marque marque = new Marque();

        public Marque Marque
        {
            get { return marque; }
            set { marque = value; }
        }

        private bool update = false;

        public bool Update
        {
            get { return update; }
            set { update = value; }
        }

        public Boolean Control()
        {
            return Control(this);
        }

        public static Boolean Control(Serie bean)
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
            if (bean.marque != null ? bean.marque.Id < 1 : true)
            {
                Messages.ShowErreur("La marque ne peut pas être null!");
                return false;
            }
            return true;
        }
    }
}
