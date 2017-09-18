/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: Adherent
------------------------------------------------------------*/
CREATE TABLE Adherent(
	id_a          INT IDENTITY (1,1) NOT NULL ,
	pseudo_a      VARCHAR (25) NOT NULL UNIQUE,
	mail_a        VARCHAR (25) NOT NULL UNIQUE,
	mdp_a         VARCHAR (25)  ,
	description_a VARCHAR (25)  ,
	avatar_a      VARCHAR (25)  ,
	president_a   bit   ,
	admin_a       bit   ,
	visiteur_a    bit   ,
	rue_a         VARCHAR (25)  ,
	code_postal_a INT   ,
	ville_a       VARCHAR (25)  ,
	CONSTRAINT prk_constraint_Adherent PRIMARY KEY NONCLUSTERED (id_a)
);


/*------------------------------------------------------------
-- Table: affiche
------------------------------------------------------------*/
CREATE TABLE affiche(
	id_af          INT IDENTITY (1,1) NOT NULL ,
	description_af VARCHAR (25)  ,
	titre_af       VARCHAR (25)  ,
	annee_af       INT   ,
	type_af        bit   ,
	id_format      INT   ,
	CONSTRAINT prk_constraint_affiche PRIMARY KEY NONCLUSTERED (id_af)
);


/*------------------------------------------------------------
-- Table: Catégorie
------------------------------------------------------------*/
CREATE TABLE Categorie(
	id_cat      INT IDENTITY (1,1) NOT NULL ,
	libelle_cat VARCHAR (25)  ,
	CONSTRAINT prk_constraint_Categorie PRIMARY KEY NONCLUSTERED (id_cat)
);


/*------------------------------------------------------------
-- Table: Pays
------------------------------------------------------------*/
CREATE TABLE Pays(
	id_p      INT IDENTITY (1,1) NOT NULL ,
	libelle_p VARCHAR (25)  ,
	CONSTRAINT prk_constraint_Pays PRIMARY KEY NONCLUSTERED (id_p)
);


/*------------------------------------------------------------
-- Table: Emprunt
------------------------------------------------------------*/
CREATE TABLE Emprunt(
	id_em     INT IDENTITY (1,1) NOT NULL ,
	date_em   DATETIME  ,
	delais_em INT   ,
	id_a      INT   ,
	id_ex     INT   ,
	CONSTRAINT prk_constraint_Emprunt PRIMARY KEY NONCLUSTERED (id_em)
);


/*------------------------------------------------------------
-- Table: Exemplaire
------------------------------------------------------------*/
CREATE TABLE Exemplaire(
	id_ex            INT IDENTITY (1,1) NOT NULL ,
	commentaire_ex   VARCHAR (25)  ,
	photo_ex         VARCHAR (25)  ,
	extrait_video_ex VARCHAR (25)  ,
	date_ajout_ex    DATETIME  ,
	etat_ex          bit   ,
	nb_vues_ex       INT   ,
	id_af            INT   ,
	CONSTRAINT prk_constraint_Exemplaire PRIMARY KEY NONCLUSTERED (id_ex)
);


/*------------------------------------------------------------
-- Table: Format
------------------------------------------------------------*/
CREATE TABLE Format(
	id_format      INT IDENTITY (1,1) NOT NULL ,
	libelle_format VARCHAR (25)  ,
	CONSTRAINT prk_constraint_Format PRIMARY KEY NONCLUSTERED (id_format)
);


/*------------------------------------------------------------
-- Table: Acteurs
------------------------------------------------------------*/
CREATE TABLE Acteurs(
	id_act  INT IDENTITY (1,1) NOT NULL ,
	nom_act VARCHAR (25)  ,
	CONSTRAINT prk_constraint_Acteurs PRIMARY KEY NONCLUSTERED (id_act)
);


/*------------------------------------------------------------
-- Table: Réalisateurs
------------------------------------------------------------*/
CREATE TABLE Realisateurs(
	id_real  INT IDENTITY (1,1) NOT NULL ,
	nom_real VARCHAR (25)  ,
	CONSTRAINT prk_constraint_Realisateurs PRIMARY KEY NONCLUSTERED (id_real)
);


