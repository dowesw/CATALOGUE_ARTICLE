using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Npgsql;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.DAO
{
    class AutorisationRessourceDAO
    {
        public static Int32 currentAutorisationRessource(AutorisationRessource f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from autorisation_ressource where niveau = " + f.Niveau.Id + " and ressource = " + f.Ressource.Id + "";
                NpgsqlCommand Lcmd = new NpgsqlCommand(search, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                Int32 id = new Int32();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        id = (Int32)((lect["id"] != null) ? (!lect["id"].ToString().Trim().Equals("") ? lect["id"] : 0) : 0);
                    }
                }
                return id;
            }
            catch (NpgsqlException e)
            {
                Messages.Exception(e);
                return 0;
            }
            finally
            {
                Connexion.Deconnection(con);
            }
        }

        public static AutorisationRessource oneAutorisationRessource(Int32 id)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from autorisation_ressource where id = " + id;
                NpgsqlCommand Lcmd = new NpgsqlCommand(search, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                AutorisationRessource y = new AutorisationRessource();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        y.Id = id;
                        y.Niveau = BLL.NiveauAccesBLL.One((Int32)((lect["niveau"] != null) ? (!lect["niveau"].ToString().Trim().Equals("") ? lect["niveau"] : 0) : 0));
                        y.Ressource = BLL.RessourcesBLL.One((Int32)((lect["ressource"] != null) ? (!lect["ressource"].ToString().Trim().Equals("") ? lect["ressource"] : 0) : 0));
                        y.Update = (Boolean)((lect["acces"] != null) ? (!lect["acces"].ToString().Trim().Equals("") ? lect["acces"] : false) : false);
                    }
                }
                return y;
            }
            catch (NpgsqlException e)
            {
                Messages.Exception(e);
                return null;
            }
            finally
            {
                Connexion.Deconnection(con);
            }
        }

        public static List<AutorisationRessource> listAutorisationRessource(string query)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                NpgsqlCommand Lcmd = new NpgsqlCommand(query, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                List<AutorisationRessource> l = new List<AutorisationRessource>();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        AutorisationRessource y = oneAutorisationRessource((Int32)((lect["id"] != null) ? (!lect["id"].ToString().Trim().Equals("") ? lect["id"] : 0) : 0));
                        l.Add(y);
                    }
                }
                return l;
            }
            catch (NpgsqlException e)
            {
                Messages.Exception(e);
                return null;
            }
            finally
            {
                Connexion.Deconnection(con);
            }
        }

        public static AutorisationRessource saveAutorisationRessource(AutorisationRessource f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string insert = "insert into autorisation_ressource (niveau, ressource, acces) values (" + f.Niveau.Id + "," + f.Ressource.Id + ",'" + f.Update + "')";
                NpgsqlCommand cmd = new NpgsqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                f.Id = currentAutorisationRessource(f);
                return f;
            }
            catch (NpgsqlException e)
            {
                Messages.Exception(e);
                return null;
            }
            finally
            {
                Connexion.Deconnection(con);
            }
        }

        public static bool updateAutorisationRessource(AutorisationRessource f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string update = "update autorisation_ressource set acces ='" + f.Update + "' where id = " + f.Id;
                NpgsqlCommand cmd = new NpgsqlCommand(update, con);
                cmd.ExecuteNonQuery();
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

        public static bool deleteAutorisationRessource(AutorisationRessource f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string delete = "delete from autorisation_ressource where id = " + f.Id;
                NpgsqlCommand cmd = new NpgsqlCommand(delete, con);
                cmd.ExecuteNonQuery();
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
