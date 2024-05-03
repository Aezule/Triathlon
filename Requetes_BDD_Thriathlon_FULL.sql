/*
    Création des tables de la base de données Triathlon
*/

/*
CREATE TABLE AGE(
   `codeAge` VARCHAR(4) NOT NULL,
   `AgeDebut` SMALLINT NOT NULL,
   `AgeFin` SMALLINT NOT NULL,
   `libelle` VARCHAR(15) NULL,
   PRIMARY KEY(`codeAge`)
)ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;
*/

/*SQL SERVER*/

CREATE TABLE AGE (
   codeAge VARCHAR(4) NOT NULL PRIMARY KEY,
   AgeDebut SMALLINT NOT NULL,
   AgeFin SMALLINT NOT NULL,
   libelle NVARCHAR(15),
);

/*
CREATE TABLE TYPE_TRIATHLON(
   `codeType` VARCHAR(4) NOT NULL,
   `designation` VARCHAR(50) NOT NULL,
   `distanceNatation` INT DEFAULT 100,
   `distanceCyclisme` INT DEFAULT 2500,
   `distanceCourse` INT DEFAULT 1000,
   PRIMARY KEY(`codeType`)
)ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;
*/


/*SQL SERVER*/

CREATE TABLE TYPE_TRIATHLON (
   codeType VARCHAR(4) NOT NULL PRIMARY KEY,
   designation NVARCHAR(50) NOT NULL,
   distanceNatation INT NOT NULL DEFAULT 100,
   distanceCyclisme INT NOT NULL DEFAULT 2500,
   distanceCourse INT NOT NULL DEFAULT 1000
);


/*
CREATE TABLE PRODUIT(
   `codeProduit` VARCHAR(4) NOT NULL,
   `libelle` VARCHAR(50) NULL,
   `tauxMax` DECIMAL(3,2) NOT NULL,
   PRIMARY KEY(`codeProduit`)
)ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;
*/

/*SQL SERVER*/

CREATE TABLE PRODUIT (
   codeProduit VARCHAR(4) NOT NULL PRIMARY KEY,
   libelle NVARCHAR(50),
   tauxMax DECIMAL(3,2) NOT NULL
);

/*
CREATE TABLE TRIATHLETE(
   `numeroTriathlete` VARCHAR(4) NOT NULL,
   `nom` VARCHAR(50) NOT NULL,
   `prenom` VARCHAR(50) NOT NULL,
   `dateNaissance` DATE NOT NULL,
   `pays` VARCHAR(50) NOT NULL,
   `ville` VARCHAR(50) NOT NULL,
   `numLicence` VARCHAR(4) NOT NULL,
   `dateObtention` DATE,
   `codePostal` CHAR(5) NOT NULL,
   `codeAge` VARCHAR(4) NOT NULL,
   PRIMARY KEY(`numeroTriathlete`),
   FOREIGN KEY(`codeAge`) REFERENCES AGE(`codeAge`)
)ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;
*/

/*SQL SERVER*/

CREATE TABLE TRIATHLETE (
   numeroTriathlete VARCHAR(4) NOT NULL PRIMARY KEY,
   nom NVARCHAR(50) NOT NULL,
   prenom NVARCHAR(50) NOT NULL,
   dateNaissance DATE NOT NULL,
   pays NVARCHAR(50) NOT NULL,
   ville NVARCHAR(50) NOT NULL,
   numLicence VARCHAR(4) NOT NULL,
   dateObtention DATE,
   codePostal CHAR(5) NOT NULL,
   codeAge VARCHAR(4) NOT NULL,
   FOREIGN KEY(codeAge) REFERENCES AGE(codeAge)
);

/*
CREATE TABLE TRIATHLON(
   `numTriathlon` VARCHAR(4) NOT NULL,
   `lieu` VARCHAR(50) NOT NULL,
   `nom` VARCHAR(50) NOT NULL,
   `dateTriathlon` DATE,
   `codeType` VARCHAR(4) NOT NULL,
   PRIMARY KEY(`numTriathlon`),
   FOREIGN KEY(`codeType`) REFERENCES TYPE_TRIATHLON(`codeType`)
)ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;
*/

/*SQL SERVER*/

