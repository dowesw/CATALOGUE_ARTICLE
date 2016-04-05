using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;
using System.Windows.Forms;
using CATALOGUE_ARTICLE.IHM;
using CATALOGUE_ARTICLE.IHM._2ND;

namespace CATALOGUE_ARTICLE.TOOLS
{
    class Constantes
    {

        public const string APP_NAME = "Catalogue Articles";

        public static string f_last = null;
        public static List<string> f_first = new List<string>();

        public static Form_Parent f_parent = null;
        public static Form_Mouvement f_mouvement = null;
        public static Form_DocStock f_docstock = null;
        public static Form_Acces f_acces = null;
        public static Form_Licence f_licence = null;
        public static Form_Setting f_setting = null;
        public static Form_Open f_open = null;
        public static Form_Accessoire_Article f_famille = null;
        public static Form_Article f_article = null;
        public static Form_Catalogue f_catalogue = null;
        public static Form_Propos f_propos = null;
        public static Form_Users f_users = null;
        public static Form_Photo f_photo = null;

        public static ENTITE.Users users;

        public const string NAME_ADMIN = "MEG2710/";

        public const int MAX_ERROR_CONNECT = 2;
        public const int MAX_TIME_CONNECT = 30;

        public static bool ACTIVE = true;
        public static int TRIAL_ESSAIE = 30;
        public const int MAX_ESSAIE = 30;

        public const string FILE_SEPARATOR = "\\";

        public const string MOUV_ENTREE_NAME = "ENTREE";
        public const string MOUV_ENTREE = "EN";
        public const string MOUV_SORTIE_NAME = "SORTIE";
        public const string MOUV_SORTIE = "SO";

        public const string LANGUE_FRANCAIS_NAME = "Français";
        public const string LANGUE_FRANCAIS = "Fr";
        public const string LANGUE_ANGLAIS_NAME = "English";
        public const string LANGUE_ANGLAIS = "En";

    }
}
