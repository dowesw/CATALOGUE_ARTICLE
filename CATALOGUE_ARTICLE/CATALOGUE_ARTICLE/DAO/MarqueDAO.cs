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
    class MarqueDAO
    {
        public static Int32 currentMarque(Marque f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from marque where reference = '" + f.Reference + "' and designation = '" + f.Designation + "' and description = '" + f.Description + "'";
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

        public static Marque oneMarque(Int32 id)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from marque where id = " + id;
                NpgsqlCommand Lcmd = new NpgsqlCommand(search, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                Marque y = new Marque();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        y.Id = id;
                        y.Reference = lect["reference"].ToString();
                        y.Designation = lect["designation"].ToString();
                        y.Description = lect["description"].ToString();
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

        public static List<Marque> listMarque(string query)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                NpgsqlCommand Lcmd = new NpgsqlCommand(query, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                List<Marque> l = new List<Marque>();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        Marque y = oneMarque((Int32)((lect["id"] != null) ? (!lect["id"].ToString().Trim().Equals("") ? lect["id"] : 0) : 0));
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

        public static Marque saveMarque(Marque f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string insert = "insert into marque (reference,designation,description) values ('" + f.Reference + "','" + f.Designation + "','" + f.Description + "')";
                NpgsqlCommand cmd = new NpgsqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                f.Id = currentMarque(f);
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

        public static bool updateMarque(Marque f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string update = "update marque set reference ='" + f.Reference + "' , designation ='" + f.Designation + "', description='" + f.Description + "' where id = " + f.Id;
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

        public static bool deleteMarque(Marque f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string delete = "delete from marque where id = " + f.Id;
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