CREATE TABLE TRIATHLON (
   numTriathlon VARCHAR(4) NOT NULL PRIMARY KEY,
   lieu NVARCHAR(50) NOT NULL,
   nom NVARCHAR(50) NOT NULL,
   dateTriathlon DATE,
   codeType VARCHAR(4) NOT NULL,
   FOREIGN KEY(codeType) REFERENCES TYPE_TRIATHLON(codeType)
);

/*
CREATE TABLE INSCRIPTON(
   `numTriathlon` VARCHAR(4) NOT NULL,
   `numDossard` VARCHAR(50) NOT NULL,
   `dateInscription` DATE DEFAULT CURRENT_DATE,
   `tempsCourseCyscliste` DECIMAL(5,2) NULL,
   `tempsCourse` DECIMAL(5,2) NULL,
   `tempsNatation` DECIMAL(5,2) NULL,
   `numeroTriathlete` VARCHAR(4) NOT NULL,
   PRIMARY KEY(`numTriathlon`, `numDossard`),
   FOREIGN KEY(`numTriathlon`) REFERENCES TRIATHLON(`numTriathlon`),
   FOREIGN KEY(`numeroTriathlete`) REFERENCES TRIATHLETE(`numeroTriathlete`)
)ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;
*/

/*SQL SERVER*/

CREATE TABLE INSCRIPTION (
   numTriathlon VARCHAR(4) NOT NULL,
   numDossard VARCHAR(50) NOT NULL,
   dateInscription DATE DEFAULT GETDATE(),
   tempsCourseCyscliste DECIMAL(5,2),
   tempsCourse DECIMAL(5,2),
   tempsNatation DECIMAL(5,2),
   numeroTriathlete VARCHAR(4) NOT NULL,
   PRIMARY KEY(numTriathlon, numDossard),
   FOREIGN KEY(numTriathlon) REFERENCES TRIATHLON(numTriathlon),
   FOREIGN KEY(numeroTriathlete) REFERENCES TRIATHLETE(numeroTriathlete)
);

/*
CREATE TABLE VERIFIER(
   `codeProduit` VARCHAR(4) NOT NULL,
   `numTriathlon` VARCHAR(4) NOT NULL,
   `numDossard` VARCHAR(50) NOT NULL,
   `prelevement` VARCHAR(50) NOT NULL,
   PRIMARY KEY(`codeProduit`, `numTriathlon`, `numDossard`),
   FOREIGN KEY(`codeProduit`) REFERENCES PRODUIT(`codeProduit`),
   FOREIGN KEY(`numTriathlon`, `numDossard`) REFERENCES INSCRIPTON(`numTriathlon`, `numDossard`)
)ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_general_ci;
*/

/* SQL SERVER*/

CREATE TABLE VERIFIER (
   codeProduit VARCHAR(4) NOT NULL,
   numTriathlon VARCHAR(4) NOT NULL,
   numDossard VARCHAR(50) NOT NULL,
   prelevement VARCHAR(50) NOT NULL,
   PRIMARY KEY(codeProduit, numTriathlon, numDossard),
   FOREIGN KEY(codeProduit) REFERENCES PRODUIT(codeProduit),
   FOREIGN KEY(numTriathlon, numDossard) REFERENCES INSCRIPTION(numTriathlon, numDossard)
);




/*
    Insertion du jeu d'essai
*/

