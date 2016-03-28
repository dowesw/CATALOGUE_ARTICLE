using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using Microsoft.Win32;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.BLL;

namespace CATALOGUE_ARTICLE.TOOLS
{
    class Utils
    {

        static public Form Form_Open = null;

        static public string[] MOIS = new string[] { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };


        public static string jourSemaine(DateTime date)
        {
            string jour = date.ToString("dddd", new CultureInfo("fr-FR").DateTimeFormat);
            return jour;
        }

        public delegate void delegateUpdateListBox(string text);

        public static void Log(string logMessage)
        {
            string file = Chemins.getCheminParametre() + "Log.txt";
            if (!File.Exists(file))
                File.Create(file);
            using (StreamWriter log = File.AppendText(file))
            {
                WriteLog(logMessage, log);
            }
        }

        public static void WriteLog(string logMessage, TextWriter log)
        {
            log.Write("\r\nLog Entry : ");
            log.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            log.WriteLine("  :");
            log.WriteLine("  :{0}", logMessage);
            log.WriteLine("-------------------------------");
        }

        public static List<List<string>> DumpLog()
        {
            List<List<string>> list = new List<List<string>>();
            string file = Chemins.getCheminParametre() + "Log.txt";
            if (File.Exists(file))
            {
                using (StreamReader r = File.OpenText(file))
                {
                    list.Add(ReadLog(r));
                }
            }
            return list;
        }

        public static List<string> ReadLog(StreamReader log)
        {
            List<string> list = new List<string>();
            string line;
            while ((line = log.ReadLine()) != null)
            {
                list.Add(line);
            }
            return list;
        }

        public static byte[] ConvertStringToByte(string text)
        {
            String[] tempAry = text.Split('-');
            byte[] decBytes2 = new byte[tempAry.Length];
            for (int i = 0; i < tempAry.Length; i++)
                decBytes2[i] = Convert.ToByte(tempAry[i], 16);
            return decBytes2;
        }

        public static double ParsedMaxDouble(String value)
        {
            String d = Double.MaxValue.ToString();
            if (value.Equals(d))
            {
                return Int64.MaxValue;
            }
            return Convert.ToDouble(value);
        }

        public static int GetRowData(DataGridView data, String id)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i].Cells[0].Value != null)
                {
                    String l = data.Rows[i].Cells[0].Value.ToString();
                    if (l.Equals(id))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static int GetRowData(DataGridView data, long id)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i].Cells[0].Value != null)
                {
                    long l = Convert.ToInt32(data.Rows[i].Cells[0].Value);
                    if (l.Equals(id))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public static bool verifyParametre()
        {
            Serveur serveur = BLL.ServeurBLL.ReturnServeur();
            if (serveur != null)
            {
                if (!serveur.Adresse.Equals("") && !serveur.Port.Equals(0) && !serveur.Database.Equals("") && !serveur.User.Equals("") && !serveur.Password.Equals(""))
                {
                    return true;
                }
            }
            return false;
        }

        public static double milliseconds()
        {
            DateTime baseDate = new DateTime(1970, 1, 1);
            TimeSpan diff = DateTime.Now - baseDate;
            return diff.TotalMilliseconds;
        }

        public static void removeFrom(string name)
        {
            List<string> l = new List<string>();
            for (int i = 0; i < Constantes.f_first.Count; i++)
            {
                string s = Constantes.f_first[i];
                l.Add(s);
            }
            for (int i = 0; i < l.Count; i++)
            {
                string s = l[i];
                if (s.Trim().Equals(name.Trim(), StringComparison.CurrentCultureIgnoreCase))
                {
                    Constantes.f_first.Remove(name);
                }
            }
        }

        public static void addFrom(string name)
        {
            removeFrom(name);
            Constantes.f_first.Add(name);
        }

        public static string ReferenceElement(string type)
        {
            if (!(type == null || type.Trim().Equals("")))
            {
                String reference = "";
                String apercu = type + "/";
                if ((int)DateTime.Now.Day > 9)
                {
                    apercu += (int)DateTime.Now.Day;
                }
                if ((int)DateTime.Now.Day < 10)
                {
                    apercu += ("0" + (int)DateTime.Now.Day);
                }
                if ((int)DateTime.Now.Month > 9)
                {
                    apercu += (int)DateTime.Now.Month;
                }
                if ((int)DateTime.Now.Month < 10)
                {
                    apercu += ("0" + (int)DateTime.Now.Month);
                }
                apercu += DateTime.Now.Year.ToString().Substring(2);
                apercu += "/";
                DocStock f = DocStockBLL.One(apercu + "%");
                if ((f != null) ? !(f.Reference == null || f.Reference.Trim().Equals("")) : false)
                {
                    reference = f.Reference;
                }
                else
                {
                    reference = "";
                }

                if (!reference.Trim().Equals(""))
                {
                    String partieNum = reference.Replace(apercu, "");
                    if (apercu.Equals(reference.Substring(0, (reference.Length - partieNum.Length))))
                    {
                        int num = Convert.ToInt16(partieNum);
                        if (Convert.ToString(num + 1).Length > 4)
                        {
                            Messages.ShowErreur("Vous ne pouvez plus ajouter ce type de document");
                            return "";
                        }
                        else
                        {
                            for (int i = 0; i < (4 - Convert.ToString(num + 1).Length); i++)
                            {
                                apercu += "0";
                            }
                        }
                        apercu += Convert.ToString(Convert.ToInt16(partieNum) + 1);
                    }
                    else
                    {
                        for (int i = 0; i < 4 - 1; i++)
                        {
                            apercu += "0";
                        }
                        apercu += "1";
                    }
                }
                else
                {
                    for (int i = 0; i < 4 - 1; i++)
                    {
                        apercu += "0";
                    }
                    apercu += "1";
                }
                return apercu;
            }
            else
            {
                Messages.ShowErreur("Le type du document est incorrect!");
            }
            return null;
        }
    }
}
