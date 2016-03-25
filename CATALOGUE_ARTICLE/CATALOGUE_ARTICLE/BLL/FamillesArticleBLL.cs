using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    class FamillesArticleBLL
    {
        public static Int32 Current(FamillesArticle y)
        {
            try
            {
                return FamillesArticleDAO.currentFamillesArticle(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static FamillesArticle One(Int32 y)
        {
            try
            {
                return FamillesArticleDAO.oneFamillesArticle(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static FamillesArticle Save(FamillesArticle y)
        {
            try
            {
                return FamillesArticleDAO.saveFamillesArticle(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Insertion Impossible", ex);
            }
        }

        public static bool Update(FamillesArticle y)
        {
            try
            {
                return FamillesArticleDAO.updateFamillesArticle(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool Delete(FamillesArticle y)
        {
            try
            {
                return FamillesArticleDAO.deleteFamillesArticle(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static List<FamillesArticle> List(string y)
        {
            try
            {
                return FamillesArticleDAO.listFamillesArticle(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Liste Impossible", ex);
            }
        }
    }
}
