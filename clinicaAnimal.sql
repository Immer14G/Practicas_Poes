CREATE TABLE Propietarios (
    IdPropietario INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Nombre VARCHAR(75) NOT NULL,
    Telefono VARCHAR(15) NOT NULL,
    Direccion VARCHAR(100) NOT NULL
);


INSERT INTO Propietarios (Nombre, Telefono, Direccion)
VALUES ('Juan Pérez', '555-1234', 'Calle Principal 123');


DELETE FROM Propietarios WHERE IdPropietario = 1;


UPDATE Propietarios
SET Telefono = '555-5678'
WHERE IdPropietario = 2;


SELECT * FROM Propietarios;


CREATE TABLE Pacientes (
    IdPaciente INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Nombre VARCHAR(75),
    Raza VARCHAR(75),
    IdPropietario INT,
    FOREIGN KEY (IdPropietario) REFERENCES Propietarios(IdPropietario)
);


INSERT INTO Pacientes (Nombre, Raza, IdPropietario)
VALUES ('Milo', 'Labrador Retriever', 1);


DELETE FROM Pacientes WHERE IdPaciente = 1;


UPDATE Pacientes
SET Raza = 'Golden Retriever'
WHERE IdPaciente = 2;

SELECT * FROM Pacientes;


CREATE TABLE Medicos (
    IdMedico INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    Nombre VARCHAR(75),
    Especialidad VARCHAR(74),
    Telefono VARCHAR(75)
);

INSERT INTO Medicos (Nombre, Especialidad, Telefono)
VALUES ('Dra. María Gómez', 'Cirugía', '555-7890');

DELETE FROM Medicos WHERE IdMedico = 1;


UPDATE Medicos
SET Telefono = '555-9876'
WHERE IdMedico = 2;


SELECT * FROM Medicos;

CREATE TABLE Citas (
    idcita INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    IdPaciente INT,
    IdMedico INT,
    FechaCita DATETIME,
    Enfermedad VARCHAR(75)
)

INSERT INTO Citas (IdPaciente, IdMedico, FechaCita, Enfermedad)
VALUES (2, 2, '2023-09-23 10:00:00', 'Fiebre');

DELETE FROM Citas WHERE idcita = 1;

UPDATE Citas
SET Enfermedad = 'Gripe'
WHERE idcita = 2;


SELECT * FROM Citas;
