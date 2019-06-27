/*Codigo de Creacion de la Base de Datos*/
CREATE DATABASE IF NOT EXISTS SifAdmin 
COLLATE='utf8_spanish2_ci'
ENGINE=InnoDB;

USE sifadmin;

CREATE TABLE Departamentos(
	Codigo_Departamento VARCHAR(2) NOT NULL,
	Nombre_Departamento VARCHAR(50) NOT NULL,
	PRIMARY KEY (`Codigo_Departamento`)
);

USE sifadmin;

CREATE TABLE Municipios (
	Codigo_Departamento VARCHAR(2) NOT NULL,
	Codigo_Municipio VARCHAR(3) NOT NULL,
	Nombre_Municipio VARCHAR(50) NOT NULL,
	Codigo_Completo VARCHAR(5) NOT NULL,
	PRIMARY KEY (`Codigo_Completo`),
	FOREIGN KEY (Codigo_Departamento) REFERENCES Departamentos(Codigo_Departamento) 
);