/*My Sql

INSERT INTO AGE(`codeAge`,`AgeDebut`,`AgeFin`,`libelle`) VALUES
('0001',10,12,'Benjamin'),
('0002',13,14,'Minime'),
('0003',15,16,'Cadet'),
('0004',15,16,'Junior'),
('0005',19,39,'Sénior'),
('0006',40,50,'Vétéran');

INSERT INTO PRODUIT VALUES ('DOP3', 'Testostérone', 0.05),
('PRO4', 'Hormone de croissance', 0.02),
('PRO5', 'Clenbutérol', 0.04),
('PRO6', 'Insuline', 0.03),
('PRO7', 'Diurétiques', 0.02);

-- Triathlons standards
INSERT INTO TYPE_TRIATHLON VALUES 
('OLYM', 'Triathlon Olympique', 1500, 40000, 10000),
('SPR', 'Triathlon Sprint', 750, 20000, 5000),
('IRON', 'Ironman', 3800, 180000, 42200);

-- Triathlon aux Jeux Olympiques
INSERT INTO TYPE_TRIATHLON VALUES ('TROP', 'Triathlon aux Jeux Olympiques', 1500, 40000, 10000);

-- Insertion de données de test dans la table TRIATHLON
INSERT INTO TRIATHLON VALUES ('TRI1', 'Montpellier', 'Triathlon Sprint de Printemps', '2024-05-15', 'SPR');
INSERT INTO TRIATHLON VALUES ('TRI2', 'Paris', 'Ironman de l''été', '2024-07-20', 'TRON');
INSERT INTO TRIATHLON VALUES ('TRI3', 'Bordeau', 'Ironman de l''été', '2024-07-20', 'IRON');

-- Insertion des triathètes

INSERT INTO TRIATHLETE VALUES 
('T01', 'Dupont', 'Jean', '1990-05-12', 'France', 'Paris', 'L001', '2022-03-15', '75001', '0001'),
('T02', 'Smith', 'Emma', '1985-08-20', 'United States', 'New York', 'L002', '2022-02-28', '10001', '0002'),
('T03', 'Garcia', 'Carlos', '1988-11-03', 'Spain', 'Madrid', 'L003', '2022-01-10', '28001', '0005'),
('T04', 'Müller', 'Anna', '1995-04-25', 'Germany', 'Berlin', 'L004', '2022-04-05', '10115', '0001'),
('T05', 'Rossi', 'Giuseppe', '1982-06-30', 'Italy', 'Rome', 'L005', '2022-06-18', '00184', '0002'),
('T06', 'Wang', 'Li', '1993-09-17', 'China', 'Beijing', 'L006', '2022-08-22', '10005', '0005'),
('T07', 'Kim', 'Min-Ji', '1997-12-08', 'South Korea', 'Seoul', 'L007', '2022-09-30', '04528', '0006'),
('T08', 'Almeida', 'Rafael', '1990-03-02', 'Brazil', 'Rio de Janeiro', 'L008', '2022-11-12', '20031', '0003'),
('T09', 'Nguyen', 'Thi', '1987-07-15', 'Vietnam', 'Ho Chi Minh City', 'L009', '2022-10-10', '70000', '0001'),
('T10', 'Patel', 'Priya', '1994-02-18', 'India', 'Mumbai', 'L010', '2022-12-25', '40001', '0006');


INSERT INTO INSCRIPTON(`numTriathlon`,`numDossard`,`dateInscription`,`tempsCourseCyscliste`,`tempsCourse`,`tempsNatation`,`numeroTriathlete`)
VALUES 
('TRI1','001','20-04-2004',0.0,0.0,0.0,'T01'),
('TRI1','002','26-04-2004',0.0,0.0,0.0,'T02'),
('TRI1','003','13-05-2004',0.0,0.0,0.0,'T03'),
('TRI2','001','18-02-2004',0.0,0.0,0.0,'T04'),
('TRI2','002','15-03-2004',0.0,0.0,0.0,'T05');


INSERT INTO VERIFIER(`codeProduit`,`numTriathlon`,`numDossard`,`prelevement`)
VALUES
('PRO4','TRI1','001',10),
('PRO4','TRI1','002',5),
('PRO7','TRI1','001',9),
('PRO6','TRI1','003',2),
('PRO5','TRI1','003',8);

*/


/* SQL SERVER INSERTS */


INSERT INTO AGE(codeAge, AgeDebut, AgeFin, libelle) VALUES
('0001', 10, 12, 'Benjamin'),
('0002', 13, 14, 'Minime'),
('0003', 15, 16, 'Cadet'),
('0004', 15, 16, 'Junior'),
('0005', 19, 39, 'Sénior'),
('0006', 40, 50, 'Vétéran');

INSERT INTO PRODUIT VALUES 
('DOP3', 'Testostérone', 0.05),
('PRO4', 'Hormone de croissance', 0.02),
('PRO5', 'Clenbutérol', 0.04),
('PRO6', 'Insuline', 0.03),
('PRO7', 'Diurétiques', 0.02);

