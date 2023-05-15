CREATE DATABASE DINOSSAUROS;

CREATE TABLE DINOSSAURO (
	ID INTEGER NOT NULL PRIMARY KEY IDENTITY,
	NOME VARCHAR(50) NOT NULL,
	GRUPO_FK INTEGER NOT NULL,
	TONELADAS INTEGER NOT NULL,
	ANO_DESCOBERTA INT NOT NULL,
	DESCOBRIDOR VARCHAR(50) NOT NULL,
	FK_ERA INTEGER NOT NULL,
	PAIS VARCHAR(50) NOT NULL,
	FOREIGN KEY (FK_ERA) REFERENCES ERA(ID),
	FOREIGN KEY (GRUPO_FK) REFERENCES GRUPO(ID),
)

CREATE TABLE ERA(
	ID INTEGER NOT NULL PRIMARY KEY IDENTITY,
	ERA_EXISTENCIA VARCHAR(50),
	ERA_INICIO INTEGER,
	ERA_FIM INTEGER,
)
CREATE TABLE GRUPO(
	ID INTEGER NOT NULL PRIMARY KEY IDENTITY,
	NOME VARCHAR(50) NOT NULL
)


INSERT INTO ERA (ERA_EXISTENCIA, ERA_INICIO, ERA_FIM)
VALUES ('Tri�ssico', 252, 201), ('Jur�ssico', 201, 145), ('Cret�ceo', 145, 66);

INSERT INTO GRUPO (NOME)
VALUES ('Ter�podes'), ('Sauropodomorfos'), ('Ornit�podes'), ('Ceratops�deos'), ('Paquicefalossauros');

INSERT INTO DINOSSAURO (NOME, GRUPO_FK, TONELADAS, ANO_DESCOBERTA, DESCOBRIDOR, FK_ERA, PAIS)
VALUES ('Tiranossauro Rex', 1, 7, 1902, 'Barnum Brown', 2, 'Estados Unidos'),
('Velociraptor', 1, 0.05, 1924, 'Roy Chapman Andrews', 2, 'Mong�lia'),
('Apatossauro', 2, 25, 1877, 'Othniel Charles Marsh', 1, 'Estados Unidos'),
('Stegossauro', 2, 2.5, 1877, 'Othniel Charles Marsh', 1, 'Estados Unidos'),
('Parassaurolofo', 3, 2.5, 1922, 'William Parks', 2, 'Canad�'),
('Triceratops', 4, 8, 1887, 'John Bell Hatcher', 1, 'Estados Unidos'),
('Estegoceratops', 4, 5, 2010, 'Scott Sampson', 3, 'Canad�'),
('Pachycephalosaurus', 5, 0.5, 1943, 'Charles W. Gilmore', 2, 'Estados Unidos');

SELECT D.ID, D.NOME, G.NOME AS GRUPO, D.TONELADAS, D.ANO_DESCOBERTA, D.DESCOBRIDOR, E.ERA_EXISTENCIA, E.ERA_INICIO, E.ERA_FIM, D.PAIS
FROM DINOSSAURO D
INNER JOIN GRUPO G ON D.GRUPO_FK = G.ID
INNER JOIN ERA E ON D.FK_ERA = E.ID;

DROP TABLE ERA;
DROP TABLE GRUPO;
DROP TABLE DINOSSAURO;
DROP DATABASE DINOSSAUROS;

