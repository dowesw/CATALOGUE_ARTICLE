using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    class PhotosArticleBLL
    {
        public static Int32 Current(PhotosArticle y)
        {
            try
            {
                return PhotosArticleDAO.currentPhotosArticle(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static PhotosArticle One(Int32 y)
        {
            try
            {
                return PhotosArticleDAO.onePhotosArticle(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static PhotosArticle Save(PhotosArticle y)
        {
            try
            {
                return PhotosArticleDAO.savePhotosArticle(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Insertion Impossible", ex);
            }
        }

        public static bool Update(PhotosArticle y)
        {
            try
            {
                return PhotosArticleDAO.updatePhotosArticle(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool Delete(PhotosArticle y)
        {
            try
            {
                return PhotosArticleDAO.deletePhotosArticle(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static List<PhotosArticle> List(string y)
        {
            try
            {
                return PhotosArticleDAO.listPhotosArticle(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Liste Impossible", ex);
            }
        }
    }
}
