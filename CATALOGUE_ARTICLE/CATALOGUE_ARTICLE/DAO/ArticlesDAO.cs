using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.IO;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.DAO
{
    class ArticlesDAO
    {
        public static Int32 currentArticles(Articles f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from articles where reference = '" + f.Reference + "' and designation = '" + f.Designation + "' and description = '" + f.Description + "' and marque = '" + f.Marque + "'";
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

        public static double stock(Articles article)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                NpgsqlCommand Ls = new NpgsqlCommand("select public.stock(" + article.Id + ")", con);
                return Convert.ToDouble(Ls.ExecuteScalar());
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

        public static Articles oneArticles(Int32 id)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from articles where id = " + id;
                NpgsqlCommand Lcmd = new NpgsqlCommand(search, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                Articles y = new Articles();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        y.Id = id;
                        y.Reference = lect["reference"].ToString();
                        y.Designation = lect["designation"].ToString();
                        y.Description = lect["description"].ToString();
                        y.Marque = lect["marque"].ToString();
                        y.Puv = (Double)((lect["puv"] != null) ? (!lect["puv"].ToString().Trim().Equals("") ? lect["puv"] : 0) : 0);
                        y.Pua = (Double)((lect["pua"] != null) ? (!lect["pua"].ToString().Trim().Equals("") ? lect["pua"] : 0) : 0);
                        y.DateSave = (DateTime)((lect["date_save"] != null) ? (!lect["date_save"].ToString().Trim().Equals("") ? lect["date_save"] : DateTime.Now) : DateTime.Now);
                        y.DateUpdate = (DateTime)((lect["date_update"] != null) ? (!lect["date_update"].ToString().Trim().Equals("") ? lect["date_update"] : DateTime.Now) : DateTime.Now);
                        y.Famille = BLL.FamillesArticleBLL.One((Int32)((lect["famille"] != null) ? (!lect["famille"].ToString().Trim().Equals("") ? lect["famille"] : 0) : 0));
                        y.Photos = BLL.PhotosArticleBLL.List("select * from photo_article where article = " + id);
                        y.Stock = stock(new Articles(id));
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

        public static Articles oneArticles(string id)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from articles where designation = '" + id + "'";
                NpgsqlCommand Lcmd = new NpgsqlCommand(search, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                Articles y = new Articles();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        y = oneArticles((Int32)((lect["id"] != null) ? (!lect["id"].ToString().Trim().Equals("") ? lect["id"] : 0) : 0));
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

        public static List<Articles> listArticles(string query)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                NpgsqlCommand Lcmd = new NpgsqlCommand(query, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                List<Articles> l = new List<Articles>();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        Articles y = oneArticles((Int32)((lect["id"] != null) ? (!lect["id"].ToString().Trim().Equals("") ? lect["id"] : 0) : 0));
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

        public static Articles saveArticles(Articles f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string insert = "insert into articles (reference, designation, description, marque, puv, pua, date_save, date_update) values "
                    + "('" + f.Reference + "','" + f.Designation + "','" + f.Description + "','" + f.Marque + "'," + f.Puv + "," + f.Pua + ",'" + f.DateSave + "','" + f.DateUpdate + "')";
                if (f.Famille != null ? f.Famille.Id > 0 : false)
                {
                    insert = "insert into articles (reference, designation, description, marque, puv, pua, date_save, date_update, famille) values "
                    + "('" + f.Reference + "','" + f.Designation + "','" + f.Description + "','" + f.Marque + "'," + f.Puv + "," + f.Pua + ",'" + f.DateSave + "','" + f.DateUpdate + "'," + f.Famille.Id + ")";
                }
                NpgsqlCommand cmd = new NpgsqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                f.Id = currentArticles(f);
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

        public static bool updateArticles(Articles f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string update = "update articles set reference = '" + f.Reference + "', designation = '" + f.Designation + "', description = '" + f.Description + "',"
                        + " marque = '" + f.Marque + "', puv = " + f.Puv + ", pua = " + f.Pua + ", date_save = '" + f.DateSave + "', date_update = '" + f.DateUpdate + "',"
                        + " where id = " + f.Id;
                if (f.Famille != null ? f.Famille.Id > 0 : false)
                {
                    update = "update articles set reference = '" + f.Reference + "', designation = '" + f.Designation + "', description = '" + f.Description + "',"
                        + " marque = '" + f.Marque + "', puv = " + f.Puv + ", pua = " + f.Pua + ", date_save = '" + f.DateSave + "', date_update = '" + f.DateUpdate + "',"
                        + " famille = " + f.Famille.Id + " where id = " + f.Id;
                }
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

        public static bool deleteArticles(Articles f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                foreach (PhotosArticle p in f.Photos)
                {
                    p.Article = f;
                    BLL.PhotosArticleBLL.Delete(p);
                }

                string delete = "delete from articles where id = " + f.Id;
                NpgsqlCommand cmd = new NpgsqlCommand(delete, con);
                cmd.ExecuteNonQuery();

                DirectoryInfo dossier = new DirectoryInfo(Chemins.getCheminArticle(f.Id.ToString()));
                if (dossier.Exists)
                    dossier.Delete();
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
