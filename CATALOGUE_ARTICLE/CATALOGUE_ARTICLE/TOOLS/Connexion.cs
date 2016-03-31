using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.IO;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.BLL;

namespace CATALOGUE_ARTICLE.TOOLS
{
    class Connexion
    {

        public static NpgsqlConnection Connection()
        {
            return getConnexion(ServeurBLL.ReturnServeur());
        }

        private static NpgsqlConnection getConnexion(ENTITE.Serveur bean)
        {
            try
            {
                if (bean.Control_())
                {
                    string constr = "PORT=" + bean.Port + ";TIMEOUT=15;POOLING=True;MINPOOLSIZE=1;MAXPOOLSIZE=20;COMMANDTIMEOUT=20;COMPATIBLE= 2.0.14.3;DATABASE=" + bean.Database + ";HOST=" + bean.Adresse + ";PASSWORD=" + bean.Password + ";USER ID=" + bean.User + "";
                    NpgsqlConnection con = new NpgsqlConnection(constr);
                    con.Open();
                    return con;
                }
                else
                {
                    if (DialogResult.Retry == Messages.Erreur_Retry("Connexion impossible ! Entrer de nouveaux parametres"))
                    {
                        new IHM.Form_Serveur().Show();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                if (DialogResult.Retry == Messages.Erreur_Retry("Connexion impossible ! Entrer de nouveaux parametres"))
                {
                    new IHM.Form_Serveur().Show();
                }
                else
                {
                    Application.Exit();
                }
            }
            return null;
        }

        public static bool isConnection()
        {
            return isConnection(ServeurBLL.ReturnServeur());
        }

        public static bool isConnection(ENTITE.Serveur bean)
        {
            if (bean.Control_())
            {
                NpgsqlConnection con = new NpgsqlConnection();
                try
                {
                    string constr = "PORT=" + bean.Port + ";TIMEOUT=15;POOLING=True;MINPOOLSIZE=1;MAXPOOLSIZE=20;COMMANDTIMEOUT=20;COMPATIBLE= 2.0.14.3;DATABASE=" + bean.Database + ";HOST=" + bean.Adresse + ";PASSWORD=" + bean.Password + ";USER ID=" + bean.User + "";
                    con = new NpgsqlConnection(constr);
                    con.Open();
                    return true;
                }
                catch (NpgsqlException ex)
                {
                    return false;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
            }
            return false;
        }

        public static NpgsqlConnection Connection_()
        {
            return getConnexion_(ServeurBLL.ReturnServeur());
        }

        private static NpgsqlConnection getConnexion_(ENTITE.Serveur bean)
        {
            try
            {
                if (bean.Control_())
                {
                    string constr = "PORT=" + bean.Port + ";TIMEOUT=15;POOLING=True;MINPOOLSIZE=1;MAXPOOLSIZE=20;COMMANDTIMEOUT=20;COMPATIBLE= 2.0.14.3;HOST=" + bean.Adresse + ";PASSWORD=" + bean.Password + ";USER ID=" + bean.User + "";
                    NpgsqlConnection con = new NpgsqlConnection(constr);
                    con.Open();
                    return con;
                }
                else
                {
                    if (DialogResult.Retry == Messages.Erreur_Retry("Connexion impossible ! Entrer de nouveaux parametres"))
                    {
                        new IHM.Form_Serveur().Show();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                if (DialogResult.Retry == Messages.Erreur_Retry("Connexion impossible ! Entrer de nouveaux parametres"))
                {
                    new IHM.Form_Serveur().Show();
                }
                else
                {
                    Application.Exit();
                }
            }
            return null;
        }

        public static bool isConnection_()
        {
            return isConnection_(ServeurBLL.ReturnServeur());
        }

        public static bool isConnection_(ENTITE.Serveur bean)
        {
            if (bean.Control_())
            {
                NpgsqlConnection con = new NpgsqlConnection();
                try
                {
                    string constr = "PORT=" + bean.Port + ";TIMEOUT=15;POOLING=True;MINPOOLSIZE=1;MAXPOOLSIZE=20;COMMANDTIMEOUT=20;COMPATIBLE= 2.0.14.3;HOST=" + bean.Adresse + ";PASSWORD=" + bean.Password + ";USER ID=" + bean.User + "";
                    con = new NpgsqlConnection(constr);
                    con.Open();
                    return true;
                }
                catch (NpgsqlException ex)
                {
                    return false;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
            }
            return false;
        }

        public static void Deconnection(NpgsqlConnection con)
        {
            if (con != null)
            {
                try
                {
                    con.Close();
                    con.Dispose();
                }
                catch (NpgsqlException ex)
                {
                    Messages.Exception(ex);
                }
                finally
                {
                    con = null;
                }
            }
        }
    }
}
