using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    class SerieBLL
    {
        public static Int32 Current(Serie y)
        {
            try
            {
                return SerieDAO.currentSerie(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Serie One(Int32 y)
        {
            try
            {
                return SerieDAO.oneSerie(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Serie Save(Serie y)
        {
            try
            {
                return SerieDAO.saveSerie(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Insertion Impossible", ex);
            }
        }

        public static bool Update(Serie y)
        {
            try
            {
                return SerieDAO.updateSerie(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool Delete(Serie y)
        {
            try
            {
                return SerieDAO.deleteSerie(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static List<Serie> List(string y)
        {
            try
            {
                return SerieDAO.listSerie(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Liste Impossible", ex);
            }
        }
    }
}
