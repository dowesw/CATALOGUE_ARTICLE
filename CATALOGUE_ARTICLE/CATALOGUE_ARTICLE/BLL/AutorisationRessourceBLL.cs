using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    class AutorisationRessourceBLL
    {
        public static Int32 Current(AutorisationRessource y)
        {
            try
            {
                return AutorisationRessourceDAO.currentAutorisationRessource(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static AutorisationRessource One(Int32 y)
        {
            try
            {
                return AutorisationRessourceDAO.oneAutorisationRessource(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static AutorisationRessource Save(AutorisationRessource y)
        {
            try
            {
                return AutorisationRessourceDAO.saveAutorisationRessource(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Insertion Impossible", ex);
            }
        }

        public static bool Update(AutorisationRessource y)
        {
            try
            {
                return AutorisationRessourceDAO.updateAutorisationRessource(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool Delete(AutorisationRessource y)
        {
            try
            {
                return AutorisationRessourceDAO.deleteAutorisationRessource(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static List<AutorisationRessource> List(string y)
        {
            try
            {
                return AutorisationRessourceDAO.listAutorisationRessource(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Liste Impossible", ex);
            }
        }
    }
}
