using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    class ArticlesBLL
    {
        public static double Stock(Articles y)
        {
            try
            {
                return ArticlesDAO.stock(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Int32 Current(Articles y)
        {
            try
            {
                return ArticlesDAO.currentArticles(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Articles One(Int32 y)
        {
            try
            {
                return ArticlesDAO.oneArticles(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Articles One(string y)
        {
            try
            {
                return ArticlesDAO.oneArticles(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Articles Save(Articles y)
        {
            try
            {
                return ArticlesDAO.saveArticles(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Insertion Impossible", ex);
            }
        }

        public static bool Update(Articles y)
        {
            try
            {
                return ArticlesDAO.updateArticles(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool Delete(Articles y)
        {
            try
            {
                return ArticlesDAO.deleteArticles(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static List<Articles> List(string y)
        {
            try
            {
                return ArticlesDAO.listArticles(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Liste Impossible", ex);
            }
        }
    }
}
