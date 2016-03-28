using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.IO;
using Microsoft.Win32;
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

        public static bool installServeurDb()
        {

            return false;
        }

        public static bool createDb()
        {
            try
            {
                if (isConnection_())
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
                    }
                    else
                    {
                        Application.Exit();
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
    }
}
