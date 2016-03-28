using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    class MouvementStockBLL
    {
        public static Int32 Current(MouvementStock y)
        {
            try
            {
                return MouvementStockDAO.currentMouvementStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static MouvementStock One(Int32 y)
        {
            try
            {
                return MouvementStockDAO.oneMouvementStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static MouvementStock Save(MouvementStock y)
        {
            try
            {
                return MouvementStockDAO.saveMouvementStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Insertion Impossible", ex);
            }
        }

        public static bool Update(MouvementStock y)
        {
            try
            {
                return MouvementStockDAO.updateMouvementStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool Delete(MouvementStock y)
        {
            try
            {
                return MouvementStockDAO.deleteMouvementStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static List<MouvementStock> List(string y)
        {
            try
            {
                return MouvementStockDAO.listMouvementStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Liste Impossible", ex);
            }
        }
    }
}
