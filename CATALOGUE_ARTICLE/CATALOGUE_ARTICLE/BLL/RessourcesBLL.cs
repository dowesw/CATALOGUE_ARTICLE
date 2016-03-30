using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    class RessourcesBLL
    {
        public static Int32 Current(Ressources y)
        {
            try
            {
                return RessourcesDAO.currentRessources(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Ressources One(Int32 y)
        {
            try
            {
                return RessourcesDAO.oneRessources(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Ressources Save(Ressources y)
        {
            try
            {
                return RessourcesDAO.saveRessources(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Insertion Impossible", ex);
            }
        }

        public static bool Update(Ressources y)
        {
            try
            {
                return RessourcesDAO.updateRessources(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool Delete(Ressources y)
        {
            try
            {
                return RessourcesDAO.deleteRessources(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static List<Ressources> List(string y)
        {
            try
            {
                return RessourcesDAO.listRessources(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Liste Impossible", ex);
            }
        }
    }
}
