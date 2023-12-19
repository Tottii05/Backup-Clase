-- INICI --
CREATE DATABASE biblio;
CREATE USER biblio WITH SUPERUSER CREATEROLE ENCRYPTED PASSWORD 'biblio';
GRANT ALL PRIVILEGES ON DATABASE biblio TO biblio;

-- EX 1 --
CREATE TABLE SOCI (
    idsoci SERIAL NOT NULL,
    nom VARCHAR(30),
    cognoms VARCHAR(50),
    dni VARCHAR (9) NOT NULL,
    telefon NUMERIC(9) NOT NULL,
    email VARCHAR(35) NOT NULL,
    CONSTRAINT PK_idsoci PRIMARY KEY (idsoci));

CREATE TABLE PRESTEC (
    idprestec NUMERIC(35) NOT NULL,
    idllibre NUMERIC(15),
    dataPres DATE,
    dataRet DATE,
    idsoci INTEGER,
    estat CHAR(1),
    penalitzacio NUMERIC(10) NOT NULL DEFAULT 1,
    CONSTRAINT PK_idprestec PRIMARY KEY (idprestec),
    CONSTRAINT FK_idsoci FOREIGN KEY (idsoci) REFERENCES SOCI (idsoci),
    CONSTRAINT CK_esteat CHECK (estat IN ('R','P')),
    CONSTRAINT CK_penalitzacio CHECK (penalitzacio > 0));

CREATE TABLE LLIBRE (
    idllibre NUMERIC(15) NOT NULL,
    isbn VARCHAR(25) NOT NULL UNIQUE,
    titol VARCHAR(70),
    autor VARCHAR(60) NOT NULL,
    CONSTRAINT PK_idllibre PRIMARY KEY (idllibre));

-- EX 2 --
ALTER TABLE SOCI DROP COLUMN email;
SELECT * FROM SOCI;

-- EX 3 --
ALTER TABLE SOCI ADD COLUMN email VARCHAR(40);
SELECT * FROM SOCI;

-- EX 4 --
ALTER TABLE PRESTEC RENAME CONSTRAINT CK_penalitzacio TO penalty_ck;

-- EX 5 -- 
ALTER TABLE SOCI ALTER COLUMN idsoci SET DATA TYPE NUMERIC(15);

-- EX 6 --
ALTER TABLE PRESTEC ADD CONSTRAINT CK_dates CHECK (dataRet > dataPres);

-- EX 7 --
insert into SOCI (idsoci, nom, cognoms, dni, telefon, email) values (01, 'tomas', 'vicente caffaratti', 'dni', 644333767,'tomasvicente.com');
insert into SOCI (idsoci, nom, cognoms, dni, telefon, email) values (02, 'juan', 'vicente caffaratti', 'dni', 644333790,'email.com');
insert into SOCI (idsoci, nom, cognoms, dni, telefon, email) values (03, 'pedro', 'vicente caffaratti', 'dni', 644333756,'mail.com');
insert into SOCI (idsoci, nom, cognoms, dni, telefon, email) values (04, 'diego', 'vicente caffaratti', 'dni', 644333734,'correo.com');
insert into SOCI (idsoci, nom, cognoms, dni, telefon, email) values (05, 'marta', 'vicente caffaratti', 'dni', 644333712,'hola.com');
SELECT * FROM SOCI;

-- EX 8 --
insert into LLIBRE (idllibre, isbn, titol, autor) values (2121213, '0-7645-2641-22', 'Preludi de la fundació', 'Isaac Asimov');
insert into LLIBRE (idllibre, isbn, titol, autor) values (2124215, '0-7645-2481-1' , 'Estranger Albert', 'Camus');
insert into LLIBRE (idllibre, isbn, titol, autor) values (2123217, '0-7645-2633-3', 'Jo Claudi Robert', 'Graves');
insert into LLIBRE (idllibre, isbn, titol, autor) values (2121213, '0-7645-2641-3', 'Ulises James', 'Joyce');
insert into LLIBRE (idllibre, isbn, titol, autor) values (2126219, '0-7645-34641-11', 'Els miserables', 'Victor Hugo');
insert into LLIBRE (idllibre, isbn, titol, autor) values (21292110, '0-8445-2641-45', 'Rayuela', 'Julio Cortázar');
insert into LLIBRE (idllibre, isbn, titol, autor) values (21212124, '0-7645-2633-3', 'El vell i el mar', 'Ernest Hemingway');
insert into LLIBRE (idllibre, isbn, titol, autor) values (212123234, NULL, 'La taronja mecànica', 'Anthony Burgess');
/* la insercion del libro de ulises da error pq tiene duplicada el id*/
/* la ultima insercion da error porque el campo que deja vacío es olbigatorio*/

-- EX 9 --
CREATE SEQUENCE
idprestec_seq
INCREMENT 5
START WITH 10
MAXVALUE 9000000;

