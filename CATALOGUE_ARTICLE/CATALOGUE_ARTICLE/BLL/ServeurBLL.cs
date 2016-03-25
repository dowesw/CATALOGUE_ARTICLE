using System;
using System.Collections.Generic;
using System.Text;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    public class ServeurBLL
    {

        public static bool CreateServeur(Serveur config)
        {
            try
            {
                return ServeurDAO.getCreateServeur(config);
            }
            catch (Exception ex)
            {
                throw new Exception("Echec de Création de fichier", ex);
            }
        }

        public static Serveur ReturnServeur()
        {
            try
            {
                return ServeurDAO.getReturnServeur();
            }
            catch (Exception ex)
            {
                throw new Exception("Echec de Création de fichier", ex);
            }

        }
    }
}
