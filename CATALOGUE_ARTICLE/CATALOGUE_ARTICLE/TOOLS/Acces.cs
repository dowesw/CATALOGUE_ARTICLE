using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CATALOGUE_ARTICLE.ENTITE;
using CATALOGUE_ARTICLE.BLL;

namespace CATALOGUE_ARTICLE.TOOLS
{
    class Acces
    {
        public Acces() 
        {
            Load();
        }

        private Formulaires[] formulaires = new Formulaires[] {
            new Formulaires(-1, "form_acces","Autorisations", new Ressources[]{
                new Ressources(-1,"upd_acces","Modifier Autorisation")}),

            new Formulaires(-2, "form_article","Articles", new Ressources[]{
                new Ressources(-1,"add_article","Créer Article"),
                new Ressources(-2,"del_article","Supprimer Article"),
                new Ressources(-3,"upd_article","Modifier Article"),
                new Ressources(-4,"add_photo_article","Ajouter Photo Article"),
                new Ressources(-4,"del_photo_article","Supprimer Photo Article")}),

            new Formulaires(-3, "form_docstock","Documents Stock", new Ressources[]{
                new Ressources(-1,"add_doc_stock","Créer Document de stock "),
                new Ressources(-2,"upd_doc_stock","Modifier Document de stock "),
                new Ressources(-3,"del_doc_stock","Supprimer Document de stock ")}), 

            new Formulaires(-4, "form_famille","Familles Article", new Ressources[]{
                new Ressources(-1,"add_famille","Créer Famille Article "),
                new Ressources(-2,"upd_famille","Modifier Famille Article "),
                new Ressources(-3,"del_famille","Supprimer Famille Article ")}), 

            new Formulaires(-5, "form_mouvement","Mouvements Stock"), 

            new Formulaires(-6, "form_setting","Parametrages", new Ressources[]{
                new Ressources(-1,"add_niveau","Créer Niveau Acces "),
                new Ressources(-2,"upd_niveau","Modifier Niveau Acces "),
                new Ressources(-3,"del_niveau","Supprimer Niveau Acces "),
                new Ressources(-3,"upd_serveur","Modifier Serveur ")}), 

            new Formulaires(-7, "form_users","Utilisateurs", new Ressources[]{
                new Ressources(-1,"add_users","Créer Utilisateur "),
                new Ressources(-2,"upd_users","Modifier Utilisateur "),
                new Ressources(-3,"del_users","Supprimer Utilisateur ")})};

        private void Load()
        {
            Formulaires[] l = formulaires;
            formulaires = new Formulaires[l.Length];
            for (int i = 0; i < l.Length; i++)
            {
                Formulaires f = l[i];
                Int32 id = FormulairesBLL.Current(f);
                if (id < 1)
                {
                    Formulaires f_ = FormulairesBLL.Save(f);
                    f.Id = f_.Id;
                }
                else
                {
                    f.Id = id;
                }

                Ressources[] t = f.Ressources;
                f.Ressources = new Ressources[t.Length];
                for (int j = 0; j < t.Length; j++)
                {
                    Ressources r = t[j];
                    id = RessourcesBLL.Current(r);
                    if (id < 1)
                    {
                        r.Formulaire = f;
                        Ressources r_ = RessourcesBLL.Save(r);
                        r.Id = r_.Id;
                    }
                    else
                    {
                        r.Id = id;
                    }
                    f.Ressources[j] = r;
                }

                formulaires[i] = f;
            }
        }

        public static void LoadAcces(NiveauAcces n)
        {
            string query = "select * from autorisation_formulaire where niveau = " + n.Id;
            List<AutorisationFormulaire> lf = AutorisationFormulaireBLL.List(query);
            foreach(AutorisationFormulaire af in lf){
                new AccesFormulaires().Acces(af.Formulaire.Code, af.Update);
            }

            query = "select * from autorisation_ressource where niveau = " + n.Id;
            List<AutorisationRessource> lr = AutorisationRessourceBLL.List(query);
            foreach (AutorisationRessource af in lr)
            {
                new AccesRessources().Acces(af.Ressource.Code, af.Update);
            }
        }
    }
}
