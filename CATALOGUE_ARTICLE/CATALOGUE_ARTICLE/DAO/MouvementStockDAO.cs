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
    class MouvementStockDAO
    {
        public static Int32 currentMouvementStock(MouvementStock f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from mouvements_stock where contenu = " + f.Contenu.Id + " and article = " + f.Article.Id + "";
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

        public static MouvementStock oneMouvementStock(Int32 id)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from mouvements_stock where id = " + id;
                NpgsqlCommand Lcmd = new NpgsqlCommand(search, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                MouvementStock y = new MouvementStock();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        y.Id = id;
                        y.Entree = (Boolean)((lect["entree"] != null) ? (!lect["entree"].ToString().Trim().Equals("") ? lect["entree"] : false) : false);
                        y.Quantite = (Double)((lect["quantite"] != null) ? (!lect["quantite"].ToString().Trim().Equals("") ? lect["quantite"] : 0) : 0);
                        y.Date = (DateTime)((lect["date_save"] != null) ? (!lect["date_save"].ToString().Trim().Equals("") ? lect["date_save"] : DateTime.Now) : DateTime.Now);
                        y.Article = BLL.ArticlesBLL.One((Int32)((lect["article"] != null) ? (!lect["article"].ToString().Trim().Equals("") ? lect["article"] : 0) : 0));
                        y.Contenu = BLL.ContenuStockBLL.One((Int32)((lect["contenu"] != null) ? (!lect["contenu"].ToString().Trim().Equals("") ? lect["contenu"] : 0) : 0));
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

        public static List<MouvementStock> listMouvementStock(string query)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                NpgsqlCommand Lcmd = new NpgsqlCommand(query, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                List<MouvementStock> l = new List<MouvementStock>();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        MouvementStock y = oneMouvementStock((Int32)((lect["id"] != null) ? (!lect["id"].ToString().Trim().Equals("") ? lect["id"] : 0) : 0));
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

        public static MouvementStock saveMouvementStock(MouvementStock f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string insert = "insert into mouvements_stock (entree, quantite, article, contenu) values (" + f.Entree + "," + f.Quantite + "," + f.Article.Id + "," + f.Contenu.Id + ")";
                NpgsqlCommand cmd = new NpgsqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                f.Id = currentMouvementStock(f);
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

        public static bool updateMouvementStock(MouvementStock f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string update = "update mouvements_stock set quantite =" + f.Quantite + " , article =" + f.Article.Id + " , contenu =" + f.Contenu.Id + " where id = " + f.Id;
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

        public static bool  deleteMouvementStock(MouvementStock f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string delete = "delete from mouvements_stock where id = " + f.Id;
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
