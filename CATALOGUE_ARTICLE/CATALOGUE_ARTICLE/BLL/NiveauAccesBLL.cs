using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    class NiveauAccesBLL
    {
        public static Int32 Current(NiveauAcces y)
        {
            try
            {
                return NiveauAccesDAO.currentNiveauAcces(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static NiveauAcces One(Int32 y)
        {
            try
            {
                return NiveauAccesDAO.oneNiveauAcces(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static NiveauAcces Save(NiveauAcces y)
        {
            try
            {
                return NiveauAccesDAO.saveNiveauAcces(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Insertion Impossible", ex);
            }
        }

        public static bool Update(NiveauAcces y)
        {
            try
            {
                return NiveauAccesDAO.updateNiveauAcces(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool Delete(NiveauAcces y)
        {
            try
            {
                return NiveauAccesDAO.deleteNiveauAcces(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static List<NiveauAcces> List(string y)
        {
            try
            {
                return NiveauAccesDAO.listNiveauAcces(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Liste Impossible", ex);
            }
        }
    }
}
