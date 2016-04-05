using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    class MarqueBLL
    {
        public static Int32 Current(Marque y)
        {
            try
            {
                return MarqueDAO.currentMarque(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Marque One(Int32 y)
        {
            try
            {
                return MarqueDAO.oneMarque(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Marque Save(Marque y)
        {
            try
            {
                return MarqueDAO.saveMarque(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Insertion Impossible", ex);
            }
        }

        public static bool Update(Marque y)
        {
            try
            {
                return MarqueDAO.updateMarque(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool Delete(Marque y)
        {
            try
            {
                return MarqueDAO.deleteMarque(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static List<Marque> List(string y)
        {
            try
            {
                return MarqueDAO.listMarque(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Liste Impossible", ex);
            }
        }
    }
}
