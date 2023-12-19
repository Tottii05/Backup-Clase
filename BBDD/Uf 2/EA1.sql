CREATE TABLE Empleado (
    ID INTEGER NOT NULL,
    DNI VARCHAR(9) UNIQUE,
    Nombre VARCHAR(10) NOT NULL,
    FechaNac DATE NOT NULL,
    Teléfono NUMERIC(9),
    Salario FLOAT NOT NULL,
    CodLocalidad VARCHAR(5) NOT NULL,
    CONSTRAINT UQ_DNI UNIQUE (DNI),
    CONSTRAINT PK_ID PRIMARY KEY (ID),
    CONSTRAINT FK_CL FOREIGN KEY (CodLocalidad) REFERENCES Localidad(CodLocalidad)
);

CREATE TABLE Localidad (
    CodLocalidad VARCHAR(5) NOT NULL, 
    Nombre  VARCHAR(10),
    CodProvincia VARCHAR(5) NOT NULL,
    CONSTRAINT PK_DL PRIMARY KEY (CodLocalidad),
    CONSTRAINT FK_CP FOREIGN KEY (CodProvincia) REFERENCES Provincia (CodProvincia)      
);

CREATE TABLE Provincia (
    CodProvincia VARCHAR(8) NOT NULL,
    Nombre VARCHAR(10),
    CodRegión VARCHAR(10),
    CONSTRAINT PK_CP PRIMARY KEY (CodProvincia),
    CONSTRAINT FK_CR FOREIGN KEY (CodRegión) REFERENCES Región (CodRegión)
);

CREATE TABLE Región (
    CodRegión VARCHAR(5) NOT NULL,
    Nombre VARCHAR(10),
    CONSTRAINT PK_CR PRIMARY KEY (CodRegión)
);

