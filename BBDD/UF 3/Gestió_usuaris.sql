/*Administració*/
CREATE TABLE administracio.PERSONA (
    dni VARCHAR(20) PRIMARY KEY,
    nom VARCHAR(100),
    cognom1 VARCHAR(100),
    cognom2 VARCHAR(100),
    data_naix DATE,
    telefon VARCHAR(20),
    mail VARCHAR(100)
);

CREATE TABLE administracio.PACIENT (
    dni_pacient VARCHAR(20) PRIMARY KEY REFERENCES administracio.PERSONA(dni),
    nss VARCHAR(20),
    genere CHAR(1)
);

CREATE TABLE administracio.METGE (
    dni_metge VARCHAR(20) PRIMARY KEY REFERENCES administracio.PERSONA(dni),
    especialitat VARCHAR(100)
);

CREATE TABLE administracio.TECNIC (
    dni_tecnic VARCHAR(20) PRIMARY KEY REFERENCES administracio.PERSONA(dni),
    data_inici DATE
);

CREATE TABLE administracio.PROVEIDOR (
    cif VARCHAR(20) PRIMARY KEY,
    nom VARCHAR(100),
    telefon VARCHAR(20),
    mail VARCHAR(100)
);

/*Clínica*/
CREATE TABLE clinica.CONSULTORI (
    codi_cons INT PRIMARY KEY,
    ubicacio VARCHAR(100),
    superficie DECIMAL(10,2)
);

CREATE TABLE clinica.VISITA (
    codi_visita INT PRIMARY KEY,
    dni_pacient VARCHAR(20) REFERENCES administracio.PACIENT(dni_pacient),
    dni_metge VARCHAR(20) REFERENCES administracio.METGE(dni_metge),
    codi_cons INT REFERENCES clinica.CONSULTORI(codi_cons),
    data_visita DATE,
    preu DECIMAL(10,2),
    informe VARCHAR(255)
);

/*Laboratori*/
CREATE TABLE laboratori.MOSTRA (
    codi_mostra INT,
    dni_pacient VARCHAR(20),
    tipus VARCHAR(100),
    data_extr DATE,
    PRIMARY KEY (codi_mostra, dni_pacient),
    FOREIGN KEY (dni_pacient) REFERENCES administracio.PACIENT(dni_pacient)
);

CREATE TABLE laboratori.REACTIU (
    codi_reac INT PRIMARY KEY,
    nom VARCHAR(100),
    preu DECIMAL(10,2),
    cif_prov VARCHAR(20) REFERENCES administracio.PROVEIDOR(cif)
);

CREATE TABLE laboratori.TEST (
    codi_test INT PRIMARY KEY,
    codi_mostra INT,
    dni_pacient VARCHAR(20),
    dni_tecnic VARCHAR(20) REFERENCES administracio.TECNIC(dni_tecnic),
    codi_reac INT REFERENCES laboratori.REACTIU(codi_reac),
    resultat VARCHAR(255),
    data_resultat DATE,
    preu DECIMAL(10,2),
    FOREIGN KEY (codi_mostra, dni_pacient) REFERENCES laboratori.MOSTRA(codi_mostra, dni_pacient)
);
