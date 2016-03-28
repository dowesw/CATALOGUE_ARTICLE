using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    class UsersBLL
    {
        public static Int32 Current(Users y)
        {
            try
            {
                return UsersDAO.currentUsers(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Users One(Int32 y)
        {
            try
            {
                return UsersDAO.oneUsers(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Users Verify(Users y)
        {
            try
            {
                return UsersDAO.verifytUsers(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Users Save(Users y)
        {
            try
            {
                return UsersDAO.saveUsers(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Insertion Impossible", ex);
            }
        }

        public static bool Update(Users y)
        {
            try
            {
                return UsersDAO.updateUsers(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool UpdatePhoto(Users y)
        {
            try
            {
                return UsersDAO.updatePhotoUsers(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool Delete(Users y)
        {
            try
            {
                return UsersDAO.deleteUsers(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static bool DeletePhoto(Users y)
        {
            try
            {
                return UsersDAO.deletePhotoUsers(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static List<Users> List(string y)
        {
            try
            {
                return UsersDAO.listUsers(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Liste Impossible", ex);
            }
        }
    }
}
