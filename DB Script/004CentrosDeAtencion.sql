USE sifadmin;

CREATE TABLE Centros_de_Atencion(
	Codigo _Centro INT NOT NULL AUTO_INCREMENT,
	Nombre_Centro VARCHAR(50) NULL,
	Hospitaliza TINYINT(3) UNSIGNED NULL,
	IPS TINYINT(3) UNSIGNED]NULL,
	PRIMARY KEY (`Codigo _Centro`),
	FOREIGN KEY (IPS) REFERENCES Ips(Control) 
);