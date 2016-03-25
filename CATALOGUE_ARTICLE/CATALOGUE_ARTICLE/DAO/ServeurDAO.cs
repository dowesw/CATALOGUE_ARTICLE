 using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Npgsql;
using System.Runtime.Serialization.Formatters.Binary;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.TOOLS;
using Microsoft.Win32;

namespace CATALOGUE_ARTICLE.DAO
{
    class ServeurDAO
    {
        static string chemin = Chemins.getCheminParametre();

        public static bool getCreateServeur(Serveur serveur)
        {
            RegistryKey Nkey = Registry.CurrentUser;
            try
            {
                RegistryKey valKey = Nkey.OpenSubKey(@chemin, true);
                if (valKey == null)
                {
                    Nkey.CreateSubKey(@chemin);
                    valKey = Nkey.OpenSubKey(@chemin, true);
                }
                valKey.SetValue("adresse", serveur.Adresse);
                valKey.SetValue("port", serveur.Port);
                valKey.SetValue("database", serveur.Database);
                valKey.SetValue("user", serveur.User);
                valKey.SetValue("password", serveur.Password);
            }
            catch (Exception e)
            {
                Messages.Exception(e);
                return false;
            }
            finally
            {
                Nkey.Close();
            }
            return true;
        }

        public static Serveur getReturnServeur()
        {
            RegistryKey Nkey = Registry.CurrentUser;
            try
            {
                Serveur serveur = new Serveur();
                RegistryKey valKey = Nkey.OpenSubKey(@chemin, true);
                if (valKey == null)
                {
                    serveur.Adresse = "";
                    serveur.Port = 0;
                    serveur.Database = "";
                    serveur.User = "";
                    serveur.Password = "";
                }
                else
                {
                    serveur.Adresse = (string)(valKey.GetValue("adresse") != null ? valKey.GetValue("adresse") : "");
                    serveur.Port = (Int32)(valKey.GetValue("port") != null ? valKey.GetValue("port") : 0);
                    serveur.Database = (string)(valKey.GetValue("database") != null ? valKey.GetValue("database") : "");
                    serveur.User = (string)(valKey.GetValue("user") != null ? valKey.GetValue("user") : "");
                    serveur.Password = (string)(valKey.GetValue("password") != null ? valKey.GetValue("password") : "");
                    valKey.Close();
                }
                return serveur;
            }
            catch (Exception e)
            {
                Messages.Exception(e);
                return null;
            }
            finally
            {
                Nkey.Close();
            }
        }

        public static bool data(FamillesArticle f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {

                return true;
            }
            catch (NpgsqlException e)
            {
                Messages.Exception(e);
                return false;
            }
            finally
            {
                Connexion.Deconnection(con);
            }
        }
    }
}