-- Triathlons standards
INSERT INTO TYPE_TRIATHLON VALUES 
('OLYM', 'Triathlon Olympique', 1500, 40000, 10000),
('SPR', 'Triathlon Sprint', 750, 20000, 5000),
('IRON', 'Ironman', 3800, 180000, 42200);

-- Triathlon aux Jeux Olympiques
INSERT INTO TYPE_TRIATHLON VALUES ('TROP', 'Triathlon aux Jeux Olympiques', 1500, 40000, 10000);

-- Insertion de données de test dans la table TRIATHLON
INSERT INTO TRIATHLON VALUES 
('TRI1', 'Montpellier', 'Triathlon Sprint de Printemps', '2024-05-15', 'SPR'),
('TRI2', 'Paris', 'Ironman de l''été', '2024-07-20', 'IRON'),
('TRI3', 'Bordeau', 'Ironman de l''été', '2024-07-20', 'IRON');

-- Insertion des triathlètes
INSERT INTO TRIATHLETE VALUES 
('T01', 'Dupont', 'Jean', '1990-05-12', 'France', 'Paris', 'L001', '2022-03-15', '75001', '0001'),
('T02', 'Smith', 'Emma', '1985-08-20', 'United States', 'New York', 'L002', '2022-02-28', '10001', '0002'),
('T03', 'Garcia', 'Carlos', '1988-11-03', 'Spain', 'Madrid', 'L003', '2022-01-10', '28001', '0005'),
('T04', 'Müller', 'Anna', '1995-04-25', 'Germany', 'Berlin', 'L004', '2022-04-05', '10115', '0001'),
('T05', 'Rossi', 'Giuseppe', '1982-06-30', 'Italy', 'Rome', 'L005', '2022-06-18', '00184', '0002'),
('T06', 'Wang', 'Li', '1993-09-17', 'China', 'Beijing', 'L006', '2022-08-22', '10005', '0005'),
('T07', 'Kim', 'Min-Ji', '1997-12-08', 'South Korea', 'Seoul', 'L007', '2022-09-30', '04528', '0006'),
('T08', 'Almeida', 'Rafael', '1990-03-02', 'Brazil', 'Rio de Janeiro', 'L008', '2022-11-12', '20031', '0003'),
('T09', 'Nguyen', 'Thi', '1987-07-15', 'Vietnam', 'Ho Chi Minh City', 'L009', '2022-10-10', '70000', '0001'),
('T10', 'Patel', 'Priya', '1994-02-18', 'India', 'Mumbai', 'L010', '2022-12-25', '40001', '0006');

INSERT INTO INSCRIPTION(numTriathlon, numDossard, dateInscription, tempsCourseCyscliste, tempsCourse, tempsNatation, numeroTriathlete)
VALUES 
('TRI1', '001', '2004-04-20', 0.0, 0.0, 0.0, 'T01'),
('TRI1', '002', '2004-04-26', 0.0, 0.0, 0.0, 'T02'),
('TRI1', '003', '2004-05-13', 0.0, 0.0, 0.0, 'T03'),
('TRI2', '001', '2004-02-18', 0.0, 0.0, 0.0, 'T04'),
('TRI2', '002', '2004-03-15', 0.0, 0.0, 0.0, 'T05');

INSERT INTO VERIFIER(codeProduit, numTriathlon, numDossard, prelevement)
VALUES
('PRO4', 'TRI1', '001', 10),
('PRO4', 'TRI1', '002', 5),
('PRO7', 'TRI1', '001', 9),
('PRO6', 'TRI1', '003', 2),
('PRO5', 'TRI1', '003', 8);

CREATE LOGIN UserTriathlon WITH PASSWORD = 'm0Td3P@ss3';

CREATE USER UserTriathlon FOR LOGIN UserTriathlon;

GRANT SELECT, INSERT, UPDATE, DELETE ON INSCRIPTION TO UserTriathlon;
GRANT SELECT, INSERT, UPDATE, DELETE ON AGE TO UserTriathlon;
GRANT SELECT, INSERT, UPDATE, DELETE ON PRODUIT TO UserTriathlon;
GRANT SELECT, INSERT, UPDATE, DELETE ON TRIATHLETE TO UserTriathlon;
GRANT SELECT, INSERT, UPDATE, DELETE ON TRIATHLON TO UserTriathlon;
GRANT SELECT, INSERT, UPDATE, DELETE ON TYPE_TRIATHLON TO UserTriathlon;
GRANT SELECT, INSERT, UPDATE, DELETE ON VERIFIER TO UserTriathlon;

