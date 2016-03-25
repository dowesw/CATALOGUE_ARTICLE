using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.ENTITE
{
    class PhotosArticle
    {
        public PhotosArticle() {}

        public PhotosArticle(Int32 id)
        {
            this.id = id;
        }

        public PhotosArticle(string nom)
        {
            this.nom = nom;
        }

        public PhotosArticle(string nom, Articles a)
        {
            this.nom = nom;
            this.article = a;
        }

        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private Articles article = new Articles();

        internal Articles Article
        {
            get { return article; }
            set { article = value; }
        }

        private bool update;

        public bool Update
        {
            get { return update; }
            set { update = value; }
        }

        public Boolean Control()
        {
            return Control(this);
        }

        public static Boolean Control(PhotosArticle bean)
        {
            if (bean == null)
            {
                Messages.ShowErreur("Photo Incorrect!");
                return false;
            }
            if (bean.Article != null?bean.Article.Id<1:true)
            {
                Messages.ShowErreur("Article doit etre selectionné ne peut pas être null!");
                return false;
            }
            return true;
        }
    }
}
