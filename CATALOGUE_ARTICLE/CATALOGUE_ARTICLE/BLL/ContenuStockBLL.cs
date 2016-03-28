using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    class ContenuStockBLL
    {
        public static Int32 Current(ContenuStock y)
        {
            try
            {
                return ContenuStockDAO.currentContenuStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static ContenuStock One(Int32 y)
        {
            try
            {
                return ContenuStockDAO.oneContenuStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static ContenuStock Save(ContenuStock y)
        {
            try
            {
                return ContenuStockDAO.saveContenuStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Insertion Impossible", ex);
            }
        }

        public static bool Update(ContenuStock y)
        {
            try
            {
                return ContenuStockDAO.updateContenuStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool Delete(ContenuStock y)
        {
            try
            {
                return ContenuStockDAO.deleteContenuStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static List<ContenuStock> List(string y)
        {
            try
            {
                return ContenuStockDAO.listContenuStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Liste Impossible", ex);
            }
        }
    }
}
