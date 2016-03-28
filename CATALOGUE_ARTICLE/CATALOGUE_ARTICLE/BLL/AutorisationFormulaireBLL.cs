using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    class AutorisationFormulaireBLL
    {
        public static Int32 Current(AutorisationFormulaire y)
        {
            try
            {
                return AutorisationFormulaireDAO.currentAutorisationFormulaire(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static AutorisationFormulaire One(Int32 y)
        {
            try
            {
                return AutorisationFormulaireDAO.oneAutorisationFormulaire(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static AutorisationFormulaire Save(AutorisationFormulaire y)
        {
            try
            {
                return AutorisationFormulaireDAO.saveAutorisationFormulaire(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Insertion Impossible", ex);
            }
        }

        public static bool Update(AutorisationFormulaire y)
        {
            try
            {
                return AutorisationFormulaireDAO.updateAutorisationFormulaire(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool Delete(AutorisationFormulaire y)
        {
            try
            {
                return AutorisationFormulaireDAO.deleteAutorisationFormulaire(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static List<AutorisationFormulaire> List(string y)
        {
            try
            {
                return AutorisationFormulaireDAO.listAutorisationFormulaire(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Liste Impossible", ex);
            }
        }
    }
}
