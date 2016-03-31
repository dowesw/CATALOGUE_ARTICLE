using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.IO;
using Npgsql;

namespace CATALOGUE_ARTICLE.TOOLS
{
    class Database
    {
        private static bool createBd()
        {
            NpgsqlConnection con = Connexion.Connection_();
            try
            {
                NpgsqlCommand Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_DATABASE, con);
                Lcmd.ExecuteNonQuery();
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

        public static bool createDb()
        {
            if (!createBd())
            {
                return false;
            }
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                NpgsqlCommand Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TABLE_PARAMETRE, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TABLE_FAMILLE, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TABLE_ARTICLE, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TABLE_PHOTO, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TABLE_DOCSTOCK, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TABLE_CONTENUSTOCK, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TABLE_MOUVSTOCK, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TABLE_NIVEAUACCES, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TABLE_USERS, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TABLE_FORMULAIRE, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TABLE_RESSOURCE, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TABLE_ACCESFORMULAIRE, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TABLE_ACCESRESSOURCE, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_FCT_STOCK, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_FCT_DELETECONTENU, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_FCT_INSERTCONTENU, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_FCT_UPDATECONTENU, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TRIG_DELETECONTENU, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TRIG_INSERTCONTENU, con);
                Lcmd.ExecuteNonQuery();
                Lcmd = new NpgsqlCommand(global::CATALOGUE_ARTICLE.Properties.Resources.CREATE_TRIG_UPDATECONTENU, con);
                Lcmd.ExecuteNonQuery();
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

        public static bool installServeurDb()
        {

            return false;
        }

        public static bool createDb_()
        {
            try
            {
                if (Connexion.isConnection_())
                {
                    //AddCheminServeur();
                    string chemin = Chemins.getCheminScript() + Constantes.FILE_SEPARATOR;
                    if (File.Exists(chemin + "create_db.bat"))
                    {
                        System.Diagnostics.Process proc = new System.Diagnostics.Process();
                        proc.StartInfo.WorkingDirectory = chemin;
                        proc.StartInfo.FileName = chemin + "create_db.bat";
                        proc.StartInfo.Arguments = chemin;
                        proc.StartInfo.RedirectStandardError = false;
                        proc.StartInfo.RedirectStandardOutput = false;
                        proc.StartInfo.UseShellExecute = false;
                        proc.Start();
                        proc.WaitForExit();
                        return true;
                    }
                    else
                    {
                        Messages.ShowErreur("Fichier bat inexistant");
                    }
                }
                else
                {
                    if (DialogResult.Retry == Messages.Erreur_Retry("Connexion impossible ! Entrer de nouveaux parametres"))
                    {
                        new IHM.Form_Serveur().Show();
                        Application.Run();
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                Messages.Exception(e);
                return false;
            }
        }

        public static void AddCheminServeur()
        {
            RegistryKey Nkey = Registry.LocalMachine;
            try
            {
                RegistryKey mesCles = Nkey.OpenSubKey(@"Software\PostgreSQL\Installations", false);
                if (mesCles != null)
                {
                    var h = 0;
                    String[] names = mesCles.GetSubKeyNames();
                    foreach (string n in names)
                    {
                        mesCles = Nkey.OpenSubKey(@"Software\PostgreSQL\Installations\" + n, false);
                        if (mesCles != null)
                        {
                            string chemin = (string)mesCles.GetValue("Base directory");
                            if (chemin != null)
                            {
                                string v_ = chemin + "\\bin";
                                string keyName = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment";
                                System.Security.Permissions.EnvironmentPermission permissions = new System.Security.Permissions.EnvironmentPermission(System.Security.Permissions.EnvironmentPermissionAccess.Write, "Path");
                                permissions.Demand();
                                string path_ = (string)Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
                                //Environment.SetEnvironmentVariable("Path", path_ + ";" + v_, EnvironmentVariableTarget.Machine);

                                using (RegistryKey regPath = Registry.LocalMachine.OpenSubKey(keyName, true))
                                {
                                    string path = (string)regPath.GetValue("Path", "", RegistryValueOptions.DoNotExpandEnvironmentNames);
                                    foreach (string v in path.Split(';'))
                                    {
                                        if (v.Trim().Equals((string)(v_).Trim(), StringComparison.OrdinalIgnoreCase))
                                        {
                                            return;
                                        }
                                    }
                                    regPath.SetValue("Path", path + ";" + v_, RegistryValueKind.ExpandString);
                                }
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception er)
            {
                Messages.Exception(er);
            }
            finally
            {
                Nkey.Close();
            }
        }

        public static bool verifyServeurDb()
        {
            RegistryKey Nkey = Registry.LocalMachine;
            try
            {
                RegistryKey mesCles = Nkey.OpenSubKey(@"Software\PostgreSQL", false);
                if (mesCles != null)
                    return true;
                return false;
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
        }
    }
}
