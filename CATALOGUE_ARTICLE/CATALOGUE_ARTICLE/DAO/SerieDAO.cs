using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using Npgsql;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.DAO
{
    class SerieDAO
    {
        public static Int32 currentSerie(Serie f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from serie where reference = '" + f.Reference + "' and designation = '" + f.Designation + "' and description = '" + f.Description + "'";
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

        public static Serie oneSerie(Int32 id)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from serie where id = " + id;
                NpgsqlCommand Lcmd = new NpgsqlCommand(search, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                Serie y = new Serie();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        y.Id = id;
                        y.Reference = lect["reference"].ToString();
                        y.Designation = lect["designation"].ToString();
                        y.Description = lect["description"].ToString();
                        y.Marque = BLL.MarqueBLL.One((Int32)((lect["marque"] != null) ? (!lect["marque"].ToString().Trim().Equals("") ? lect["marque"] : 0) : 0));
                        y.Update = true;
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

        public static List<Serie> listSerie(string query)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                NpgsqlCommand Lcmd = new NpgsqlCommand(query, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                List<Serie> l = new List<Serie>();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        Serie y = oneSerie((Int32)((lect["id"] != null) ? (!lect["id"].ToString().Trim().Equals("") ? lect["id"] : 0) : 0));
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

        public static Serie saveSerie(Serie f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string insert = "insert into serie (reference,designation,description,marque) values ('" + f.Reference + "','" + f.Designation + "','" + f.Description + "'," + f.Marque.Id + ")";
                NpgsqlCommand cmd = new NpgsqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                f.Id = currentSerie(f);
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

        public static bool updateSerie(Serie f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string update = "update serie set reference ='" + f.Reference + "' , designation ='" + f.Designation + "', description='" + f.Description + "', marque=" + f.Marque.Id + " where id = " + f.Id;
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

        public static bool deleteSerie(Serie f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string delete = "delete from serie where id = " + f.Id;
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
