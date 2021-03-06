﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using CATALOGUE_ARTICLE.TOOLS;

namespace CATALOGUE_ARTICLE.ENTITE
{
    public class FamillesArticle
    {
        public FamillesArticle() { }

        public FamillesArticle(Int32 id) {
            this.id = id;
        }

        public FamillesArticle(Int32 id, string designation)
        {
            this.id = id;
            this.designation = designation;
        }

        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        private string reference;

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private bool update;

        public bool Update
        {
            get { return update; }
            set { update = value; }
        }

        private FamillesArticle parent;

        public FamillesArticle Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        private List<FamillesArticle> sous = new List<FamillesArticle>();

        public List<FamillesArticle> Sous
        {
            get { return sous; }
            set { sous = value; }
        }

        public Boolean Control()
        {
            return Control(this);
        }

        public static Boolean Control(FamillesArticle bean)
        {
            if (bean == null)
            {
                Messages.ShowErreur("Famille Article Incorrecte!");
                return false;
            }
            if (bean.reference == null || bean.reference.Trim().Equals(""))
            {
                Messages.ShowErreur("La réference ne peut pas être null!");
                return false;
            }
            if (bean.designation == null || bean.designation.Trim().Equals(""))
            {
                Messages.ShowErreur("La désignation ne peut pas être null!");
                return false;
            }
            return true;
        }
    }
}
