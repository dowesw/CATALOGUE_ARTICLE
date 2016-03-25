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
    class UsersDAO
    {
        public static Int32 currentUsers(Users f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from users where nom = '" + f.Nom + "' and prenom = '" + f.Prenom + "' and identifiant = '" + f.Identifiant + "'";
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

        public static Users oneUsers(Int32 id)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from users where id = " + id;
                NpgsqlCommand Lcmd = new NpgsqlCommand(search, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                Users y = new Users();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        y.Id = id;
                        y.Nom = lect["nom"].ToString();
                        y.Prenom = lect["prenom"].ToString();
                        y.Identifiant = lect["identifiant"].ToString();
                        y.Password = lect["mot_passe"].ToString();
                        y.Photo = lect["photo"].ToString();
                        y.Actif = (Boolean)((lect["actif"] != null) ? (!lect["actif"].ToString().Trim().Equals("") ? lect["actif"] : false) : false);
                        y.Niveau = BLL.NiveauAccesBLL.One((Int32)((lect["niveau"] != null) ? (!lect["niveau"].ToString().Trim().Equals("") ? lect["niveau"] : 0) : 0));
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

        public static List<Users> listUsers(string query)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                NpgsqlCommand Lcmd = new NpgsqlCommand(query, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                List<Users> l = new List<Users>();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        Users y = oneUsers((Int32)((lect["id"] != null) ? (!lect["id"].ToString().Trim().Equals("") ? lect["id"] : 0) : 0));
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

        public static Users saveUsers(Users f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string path = "";
                if (!(f.Photo == null || f.Photo.Trim().Equals("")))
                {
                    path = f.Photo;
                    f.Photo = Utils.milliseconds() + Path.GetExtension(path);
                }
                string insert = "insert into users (nom, prenom, identifiant, mot_passe, photo, actif, niveau) values "+
                    "('" + f.Nom + "','" + f.Prenom + "','" + f.Identifiant + "','" + f.Password + "','" + f.Photo + "','" + f.Actif + "'," + f.Niveau.Id + ")";
                NpgsqlCommand cmd = new NpgsqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                f.Id = currentUsers(f);

                if (!(path == null || path.Trim().Equals("")))
                {
                    string chemin = Chemins.getCheminUsers(f.Id.ToString()) + f.Photo;
                    System.IO.File.Copy(path, chemin, true);
                }

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

        public static bool updateUsers(Users f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string update = "update users set nom = '" + f.Nom + "', prenom = '" + f.Prenom + "', identifiant = '" + f.Identifiant + "', mot_passe = '" + f.Password + "',"
                + "photo = '" + f.Photo + "', actif =" + f.Actif + ", niveau = " + f.Niveau.Id + " where id =" + f.Id;
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

        public static bool deleteUsers(Users f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string delete = "delete from users where id = " + f.Id;
                NpgsqlCommand cmd = new NpgsqlCommand(delete, con);
                cmd.ExecuteNonQuery();

                string chemin = Chemins.getCheminUsers(f.Id.ToString()) + f.Photo;
                if (File.Exists(chemin))
                {
                    File.Delete(chemin);
                }
                DirectoryInfo dossier = new DirectoryInfo(Chemins.getCheminUsers(f.Id.ToString()));
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

        public static bool deletePhotoUsers(Users f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string delete = "update users set photo = '' where id = " + f.Id;
                NpgsqlCommand cmd = new NpgsqlCommand(delete, con);
                cmd.ExecuteNonQuery();

                string chemin = Chemins.getCheminUsers(f.Id.ToString()) + f.Photo;
                if (File.Exists(chemin))
                {
                    File.Delete(chemin);
                }
                DirectoryInfo dossier = new DirectoryInfo(Chemins.getCheminUsers(f.Id.ToString()));
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

        public static bool updatePhotoUsers(Users f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string path = "";
                if (!(f.Photo == null || f.Photo.Trim().Equals("")))
                {
                    path = f.Photo;
                    f.Photo = Utils.milliseconds() + Path.GetExtension(path);
                }

                string delete = "update users set photo = '" + f.Photo + "' where id = " + f.Id;
                NpgsqlCommand cmd = new NpgsqlCommand(delete, con);
                cmd.ExecuteNonQuery();

                if (!(path == null || path.Trim().Equals("")))
                {
                    string chemin = Chemins.getCheminUsers(f.Id.ToString()) + f.Photo;
                    System.IO.File.Copy(path, chemin, true);
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
