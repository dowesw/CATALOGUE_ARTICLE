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
    class DocStockDAO
    {
        public static Int32 currentDocStock(DocStock f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from doc_stocks where reference = '" + f.Reference + "' and date_doc = '" + f.Date + "'";
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

        public static DocStock oneDocStock(string id)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from doc_stocks where reference like '" + id + "'";
                NpgsqlCommand Lcmd = new NpgsqlCommand(search, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                DocStock y = new DocStock();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        y.Id = (Int32)((lect["id"] != null) ? (!lect["id"].ToString().Trim().Equals("") ? lect["id"] : 0) : 0);
                        y.Reference = lect["reference"].ToString();
                        y.Type = lect["type_doc"].ToString();
                        y.Date = (DateTime)((lect["date_doc"] != null) ? (!lect["date_doc"].ToString().Trim().Equals("") ? lect["date_doc"] : DateTime.Now) : DateTime.Now);
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

        public static DocStock oneDocStock(Int32 id)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from doc_stocks where id = " + id;
                NpgsqlCommand Lcmd = new NpgsqlCommand(search, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                DocStock y = new DocStock();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        y.Id = id;
                        y.Reference = lect["reference"].ToString();
                        y.Type = lect["type_doc"].ToString();
                        y.Date = (DateTime)((lect["date_doc"] != null) ? (!lect["date_doc"].ToString().Trim().Equals("") ? lect["date_doc"] : DateTime.Now) : DateTime.Now);
                        y.Contenus = BLL.ContenuStockBLL.List("select * from contenu_stock where stock = " + id);
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

        public static List<DocStock> listDocStock(string query)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                NpgsqlCommand Lcmd = new NpgsqlCommand(query, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                List<DocStock> l = new List<DocStock>();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        DocStock y = oneDocStock((Int32)((lect["id"] != null) ? (!lect["id"].ToString().Trim().Equals("") ? lect["id"] : 0) : 0));
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

        public static DocStock saveDocStock(DocStock f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string insert = "insert into doc_stocks (reference, type_doc, date_doc) values ('" + f.Reference + "','" + f.Type + "','" + f.Date + "')";
                NpgsqlCommand cmd = new NpgsqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                f.Id = currentDocStock(f);
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

        public static bool updateDocStock(DocStock f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string update = "update doc_stocks set reference ='" + f.Reference + "' , type_doc = '" + f.Type + "' , date_doc = '" + f.Date + "' where id = " + f.Id;
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

        public static bool  deleteDocStock(DocStock f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string delete = "delete from doc_stocks where id = " + f.Id;
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
