using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATALOGUE_ARTICLE.DAO;
using CATALOGUE_ARTICLE.ENTITE;

namespace CATALOGUE_ARTICLE.BLL
{
    class FormulairesBLL
    {
        public static Int32 Current(Formulaires y)
        {
            try
            {
                return FormulairesDAO.currentFormulaires(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Formulaires One(Int32 y)
        {
            try
            {
                return FormulairesDAO.oneFormulaires(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Retour Impossible", ex);
            }
        }

        public static Formulaires Save(Formulaires y)
        {
            try
            {
                return FormulairesDAO.saveFormulaires(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Insertion Impossible", ex);
            }
        }

        public static bool Update(Formulaires y)
        {
            try
            {
                return FormulairesDAO.updateFormulaires(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Modification Impossible", ex);
            }
        }

        public static bool Delete(Formulaires y)
        {
            try
            {
                return FormulairesDAO.deleteFormulaires(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Suppression Impossible", ex);
            }
        }

        public static List<Formulaires> List(string y)
        {
            try
            {
                return FormulairesDAO.listFormulaires(y);
            }
            catch (Exception ex)
            {
                throw new Exception("Liste Impossible", ex);
            }
        }
    }
}