/*------------------------------------------------------------
-- Table: référencer
------------------------------------------------------------*/
CREATE TABLE referencer(
	id_cat INT  NOT NULL ,
	id_af  INT  NOT NULL ,
	CONSTRAINT prk_constraint_referencer PRIMARY KEY NONCLUSTERED (id_cat,id_af)
);


/*------------------------------------------------------------
-- Table: être originaire de
------------------------------------------------------------*/
CREATE TABLE etre_originaire_de(
	id_p  INT  NOT NULL ,
	id_af INT  NOT NULL ,
	CONSTRAINT prk_constraint_etre_originaire_de PRIMARY KEY NONCLUSTERED (id_p,id_af)
);


/*------------------------------------------------------------
-- Table: commenter
------------------------------------------------------------*/
CREATE TABLE commenter(
	date_com    DATETIME  ,
	commentaire VARCHAR (25)  ,
	note        INT   ,
	id_a        INT  NOT NULL ,
	id_ex       INT  NOT NULL ,
	CONSTRAINT prk_constraint_commenter PRIMARY KEY NONCLUSTERED (id_a,id_ex)
);


/*------------------------------------------------------------
-- Table: jouer
------------------------------------------------------------*/
CREATE TABLE jouer(
	id_act INT  NOT NULL ,
	id_af  INT  NOT NULL ,
	CONSTRAINT prk_constraint_jouer PRIMARY KEY NONCLUSTERED (id_act,id_af)
);


/*------------------------------------------------------------
-- Table: réaliser
------------------------------------------------------------*/
CREATE TABLE realiser(
	id_real INT  NOT NULL ,
	id_af   INT  NOT NULL ,
	CONSTRAINT prk_constraint_realiser PRIMARY KEY NONCLUSTERED (id_real,id_af)
);



ALTER TABLE affiche ADD CONSTRAINT FK_affiche_id_format FOREIGN KEY (id_format) REFERENCES Format(id_format);
ALTER TABLE Emprunt ADD CONSTRAINT FK_Emprunt_id_a FOREIGN KEY (id_a) REFERENCES Adherent(id_a);
ALTER TABLE Emprunt ADD CONSTRAINT FK_Emprunt_id_ex FOREIGN KEY (id_ex) REFERENCES Exemplaire(id_ex);
ALTER TABLE Exemplaire ADD CONSTRAINT FK_Exemplaire_id_af FOREIGN KEY (id_af) REFERENCES affiche(id_af);
ALTER TABLE referencer ADD CONSTRAINT FK_referencer_id_cat FOREIGN KEY (id_cat) REFERENCES Categorie(id_cat);
ALTER TABLE referencer ADD CONSTRAINT FK_referencer_id_af FOREIGN KEY (id_af) REFERENCES affiche(id_af);
ALTER TABLE etre_originaire_de ADD CONSTRAINT FK_etre_originaire_de_id_p FOREIGN KEY (id_p) REFERENCES Pays(id_p);
ALTER TABLE etre_originaire_de ADD CONSTRAINT FK_etre_originaire_de_id_af FOREIGN KEY (id_af) REFERENCES affiche(id_af);
ALTER TABLE commenter ADD CONSTRAINT FK_commenter_id_a FOREIGN KEY (id_a) REFERENCES Adherent(id_a);
ALTER TABLE commenter ADD CONSTRAINT FK_commenter_id_ex FOREIGN KEY (id_ex) REFERENCES Exemplaire(id_ex);
ALTER TABLE jouer ADD CONSTRAINT FK_jouer_id_act FOREIGN KEY (id_act) REFERENCES Acteurs(id_act);
ALTER TABLE jouer ADD CONSTRAINT FK_jouer_id_af FOREIGN KEY (id_af) REFERENCES affiche(id_af);
ALTER TABLE realiser ADD CONSTRAINT FK_realiser_id_real FOREIGN KEY (id_real) REFERENCES Realisateurs(id_real);
ALTER TABLE realiser ADD CONSTRAINT FK_realiser_id_af FOREIGN KEY (id_af) REFERENCES affiche(id_af);
