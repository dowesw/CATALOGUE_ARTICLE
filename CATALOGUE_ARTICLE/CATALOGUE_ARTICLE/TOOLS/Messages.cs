using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using System.Windows.Forms;

namespace CATALOGUE_ARTICLE.TOOLS
{
    class Messages
    {
        static public DialogResult Message(String text, String titre, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult reponse = MessageBox.Show(text, titre, buttons, icon);
            return reponse;
        }
        static public DialogResult ChampsVide()
        {
            DialogResult reponse = MessageBox.Show(Mots.Msg_ChampsVides, Constantes.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return reponse;
        }

        static public DialogResult ChampsVide(string element)
        {
            DialogResult reponse = MessageBox.Show(Mots.Msg_ChampsVide + " '" + element + "'", Mots.Catalogue_Article, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return reponse;
        }

        static public DialogResult Confirmation_Infos(string action)
        {
            DialogResult reponse = MessageBox.Show(Mots.Msg_Confirmation + " " + action + " " + Mots.Les_Informations + "?", Mots.Catalogue_Article, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return reponse;
        }

        static public DialogResult Confirmation(string action)
        {
            DialogResult reponse = MessageBox.Show(Mots.Msg_Confirmation + " " + action + "?", Mots.Catalogue_Article, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return reponse;
        }

        static public DialogResult Annulation()
        {
            DialogResult reponse = MessageBox.Show(Mots.Msg_Annulation, Mots.Catalogue_Article, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return reponse;
        }

        static public DialogResult FermerApplication()
        {
            DialogResult reponse = MessageBox.Show(Mots.Msg_FermerApplication, Mots.Catalogue_Article, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return reponse;
        }

        static public DialogResult Exception(Exception ex)
        {
            DialogResult reponse = MessageBox.Show(Mots.Msg_Exception + " : " + ex.Message, Mots.Catalogue_Article, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return reponse;
        }

        static public DialogResult Exception(NpgsqlException ex)
        {
            DialogResult reponse = MessageBox.Show(Mots.Msg_Exception + " : " + ex.Message, Mots.Catalogue_Article, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return reponse;
        }

        static public DialogResult Inexistant(string element)
        {
            DialogResult reponse = MessageBox.Show(element + " " + Mots.Msg_Inexistant, Mots.Catalogue_Article, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return reponse;
        }

        static public DialogResult Succes()
        {
            DialogResult reponse = MessageBox.Show(Mots.Msg_Succes, Mots.Catalogue_Article, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return reponse;
        }

        static public DialogResult Succes(string element, string action)
        {
            DialogResult reponse = MessageBox.Show(element + " " + action + " " + Mots.Msg_Succes, Mots.Catalogue_Article, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return reponse;
        }

        static public DialogResult Information(string message)
        {
            DialogResult reponse = MessageBox.Show(message, Mots.Catalogue_Article, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return reponse;
        }

        static public DialogResult Erreur_Retry(string message)
        {
            DialogResult reponse = MessageBox.Show(message, Mots.Catalogue_Article, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            return reponse;
        }

        static public DialogResult Erreur_Oui_Non(string message)
        {
            DialogResult reponse = MessageBox.Show(message, Mots.Catalogue_Article, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            return reponse;
        }

        static public DialogResult ShowErreur(string message)
        {
            DialogResult reponse = MessageBox.Show(message, Mots.Catalogue_Article, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return reponse;
        }

        static public DialogResult Alert(string message)
        {
            DialogResult reponse = MessageBox.Show(message, Mots.Catalogue_Article, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return reponse;
        }

        static public DialogResult Show(string message)
        {
            DialogResult reponse = MessageBox.Show(message, Mots.Catalogue_Article, MessageBoxButtons.OK);
            return reponse;
        }
    }
}
