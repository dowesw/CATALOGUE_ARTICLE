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
    class FamillesArticleDAO
    {
        public static Int32 currentFamillesArticle(FamillesArticle f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select * from familles_article where reference = '" + f.Reference + "' and designation = '" + f.Designation + "' and description = '" + f.Description + "'";
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

        public static FamillesArticle oneFamillesArticle(Int32 id)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                String search = "select f.*, p.designation as designation_ from familles_article f left join familles_article p on f.parent = p.id where f.id = " + id;
                NpgsqlCommand Lcmd = new NpgsqlCommand(search, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                FamillesArticle y = new FamillesArticle();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        y.Id = id;
                        y.Reference = lect["reference"].ToString();
                        y.Designation = lect["designation"].ToString();
                        y.Description = lect["description"].ToString();
                        Int32 id_ = (Int32)((lect["parent"] != null) ? (!lect["parent"].ToString().Trim().Equals("") ? lect["parent"] : 0) : 0);
                        y.Parent = new FamillesArticle(id_, lect["designation_"].ToString());
                        y.Sous = listFamillesArticle("select * from familles_article where parent = " + id);
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

        public static List<FamillesArticle> listFamillesArticle(string query)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                NpgsqlCommand Lcmd = new NpgsqlCommand(query, con);
                NpgsqlDataReader lect = Lcmd.ExecuteReader();
                List<FamillesArticle> l = new List<FamillesArticle>();
                if (lect.HasRows)
                {
                    while (lect.Read())
                    {
                        FamillesArticle y = oneFamillesArticle((Int32)((lect["id"] != null) ? (!lect["id"].ToString().Trim().Equals("") ? lect["id"] : 0) : 0));
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

        public static FamillesArticle saveFamillesArticle(FamillesArticle f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string insert = "insert into familles_article (reference,designation,description) values ('" + f.Reference + "','" + f.Designation + "','" + f.Description + "')";
                if (f.Parent != null ? f.Parent.Id > 0 : false)
                {
                    insert = "insert into familles_article (reference,designation,description,parent) values ('" + f.Reference + "','" + f.Designation + "','" + f.Description + "'," + f.Parent.Id + ")";
                }
                NpgsqlCommand cmd = new NpgsqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                f.Id = currentFamillesArticle(f);
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

        public static bool updateFamillesArticle(FamillesArticle f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string update = "update familles_article set reference ='" + f.Reference + "' , designation ='" + f.Designation + "' , description = '" + f.Description + "' where id = " + f.Id;
                if (f.Parent != null ? f.Parent.Id > 0 : false)
                {
                    update = "update familles_article set reference ='" + f.Reference + "' , designation ='" + f.Designation + "' , description = '" + f.Description + "' , parent = " + f.Parent.Id + " where id = " + f.Id;
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

        public static bool deleteFamillesArticle(FamillesArticle f)
        {
            NpgsqlConnection con = Connexion.Connection();
            try
            {
                string delete = "delete from familles_article where id = " + f.Id;
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