/* Triggers */

    /* Identificatuion relative des inscriptions */

    /* Affectation automatique du triathèle à sa catégorie en fonction de son âge */


/*Inscriptions relatives*/
CREATE OR ALTER TRIGGER TI_AddInscription ON INSCRIPTION
INSTEAD OF INSERT
AS
BEGIN
	if(not exists(Select * from INSCRIPTION Where numTriathlon = (select numTriathlon from inserted)))
	begin
      throw 50001, 'Le traithlon n''existe pas', 0
	
	  rollback transaction
	end

	if((Select COUNT((numeroTriathlete)) FROM INSCRIPTION WHERE numTriathlon = (select numTriathlon from inserted)) = 0)
	
		INSERT INTO INSCRIPTION(numTriathlon, numDossard, dateInscription, tempsCourseCyscliste, tempsCourse, tempsNatation, numeroTriathlete)
      VALUES 
      ((select numTriathlon from inserted), '001', (select dateInscription from inserted), 0.0, 0.0, 0.0, (select numeroTriathlete from inserted));
	  
	
	else
	

      /*Script CONCATENATION*/

      declare @lastNumDossard varchar(50) = (Select MAX(numDossard) from INSCRIPTION Where numTriathlon = (select numTriathlon from inserted));

      declare @newNumDossard int = (CONVERT(int,@lastNumDossard) + 1)

    
      if(@newNumDossard >= 1000)
      begin
         throw 50001, 'Nombre maximum de triathlètes atteint',0;

         rollback transaction;
      end
      if(@newNumDossard < 10)
      begin
         

         INSERT INTO INSCRIPTION(numTriathlon, numDossard, dateInscription, tempsCourseCyscliste, tempsCourse, tempsNatation, numeroTriathlete)
            VALUES 
            ((select numTriathlon from inserted), CONCAT('0','0',@newNumDossard), (select dateInscription from inserted), 0.0, 0.0, 0.0, (select numeroTriathlete from inserted));
      end
      if(@newNumDossard >= 10 AND @newNumDossard < 100)
      begin
         

         INSERT INTO INSCRIPTION(numTriathlon, numDossard, dateInscription, tempsCourseCyscliste, tempsCourse, tempsNatation, numeroTriathlete)
            VALUES 
            ((select numTriathlon from inserted), CONCAT('0',@newNumDossard), (select dateInscription from inserted), 0.0, 0.0, 0.0, (select numeroTriathlete from inserted));
      end
      if(@newNumDossard >= 100)
      begin
         

         INSERT INTO INSCRIPTION(numTriathlon, numDossard, dateInscription, tempsCourseCyscliste, tempsCourse, tempsNatation, numeroTriathlete)
            VALUES 
            ((select numTriathlon from inserted), @newNumDossard, (select dateInscription from inserted), 0.0, 0.0, 0.0, (select numeroTriathlete from inserted));
      end
END



/*Ajout catégories auto*/

