-- EXERCICI 1 --
/*
 Escriu les sentències necessàries per crear les taules ORDERF, PRODUCT i
ORDER_DETAILS en la base de dades shop. tenint en compte les restriccions indicades en
l’estructura de la base de dades.
*/
CREATE TABLE ORDERF (
    order_id NUMERIC(12),
    order_date DATE,
    shipped_date DATE,
    ship_address VARCHAR(50) NOT NULL,
    ship_city VARCHAR(20),
    ship_region VARCHAR(20),
    CONSTRAINT CK_ship_region CHECK (ship_region IN ('USA', 'EUROPA', 'ASIA', 'AMERICA', 'RUSIA')),
    CONSTRAINT CK_shipped_date CHECK (shipped_date > order_date),
    CONSTRAINT PK_ORDER_ID PRIMARY KEY (order_id));

CREATE TABLE PRODUCT (
    product_id NUMERIC(12),
    product_name VARCHAR(50) NOT NULL,
    unitprice DOUBLE PRECISION NOT NULL,
    unitstock NUMERIC(3) NOT NULL,
    unitonorder NUMERIC(3) NOT NULL DEFAULT 1,
    CONSTRAINT PK_PRODUCT_ID PRIMARY KEY (product_id));

CREATE TABLE ORDER_DETAILS (
    order_id NUMERIC(12) NOT NULL,
    product_id NUMERIC(12) NOT NULL,
    quantity NUMERIC(3) NOT NULL,
    discount NUMERIC(3),
    CONSTRAINT PK_ORDER_PRODUCT PRIMARY KEY (order_id, product_id),
    CONSTRAINT FK_ORDER_ID FOREIGN KEY (order_id) REFERENCES ORDERF (order_id),
    CONSTRAINT FK_PRODUCT_ID FOREIGN KEY (product_id) REFERENCES PRODUCT (product_id));


/*
Comprova que les 3 taules s'han creat correctament amb la comanda que mostra
la definició de les taules amb els camps de les taules, tipus de dades, etc.
*/
\d

/*
Una vegada creades les taules, ens hem adonat que hi ha un error a la taula
ORDERF. Hem de modificar dos camps.
*/

ALTER TABLE ORDERF DROP COLUMN ship_city;
ALTER TABLE ORDERF DROP COLUMN ship_region;
ALTER TABLE ORDERF ADD ship_city VARCHAR(40);
ALTER TABLE ORDERF ADD ship_region VARCHAR(40);

/*
Crea una seqüència perquè el camp product_id es pugui autoincrementar.
Que comenci per 1, que incrementi 1 i el valor màxim sigui 99999.
*/

CREATE SEQUENCE product_sequence INCREMENT 1 START WITH 1 MAXVALUE 99999;

/* 
Introdueix les següents dades a la taula PRODUCT. Utilitza la seqüencia
creada en l’exercici anterior i comprova que s’han inserit correctament els valors.
*/

insert into PRODUCT (product_id, product_name, unitprice, unitstock, unitonorder)
values
(CURRVAL('product_sequence'), 'nikkon ds90', 67.09, 75, 1),
(NEXTVAL('product_sequence'), 'canon t90', 82.82, 92, 1),
(NEXTVAL('product_sequence'), 'dell inspirion', 182.78, 56, 2),
(NEXTVAL('product_sequence'), 'ipad air', 482.83, 34, 2),
(NEXTVAL('product_sequence'), 'microsoft surface', 93.84, 92, 2),
(NEXTVAL('product_sequence'), 'nexus 6', 133.88, 16, DEFAULT),
(NEXTVAL('product_sequence'), 'thinkpad t365', 341.02, 22, DEFAULT);

/*
Intenta inserir els següents registres a la taula ORDERF. La informació que
ha de contenir la taula és la següent:
*/
insert into ORDERF (order_id, order_date, shipped_date, ship_address, ship_city, ship_region)
values (4001, '2016-04-04', '2016-11-06', '93 Spohn Place', 'Manggekompo', 'ASIA');
insert into ORDERF (order_id, order_date, shipped_date, ship_address, ship_city, ship_region)
values (4002, '2017-01-29', '2016-05-28', '46 Eliot Trail', 'Virginia', 'USA');
insert into ORDERF (order_id, order_date, shipped_date, ship_address, ship_city, ship_region)
values (4001, '2016-08-19', '2016-12-08', '23 Sundown Junction', 'Obodivka', 'RUSIA');
insert into ORDERF (order_id, order_date, shipped_date, ship_address, ship_city, ship_region)
values (4004, '2016-09-25', '2016-12-24', NULL, 'Nova Venécia', 'AMERICA');
insert into ORDERF (order_id, order_date, shipped_date, ship_address, ship_city, ship_region)
values (4005, '2017-03-14', '2017-03-19', '7 Ludington Court', 'Sukamaju', 'ASIA');
insert into ORDERF (order_id, order_date, shipped_date, ship_address, ship_city, ship_region)
values (4006, '2016-08-14', '2016-12-05', '859 Dahle Plaza', NULL, 'ASIA');
insert into ORDERF (order_id, order_date, shipped_date, ship_address, ship_city, ship_region)
values (4007, '2017-01-02', '01-02-2017', '5 Fuller Center Log pri', 'Brezovici', 'EUROP');

