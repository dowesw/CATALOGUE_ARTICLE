using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CATALOGUE_ARTICLE.TOOLS
{
    class AccesRessources
    {
        // form_acces 
        public static bool upd_acces;
        // form_article
        public static bool add_article, del_article, upd_article,
            add_photo_article, del_photo_article;
        // form_docstock
        public static bool add_doc_stock, del_doc_stock, upd_doc_stock;
        // form_famille
        public static bool add_famille, del_famille, upd_famille;
        // form_setting
        public static bool add_niveau, del_niveau, upd_niveau,
            upd_serveur;
        // form_users
        public static bool add_users, del_users, upd_users;

        public void Acces(string attribut, bool valeur)
        {
            FieldInfo[] property = this.GetType().GetFields();
            foreach (FieldInfo p in property)
            {
                if (p.Name.Equals(attribut.Trim()))
                {
                    p.SetValue(this, valeur);
                }
            }
        }
    }
}