CREATE OR ALTER TRIGGER TI_AddTriathlete ON TRIATHLETE
INSTEAD OF INSERT
AS
BEGIN

   declare @age int = (select DATEDIFF(YEAR, dateNaissance,GETDATE()) from inserted);

   if(@age < 10)
   begin
      throw 50001, 'Age non valide, doit être supérieur ou égal à 10',0;

      rollback transaction;
   end

   if(@age >= 10 AND @age <= 12)
   
      INSERT INTO TRIATHLETE VALUES 
         ((select numeroTriathlete from inserted), (select nom from inserted), (select prenom from inserted), (select dateNaissance from inserted), (select pays from inserted), (select ville from inserted), (select numLicence from inserted), (select dateObtention from inserted), (select codePostal from inserted), '0001');
   
   if(@age >= 13 AND @age <= 14)
   
      INSERT INTO TRIATHLETE VALUES 
         ((select numeroTriathlete from inserted), (select nom from inserted), (select prenom from inserted), (select dateNaissance from inserted), (select pays from inserted), (select ville from inserted), (select numLicence from inserted), (select dateObtention from inserted), (select codePostal from inserted), '0002');
   
   if(@age >= 15 AND @age <= 16)
   
      INSERT INTO TRIATHLETE VALUES 
         ((select numeroTriathlete from inserted), (select nom from inserted), (select prenom from inserted), (select dateNaissance from inserted), (select pays from inserted), (select ville from inserted), (select numLicence from inserted), (select dateObtention from inserted), (select codePostal from inserted), '0003');
   
   if(@age >= 16 AND @age <= 18)
   
      INSERT INTO TRIATHLETE VALUES 
         ((select numeroTriathlete from inserted), (select nom from inserted), (select prenom from inserted), (select dateNaissance from inserted), (select pays from inserted), (select ville from inserted), (select numLicence from inserted), (select dateObtention from inserted), (select codePostal from inserted), '0004');
   
   if(@age >= 19 AND @age <= 39)
   
      INSERT INTO TRIATHLETE VALUES 
         ((select numeroTriathlete from inserted), (select nom from inserted), (select prenom from inserted), (select dateNaissance from inserted), (select pays from inserted), (select ville from inserted), (select numLicence from inserted), (select dateObtention from inserted), (select codePostal from inserted), '0005');
   
   if(@age >= 40)
   
      INSERT INTO TRIATHLETE VALUES 
         ((select numeroTriathlete from inserted), (select nom from inserted), (select prenom from inserted), (select dateNaissance from inserted), (select pays from inserted), (select ville from inserted), (select numLicence from inserted), (select dateObtention from inserted), (select codePostal from inserted), '0006');
   


END


/*Test insertion inscription*/

begin transaction

   SELECT * FROM INSCRIPTION WHERE numTriathlon = 'TRI2'

   INSERT INTO INSCRIPTION(numTriathlon, numDossard, dateInscription, tempsCourseCyscliste, tempsCourse, tempsNatation, numeroTriathlete)
         VALUES 
         ('TRI2', '' , GETDATE() , 0.0, 0.0, 0.0, 'T10');

   SELECT * FROM INSCRIPTION WHERE numTriathlon = 'TRI2'

rollback

/*Test Insertion triathlete*/

begin transaction

   SELECT * from AGE

   INSERT INTO TRIATHLETE VALUES 
   ('T11', 'Devilliers', 'Enzo', '1980-04-26', 'France', 'Longjumeaux', 'L001', '2022-03-15', '91000', '');

   SELECT * from TRIATHLETE

rollback

/*List all triggers*/

SELECT 
     sysobjects.name AS trigger_name 
    ,USER_NAME(sysobjects.uid) AS trigger_owner 
    ,s.name AS table_schema 
    ,OBJECT_NAME(parent_obj) AS table_name 
    ,OBJECTPROPERTY( id, 'ExecIsUpdateTrigger') AS isupdate 
    ,OBJECTPROPERTY( id, 'ExecIsDeleteTrigger') AS isdelete 
    ,OBJECTPROPERTY( id, 'ExecIsInsertTrigger') AS isinsert 
    ,OBJECTPROPERTY( id, 'ExecIsAfterTrigger') AS isafter 
    ,OBJECTPROPERTY( id, 'ExecIsInsteadOfTrigger') AS isinsteadof 
    ,OBJECTPROPERTY(id, 'ExecIsTriggerDisabled') AS [disabled] 
FROM sysobjects 

INNER JOIN sysusers 
    ON sysobjects.uid = sysusers.uid 

INNER JOIN sys.tables t 
    ON sysobjects.parent_obj = t.object_id 

INNER JOIN sys.schemas s 
    ON t.schema_id = s.schema_id 

WHERE sysobjects.type = 'TR' 



/* Procédures Stockés */

    /* Obtenir le classement pour un trathlon donnée */

CREATE OR ALTER PROCEDURE GetClassement
@CodeTri varchar(4)
AS
BEGIN
   SELECT numTriathlon, numeroTriathlete, tempsCourseCyscliste, tempsCourse, tempsNatation , (tempsCourseCyscliste + tempsNatation + tempsCourse) AS temps_total
   FROM INSCRIPTION
   WHERE numTriathlon = @CodeTri
   ORDER BY temps_total
END

exec GetClassement 'TRI1';
exec GetClassement 'TRI2';


