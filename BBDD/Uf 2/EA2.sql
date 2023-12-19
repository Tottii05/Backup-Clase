CREATE TABLE Persona (
    DNI VARCHAR(9),
    Nombre VARCHAR(10) NOT NULL,
    PrimerApellido VARCHAR(10) NOT NULL,
    SegundoApellido VARCHAR(10),
    Dirección VARCHAR(18) NOT NULL,
    Teléfono NUMERIC(9),
    CONSTRAINT PK_DNI PRIMARY KEY (DNI)
);

CREATE TABLE Profesor (
    DNI VARCHAR(9),
    Especialidad VARCHAR(15),
    CONSTRAINT PK_DNI_Prof PRIMARY KEY (DNI),
    CONSTRAINT FK_DNI FOREIGN KEY (DNI) References Persona (DNI)
);

CREATE TABLE Alumno (
    DNI VARCHAR(9),
    FechaNacimiento DATE NOT NULL,
    DNI_Delegado VARCHAR(9),
    CONSTRAINT PK_DNI_Alu PRIMARY KEY (DNI),
    CONSTRAINT FK_DNI_Alu_Del FOREIGN KEY (DNI_Delegado) References Alumno (DNI),
    CONSTRAINT Fk_DNI_Alu FOREIGN KEY (DNI) References Persona (DNI)
);

CREATE TABLE Módulo (
    Codigo VARCHAR(10),
    Nombre VARCHAR(10) NOT NULL,
    NumAula SMALLINT NOT NULL,
    CONSTRAINT PK_CG_Modulo PRIMARY KEY (Codigo),
    CONSTRAINT FK_NumAula FOREIGN KEY (NumAula) References Aula (Numero)
);

CREATE TABLE Asignatura (
    Codigo VARCHAR(10),
    Nombre VARCHAR(10),
    CONSTRAINT PK_CG PRIMARY KEY (Codigo)
);

CREATE TABLE Aula (
    Numero INTEGER NOT NULL,
    M2 FLOAT NOT NULL,
    CONSTRAINT PK_Num PRIMARY KEY (Numero)
);

CREATE TABLE Pertenece (
    CodMod VARCHAR(10) NOT NULL,
    CodAsig VARCHAR(10) NOT NULL,
    CONSTRAINT PK_pertenece PRIMARY KEY (CodMod, CodAsig),
    CONSTRAINT FK_pertenece_Mod FOREIGN KEY (CodMod) References Módulo (Codigo),
    CONSTRAINT FK_Pertenece_Aisg FOREIGN KEY (CodAsig) References Asignatura (Codigo)
);

CREATE TABLE Enseña (
    DNI_Prof VARCHAR(9),
    CodAsig VARCHAR(10),
    CONSTRAINT PK_Enseña PRIMARY KEY (DNI_Prof, CodAsig),
    CONSTRAINT FK_Enseña_Prof FOREIGN KEY (DNI_Prof) References Profesor (DNI),
    CONSTRAINT FK_Enseña_Asig FOREIGN KEY (CodAsig) References Asignatura (Codigo)
);

CREATE TABLE Matricula (
    DNI_Alu VARCHAR(9),
    CodAsig VARCHAR(10),
    CONSTRAINT PK_Matr PRIMARY KEY (DNI_Alu, CodAsig),
    CONSTRAINT FK_Matr FOREIGN KEY (DNI_Alu) References Alumno (DNI),
    CONSTRAINT FK_Matr_Aisg FOREIGN KEY (CodAsig) References Asignatura (Codigo)
);