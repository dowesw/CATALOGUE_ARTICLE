using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Win32;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.BLL;

namespace CATALOGUE_ARTICLE.TOOLS
{
    class Licence
    {

        public static void deleteLicence()
        {
            string chemin = Chemins.getCheminInformation();
            RegistryKey Nkey = Registry.CurrentUser;
            try
            {
                RegistryKey valKey = Nkey.OpenSubKey(@chemin, true);
                if (valKey != null)
                {
                    Nkey.DeleteSubKey(@chemin);
                }
            }
            catch (Exception e)
            {
                Messages.Exception(e);
            }
            finally
            {
                Nkey.Close();
            }
        }

        public static void createLicence()
        {
            string chemin = Chemins.getCheminInformation();
            RegistryKey Nkey = Registry.CurrentUser;
            try
            {
                RegistryKey valKey = Nkey.OpenSubKey(@chemin, true);
                if (valKey == null)
                {
                    Nkey.CreateSubKey(@chemin);
                    valKey = Nkey.OpenSubKey(@chemin, true);

                    valKey.SetValue("authentify", false);
                    valKey.SetValue("licence", "696-668-969-694-234-044");
                    valKey.SetValue("date_load", DateTime.Now);
                }
                else
                {
                    if ((valKey.GetValue("authentify") == null || valKey.GetValue("authentify").Equals("")) &&
                        (valKey.GetValue("licence") == null || valKey.GetValue("licence").Equals("")) &&
                        (valKey.GetValue("date_load") == null || valKey.GetValue("date_load").Equals("")))
                    {
                        valKey.SetValue("authentify", false);
                        valKey.SetValue("licence", "696-668-969-694-234-044");
                        valKey.SetValue("date_load", DateTime.Now);
                    }
                }
            }
            catch (Exception e)
            {
                Messages.Exception(e);
            }
            finally
            {
                Nkey.Close();
            }
        }

        public static Object[] returnLicence()
        {
            string chemin = Chemins.getCheminInformation();
            RegistryKey Nkey = Registry.CurrentUser;
            try
            {
                Object[] lic = new Object[3];
                RegistryKey valKey = Nkey.OpenSubKey(@chemin, true);
                if (valKey != null)
                {
                    lic[0] = (valKey.GetValue("authentify") != null ? valKey.GetValue("authentify") : false);
                    lic[1] = (valKey.GetValue("licence") != null ? valKey.GetValue("licence") : "");
                    lic[2] = (valKey.GetValue("date_load") != null ? valKey.GetValue("date_load") : DateTime.Now);
                }
                return lic;
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

        public static bool verifyLicence()
        {
            try
            {
                Object[] lic = returnLicence();
                if (lic != null)
                {
                    Constantes.ACTIVE = Convert.ToBoolean(lic[0]);
                    if (!Constantes.ACTIVE)
                    {
                        DateTime instal = Convert.ToDateTime(lic[2]);
                        DateTime day = instal.AddDays(Constantes.MAX_ESSAIE);
                        if (day < DateTime.Now)
                        {
                            Constantes.TRIAL_ESSAIE = 0;                            
                            return false;
                        }
                        else
                        {
                            TimeSpan span = day.Subtract(DateTime.Now);
                            Constantes.TRIAL_ESSAIE = span.Days;
                            return true;
                        }
                    }
                    else
                    {
                        return true;
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

        public static bool verifyKeyLicence(string key)
        {
            try
            {
                Object[] lic = returnLicence();
                if (lic != null)
                {
                    string valeur = Convert.ToString(lic[1]);
                    var t = valeur + " = " +key;
                    if (valeur.Trim().Equals(key.Trim()))
                    {
                        Constantes.ACTIVE = true;
                        string chemin = Chemins.getCheminInformation();
                        RegistryKey Nkey = Registry.CurrentUser;
                        try
                        {
                            RegistryKey valKey = Nkey.OpenSubKey(@chemin, true);
                            if (valKey == null)
                            {
                                Nkey.CreateSubKey(@chemin);
                                valKey = Nkey.OpenSubKey(@chemin, true);
                            }
                            valKey.SetValue("authentify", true);
                            return true;
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
                return false;
            }
            catch (Exception e)
            {
                Messages.Exception(e);
                return false;
            }
        }
    }
}
