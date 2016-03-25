-- Table: parametres
CREATE TABLE parametres
(
  id serial NOT NULL,
  affiche_pua boolean,
  affiche_puv boolean,
  affiche_date_save boolean,
  affiche_date_update boolean,
  CONSTRAINT parametres_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE parametres
  OWNER TO postgres; 
	   

-- Table: familles_article
CREATE TABLE familles_article
(
  id serial NOT NULL,
  reference character varying,
  designation character varying,
  description character varying,
  CONSTRAINT familles_article_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE familles_article
  OWNER TO postgres;

  -- Table: articles
CREATE TABLE IF NOT EXISTS articles
(
  id serial NOT NULL,
  reference character varying,
  designation character varying,
  description character varying,
  marque character varying,
  puv double precision,
  pua double precision,
  date_save time without time zone,
  date_update time without time zone,
  famille integer,
  CONSTRAINT articles_pkey PRIMARY KEY (id),
  CONSTRAINT articles_famille_fkey FOREIGN KEY (famille)
      REFERENCES familles_article (id) MATCH SIMPLE
      ON UPDATE CASCADE ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE articles
  OWNER TO postgres;  
  
  -- Table: photo_article
CREATE TABLE photo_article
(
  id serial NOT NULL,
  nom character varying,
  article integer,
  CONSTRAINT photo_article_pkey PRIMARY KEY (id),
  CONSTRAINT photo_article_article_fkey FOREIGN KEY (article)
      REFERENCES articles (id) MATCH SIMPLE
      ON UPDATE CASCADE ON DELETE CASCADE
)
WITH (
  OIDS=FALSE
);
ALTER TABLE photo_article
  OWNER TO postgres;  
  
  -- Table: doc_stocks
CREATE TABLE doc_stocks
(
  id serial NOT NULL,
  reference character varying,
  type_doc character varying,
  CONSTRAINT doc_stocks_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE doc_stocks
  OWNER TO postgres;
  
  -- Table: contenu_stock
CREATE TABLE contenu_stock
(
  id serial NOT NULL,
  article integer,
  prix double precision,
  quantite double precision,
  stock integer,
  CONSTRAINT contenu_stock_pkey PRIMARY KEY (id),
  CONSTRAINT contenu_stock_article_fkey FOREIGN KEY (article)
      REFERENCES articles (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT contenu_stock_stock_fkey FOREIGN KEY (stock)
      REFERENCES doc_stocks (id) MATCH SIMPLE
      ON UPDATE CASCADE ON DELETE CASCADE
)
WITH (
  OIDS=FALSE
);
ALTER TABLE contenu_stock
  OWNER TO postgres;
  
  -- Table: mouvements_stock
CREATE TABLE mouvements_stock
(
  id serial NOT NULL,
  date_save time without time zone,
  article integer,
  quantite double precision,
  entree boolean,
  CONSTRAINT mouvements_stock_pkey PRIMARY KEY (id),
  CONSTRAINT mouvements_stock_article_fkey FOREIGN KEY (article)
      REFERENCES articles (id) MATCH SIMPLE
      ON UPDATE CASCADE ON DELETE CASCADE
)
WITH (
  OIDS=FALSE
);
ALTER TABLE mouvements_stock
  OWNER TO postgres;
  
  -- Table: niveau_acces
CREATE TABLE niveau_acces
(
  id serial NOT NULL,
  designation character varying,
  description character varying,
  CONSTRAINT niveau_acces_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE niveau_acces
  OWNER TO postgres;
  
  -- Table: users
CREATE TABLE users
(
  id serial NOT NULL,
  nom character varying,
  prenom character varying,
  identifiant character varying,
  mot_passe character varying,
  actif boolean,
  niveau integer,
  photo character varying,
  CONSTRAINT users_pkey PRIMARY KEY (id),
  CONSTRAINT users_niveau_fkey FOREIGN KEY (niveau)
      REFERENCES niveau_acces (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION
)
WITH (
  OIDS=FALSE
);
ALTER TABLE users
  OWNER TO postgres;
  
  -- Table: formulaires
CREATE TABLE formulaires
(
  id serial NOT NULL,
  code character varying,
  libelle character varying,
  CONSTRAINT formulaire_pkey PRIMARY KEY (id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE formulaires
  OWNER TO postgres;
  
  -- Table: ressources
CREATE TABLE ressources
(
  id serial NOT NULL,
  code character varying,
  libelle character varying,
  formulaire integer,
  CONSTRAINT ressources_pkey PRIMARY KEY (id),
  CONSTRAINT ressources_fourmulaire_fkey FOREIGN KEY (formulaire)
      REFERENCES formulaires (id) MATCH SIMPLE
      ON UPDATE CASCADE ON DELETE CASCADE
)
WITH (
  OIDS=FALSE
);
ALTER TABLE ressources
  OWNER TO postgres;
  
  -- Table: autorisation_fourmulaire
CREATE TABLE autorisation_formulaire
(
  id serial NOT NULL,
  niveau integer,
  formulaire integer,
  acces boolean,
  CONSTRAINT autorisation_formulaire_pkey PRIMARY KEY (id),
  CONSTRAINT autorisation_formulaire_formulaire_fkey FOREIGN KEY (formulaire)
      REFERENCES formulaires (id) MATCH SIMPLE
      ON UPDATE CASCADE ON DELETE CASCADE,
  CONSTRAINT autorisation_formulaire_niveau_fkey FOREIGN KEY (niveau)
      REFERENCES niveau_acces (id) MATCH SIMPLE
      ON UPDATE CASCADE ON DELETE CASCADE
)
WITH (
  OIDS=FALSE
);
ALTER TABLE autorisation_formulaire
  OWNER TO postgres;
  
  -- Table: autorisation_ressource
CREATE TABLE autorisation_ressource
(
  id serial NOT NULL,
  niveau integer,
  ressource integer,
  acces boolean,
  CONSTRAINT autorisation_ressource_pkey PRIMARY KEY (id),
  CONSTRAINT autorisation_ressource_niveau_fkey FOREIGN KEY (niveau)
      REFERENCES niveau_acces (id) MATCH SIMPLE
      ON UPDATE CASCADE ON DELETE CASCADE,
  CONSTRAINT autorisation_ressource_ressource_fkey FOREIGN KEY (ressource)
      REFERENCES ressources (id) MATCH SIMPLE
      ON UPDATE CASCADE ON DELETE CASCADE
)
WITH (
  OIDS=FALSE
);
ALTER TABLE autorisation_ressource
  OWNER TO postgres
