using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Reflection;

namespace CATALOGUE_ARTICLE.TOOLS
{
    class AccesFormulaires
    {
        public static bool form_acces, form_article, form_docstock, form_famille,
            form_mouvement, form_setting, form_users;

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
