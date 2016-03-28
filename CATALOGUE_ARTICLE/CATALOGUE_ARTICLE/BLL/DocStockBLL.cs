using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    class DocStockBLL
    {
        public static Int32 Current(DocStock y)
        {
            try
            {
                return DocStockDAO.currentDocStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static DocStock One(string y)
        {
            try
            {
                return DocStockDAO.oneDocStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static DocStock One(Int32 y)
        {
            try
            {
                return DocStockDAO.oneDocStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static DocStock Save(DocStock y)
        {
            try
            {
                return DocStockDAO.saveDocStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Insertion Impossible", ex);
            }
        }

        public static bool Update(DocStock y)
        {
            try
            {
                return DocStockDAO.updateDocStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool Delete(DocStock y)
        {
            try
            {
                return DocStockDAO.deleteDocStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static List<DocStock> List(string y)
        {
            try
            {
                return DocStockDAO.listDocStock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Liste Impossible", ex);
            }
        }
    }
}
