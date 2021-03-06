﻿using System;
using System.Collections.Generic;
using System.Text;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.ENTITE
{
    [Serializable]
    public class Serveur
    {
        private string adresse;
        private int port;
        private string user;
        private string password;
        private string database;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Database
        {
            get { return database; }
            set { database = value; }
        }

        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        public static Serveur getServeurDefault()
        {
            Serveur s = new Serveur();
            s.adresse = "127.0.0.1";
            s.port = 5432;
            s.database = "catalogue_article";
            s.password = "yves1910/";
            s.user = "postgres";
            return s;
        }

        public Boolean Control()
        {
            return Control(this);
        }

        public static Boolean Control(Serveur bean)
        {
            if (bean == null)
            {
                Messages.ShowErreur("Serveur Incorrect!");
                return false;
            }
            if (bean.adresse == null || bean.adresse.Trim().Equals(""))
            {
                Messages.ShowErreur("L'adresse du serveur ne peut pas être null!");
                return false;
            }
            if (bean.database == null || bean.database.Trim().Equals(""))
            {
                Messages.ShowErreur("La base de donnée ne peut pas être null!");
                return false;
            }
            if (bean.port < 0)
            {
                Messages.ShowErreur("Le numéro du port ne peut pas être inferieur a 0!");
                return false;
            }
            return true;
        }

        public Boolean Control_()
        {
            return Control_(this);
        }

        public static Boolean Control_(Serveur bean)
        {
            if (bean == null)
            {
                return false;
            }
            if (bean.adresse == null || bean.adresse.Trim().Equals(""))
            {
                return false;
            }
            if (bean.port < 0)
            {
                return false;
            }
            return true;
        }
    }
}
