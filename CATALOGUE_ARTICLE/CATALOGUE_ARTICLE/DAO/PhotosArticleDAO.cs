using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Npgsql;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.DAO
{
    class PhotosArticleDAO
    {
        public static Int32 currentPhotosArticle(PhotosArticle f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from photo_article where nom = '" + f.Nom + "' and article = " + f.Article.Id + "";
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

        public static PhotosArticle onePhotosArticle(Int32 id)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from photo_article where id = " + id;
                NpgsqlCommand Lcmd = new NpgsqlCommand(search, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                PhotosArticle y = new PhotosArticle();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        y.Id = id;
                        y.Nom = lect["nom"].ToString();
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

        public static List<PhotosArticle> listPhotosArticle(string query)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                NpgsqlCommand Lcmd = new NpgsqlCommand(query, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                List<PhotosArticle> l = new List<PhotosArticle>();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        PhotosArticle y = onePhotosArticle((Int32)((lect["id"] != null) ? (!lect["id"].ToString().Trim().Equals("") ? lect["id"] : 0) : 0));
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

        public static PhotosArticle savePhotosArticle(PhotosArticle f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string path = f.Nom;

                f.Nom = Utils.milliseconds() + Path.GetExtension(path);
                string insert = "insert into photo_article (nom, article) values ('" + f.Nom + "'," + f.Article.Id + ")";
                NpgsqlCommand cmd = new NpgsqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                f.Id = currentPhotosArticle(f);

                string chemin = Chemins.getCheminArticle(f.Article.Id.ToString()) + f.Nom;
                System.IO.File.Copy(path, chemin, true);

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

        public static bool updatePhotosArticle(PhotosArticle f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string update = "update photo_article set nom ='" + f.Nom + "' , article =" + f.Article.Id + " where id = " + f.Id;
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

        public static bool  deletePhotosArticle(PhotosArticle f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string delete = "delete from photo_article where id = " + f.Id;
                NpgsqlCommand cmd = new NpgsqlCommand(delete, con);
                cmd.ExecuteNonQuery();

                string chemin = Chemins.getCheminArticle(f.Article.Id.ToString()) + f.Nom;
                if (File.Exists(chemin))
                {
                    File.Delete(chemin);
                }
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
