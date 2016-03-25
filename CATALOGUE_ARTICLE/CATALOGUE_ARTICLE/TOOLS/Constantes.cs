using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CATALOGUE_ARTICLE.IHM;

namespace CATALOGUE_ARTICLE.TOOLS
{
    class Constantes
    {

        public const string APP_NAME = "Catalogue Articles";

        public static string f_last = null;
        public static List<string> f_first = new List<string>();

        public static Form_Acces f_acces = null;
        public static Form_Licence f_licence = null;
        public static Form_Setting f_setting = null;
        public static Form_Open f_open = null;
        public static Form_Famille f_famille = null;
        public static Form_Article f_article = null;
        public static Form_Catalogue f_catalogue = null;
        public static Form_Propos f_propos = null;
        public static Form_Users f_users = null;

        public const string NAME_ADMIN = "A";

        public const int MAX_ERROR_CONNECT = 2;
        public const int MAX_TIME_CONNECT = 30;

        public static bool ACTIVE = true;
        public static int TRIAL_ESSAIE = 30;
        public const int MAX_ESSAIE = 30;

        public const string FILE_SEPARATOR = "\\";

        public const string MOUV_ENTREE = "RECETTE";
        public const string MOUV_SORTIE = "DEPENSE";

        public const string TABLE_EXTERNE_PIECE = "docdevente";

        public const string ETAT_EN_ATTENTE = "EDITABLE";
        public const string ETAT_ANNULE = "ANNULE";
        public const string ETAT_EN_COURS = "ENCOURS";
        public const string ETAT_REGLE = "REGLE";
        public const string ETAT_VALIDE = "VALIDE";
        public const string ETAT_RETARD = "En Retard";

        public const string TYPE_FV = "FV";
        public const string TYPE_BCV = "BCV";
        public const string TYPE_FV_NAME = "Facture";
        public const string TYPE_BCV_NAME = "Commande";

        public const string DOC_FACTURE = "Facture Vente";
        public const string DOC_COMMANDE = "Bon Commande Vente";
        public const string DOC_PIECE = "Piece Caisse";        

        //Base
        public const string BASE_CA = "CA";
        public const string BASE_QTE = "Qte";

        //Nature Montant
        public const string NATURE_TAUX = "Taux";
        public const string NATURE_MTANT = "Montant";

        //Methode de valorisation
        public const string FIFO = "FIFO";
        public const string LIFO = "LIFO";
        public const string CMPI = "CMPI";
        public const string CMPII = "CMPII";

        //Mode Inventaire
        public const string INV_PERMANENT = "P";
        public const string INV_INTERMITENT = "I";

    }
}