-- EX 10 --
INSERT INTO PRESTEC (idprestec, idllibre, dataPres, dataRet, idsoci, estat, penalitzacio) VALUES
(NEXTVAL('idprestec_seq'), 2121213, '2016-04-04', '2016-11-06', 4, 'R', NULL);
INSERT INTO PRESTEC (idprestec, idllibre, dataPres, dataRet, idsoci, estat, penalitzacio) VALUES
(NEXTVAL('idprestec_seq'), 2123217, '2017-01-29', '2017-05-28', 3, 'R', 2);
INSERT INTO PRESTEC (idprestec, idllibre, dataPres, dataRet, idsoci, estat, penalitzacio) VALUES
(NEXTVAL('idprestec_seq'), 21331216, '2021-08-19', '2021-12-08', 1, 'R', 3);
INSERT INTO PRESTEC (idprestec, idllibre, dataPres, dataRet, idsoci, estat, penalitzacio) VALUES
(NEXTVAL('idprestec_seq'), 21292110, '2019-09-25', '2019-12-24', 2, 'P', NULL);
INSERT INTO PRESTEC (idprestec, idllibre, dataPres, dataRet, idsoci, estat, penalitzacio) VALUES
(NEXTVAL('idprestec_seq'), 2123217, '2017-03-14', '2017-03-11', 2, 'R', 2);
INSERT INTO PRESTEC (idprestec, idllibre, dataPres, dataRet, idsoci, estat, penalitzacio) VALUES
(NEXTVAL('idprestec_seq'), 2124215, '2019-08-14', '2020-01-05', 1, 'S', NULL);
INSERT INTO PRESTEC (idprestec, idllibre, dataPres, dataRet, idsoci, estat, penalitzacio) VALUES
(NEXTVAL('idprestec_seq'), 2123217, '2017-01-02', '01-02-2017', 9, 'R', 3);
/* Por lo general fallan todas por tener la penalització vacía siendo obligatoria*/
/* El idllibre 2123217 da error por la restricción de la fechas*/
/*EL idllibre 2123217 da error porque idsoci 9 no existe*/

-- 11 --
UPDATE PRESTEC
SET estat = 'R' WHERE penalitzacio = 1;

-- EX 12 -- 
DELETE FROM LLIBRE WHERE idllibre = 2126219;

-- EX 13 --
DROP TABLE SOCI;
/* No se puede eliminar porque hay otras tablas colgada a esta (Tabla PRESTEC)*/

-- EX 14 -- 
DELETE FROM SOCI;
/* No se puede porque hay campos que le hacen referencia a otras tablas (campo idsoci --> tabla PRESCTEC)*/

-- EX 15 -- 
CREATE VIEW titolsllibres AS SELECT titol, autor FROM LLIBRE;
SELECT * FROM titolsllibres;

-- EX 16 -- 
CREATE VIEW socisambprestec AS SELECT nom, cognoms, telefon FROM SOCI
JOIN PRESTEC ON estat = 'R';

-- EX 17 --
CREATE UNIQUE INDEX llibre_idx ON LLIBRE (isbn);

-- EX 18 --
CREATE INDEX soci_idx ON SOCI (cognoms);

-- EX 19 --
UPDATE LLIBRE
SET idllibre = 3121213 WHERE idllibre = 2121213;

-- EX 20 --
/* A) La tabla sigue estando vacía porque después de añadir esa fila no se han confirmado los cambios con un commit.*/
/* B) La tabla sigue vacía pero además con el DELETE daría error porque buscaría ese idllibre=40 pero no existe porque la tabla esta vacía. En el caso que existiera ese idllibre=40 seguiría estando vacía porque se hizo un rollback.*/
/* C) La tabla tiene 1 fila ahora, porque esta vez después del insert se hizo un commit para guardar los cambios permanentemente.*/
/* D) La tabla sigue teniendo las 1 fila porque se ha hecho un borrado donde el idllibre=50 pero un rollback después, por lo tanto no se guardan los cambios.*/
/* E) La tabla únicamente tiene 1 fila, pero hay 2 filas más a la espera de un commit para añadirlas, como extra también hay un savepoint A para usarlo más tarde si se desea.*/
/* F) Seguiría en el mismo punto que el anterior, ese insert antes del rollback no se aplicaría, pero siguen estando a la espera del commit las 2 filas antes del savepont intA.*/
/* G) Ahora se han hecho muchos cambios a la vez, por una parte se añadieron las 2 filas que estaban a la espera, por otra parte se ha modificado el autor donde isbn = 12345680 */
/* H) La tabla quedría finalmente con sus 3 filas de información y con el autor donde isbn = 12345680, porque ese rollback to intA no funcionaría porque después del hacer el commit todos los savepoint quedan destruidos.*/