/*
Si a l’introduir les dades en la taula ORDERF et dona errors, explica l’error que et dona i no
insereixis el registre.
*/
-- Da error porque donde order_id = 4007 tiene en el campo shipped_date la fecha al revés --

/*
Intenta inserir els següents registres a la taula ORDER_DETAILS. La infor-
mació que ha de contenir la taula és la següent:
*/

insert into ORDER_DETAILS (order_id, product_id, quantity, discount)
values (4001, 1 ,5 ,8.73);
insert into ORDER_DETAILS (order_id, product_id, quantity, discount)
values (4003, 3, 8, 4.01);
insert into ORDER_DETAILS (order_id, product_id, quantity, discount)
values (4005, 601, 2, 3.05);
insert into ORDER_DETAILS (order_id, product_id, quantity, discount)
values (4006, 2, 4, 5.78);

/*
Si a l’introduir les dades en la taula ORDER_DETAILS et dona errors, explica l’error que et dona i
no insereixis el registre. Com que el camp discount el vam crear com a NUMERIC(3) ara l’hem de
modificar i que sigui DOUBLE PRECISION.
*/
-- Da error porque los campos order_id es foránea y están vacíos en la tabla ORDERF por lo tanto busca y dice que no existe --

ALTER TABLE ORDER_DETAILS DROP COLUMN discount;
ALTER TABLE ORDER_DETAILS ADD discount DOUBLE PRECISION;

--EXERCICI 2--
/*
Crea un índex per la taula ORDERF, pel camp ship_address.
*/
CREATE INDEX ship_address_index ON ORDERF(ship_address);

/*
Crea un índex únic per la taula PRODUCT, pel camp product_name.
*/
CREATE UNIQUE INDEX product_name_index ON PRODUCT(product_name);

--EXERCICI 3--
/*
Afegeix els següents camps a la taula ORDERF:
cost_ship DOUBLE PRECISION DEFAULT 1500,
logistic_cia VARCHAR(100),
others VARCHAR(250),
*/

ALTER TABLE ORDERF ADD cost_ship DOUBLE PRECISION DEFAULT 1500;
ALTER TABLE ORDERF ADD logistic_cia VARCHAR(100);
ALTER TABLE ORDERF ADD others VARCHAR(250);
ALTER TABLE ORDERF ADD CONSTRAINT CK_logistic_cia CHECK (logistic_cia IN ('UPS', 'MRW', 'Post_Office', 'Fedex', 'TNT', 'DHL', 'Moldtrans', 'SEUR'));

/*
Elimina el camp others de la taula ORDERF.
*/

ALTER TABLE ORDERF DROP COLUMN others;

--EXERCICI 4--
/*
Modifica els valors del camp discount de la taula ORDER_DETAILS dels
registres que la quantitat sigui més gran que 2. El nou descompte serà 7.5. Comprova que s'ha
efectuat el canvi.
*/

BEGIN;
update ORDER_DETAILS set discount = 7.5 where quantity > 2;

/*
desfés els canvis que has fet en l'apartat anterior i comprova si s'han desfet.
*/
ROLLBACK;

/*
Elimina els productes que tinguin un unitstock < 30 i fes que els canvis siguin
permanents.
*/
BEGIN;
DELETE FROM PRODUCT WHERE unitstock < 30;
COMMIT;

/*
Elimina la comanda de la taula ORDERF amb order_id = 4006. Si no la pots eliminar explica perquè no pots, i realitza les modificacions que siguin necessàries a les taules perquè la puguis eliminar. Comprova que realment s'ha eliminat la comanda.
*/

DELETE FROM ORDERF WHERE order_id = 4006;
-- No se puede eliminar porque no es "independiente", si se elimina no solo afectaría a esta tabla sino que a ORDER_DETAILS también por lo tanto no deja hacerlo--
ALTER TABLE ORDER_DETAILS DROP CONSTRAINT FK_ORDER_ID;