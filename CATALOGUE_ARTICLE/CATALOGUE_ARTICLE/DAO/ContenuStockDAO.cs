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
    class ContenuStockDAO
    {
        public static Int32 currentContenuStock(ContenuStock f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from contenu_stock where stock = " + f.Stock.Id + " order by id desc limit 1";
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

        public static ContenuStock oneContenuStock(Int32 id)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from contenu_stock where id = " + id;
                NpgsqlCommand Lcmd = new NpgsqlCommand(search, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                ContenuStock y = new ContenuStock();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        y.Id = id;
                        y.Prix = (Double)((lect["prix"] != null) ? (!lect["prix"].ToString().Trim().Equals("") ? lect["prix"] : 0) : 0);
                        y.Quantite = (Double)((lect["quantite"] != null) ? (!lect["quantite"].ToString().Trim().Equals("") ? lect["quantite"] : 0) : 0);
                        y.Article = BLL.ArticlesBLL.One((Int32)((lect["article"] != null) ? (!lect["article"].ToString().Trim().Equals("") ? lect["article"] : 0) : 0));
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

        public static List<ContenuStock> listContenuStock(string query)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                NpgsqlCommand Lcmd = new NpgsqlCommand(query, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                List<ContenuStock> l = new List<ContenuStock>();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        ContenuStock y = oneContenuStock((Int32)((lect["id"] != null) ? (!lect["id"].ToString().Trim().Equals("") ? lect["id"] : 0) : 0));
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

        public static ContenuStock saveContenuStock(ContenuStock f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string insert = "insert into contenu_stock (prix, quantite, article, stock) values (" + f.Prix + "," + f.Quantite + "," + f.Article.Id + "," + f.Stock.Id + ")";
                NpgsqlCommand cmd = new NpgsqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                f.Id = currentContenuStock(f);
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

        public static bool updateContenuStock(ContenuStock f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string update = "update contenu_stock set prix =" + f.Prix + " , quantite =" + f.Quantite + " , article =" + f.Article.Id + " , stock =" + f.Stock.Id + " where id = " + f.Id;
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

        public static bool  deleteContenuStock(ContenuStock f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string delete = "delete from contenu_stock where id = " + f.Id;
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
