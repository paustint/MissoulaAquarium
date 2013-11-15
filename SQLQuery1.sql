
CREATE TABLE TestDB.testTable (
                idTestTable INT IDENTITY NOT NULL,
                name VARCHAR(50) NOT NULL,
                CONSTRAINT testTable_pk PRIMARY KEY (idTestTable)
)

CREATE TABLE TestDB.house (
                idHouse VARCHAR(50) IDENTITY NOT NULL,
                Address VARCHAR(50) NOT NULL,
                Color VARCHAR(25) NOT NULL,
                idTestTable INT NOT NULL,
                CONSTRAINT house_pk PRIMARY KEY (idHouse)
)

ALTER TABLE TestDB.house ADD CONSTRAINT testTable_house_fk
FOREIGN KEY (idTestTable)
REFERENCES TestDB.testTable (idTestTable)
ON DELETE NO ACTION
ON UPDATE NO ACTION