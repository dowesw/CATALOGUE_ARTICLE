using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.ENTITE
{
    public class NiveauAcces
    {

        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
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

        private bool super;

        public bool Super
        {
            get { return super; }
            set { super = value; }
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

        public static Boolean Control(NiveauAcces bean)
        {
            if (bean == null)
            {
                Messages.ShowErreur("Niveau accès Incorrect!");
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
