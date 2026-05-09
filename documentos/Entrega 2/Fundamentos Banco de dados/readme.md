create database messier;
use messier;


CREATE TABLE Pacote (
    ID_Pacote  INT NOT NULL primary key,
    nome  VARCHAR(100) NOT NULL,
    preco_mensal  DECIMAL(8,2) NOT NULL,
    limite_mensal INT
);

CREATE TABLE Jogo (
    ID_Jogo INT NOT NULL primary key,
    nome  VARCHAR(150) NOT NULL,
    tema   VARCHAR(100),
    descricao TEXT,
    faixa_etaria VARCHAR(10),
    status VARCHAR(20) DEFAULT 'ativo',
    ID_Pacote INT,
    FOREIGN KEY (ID_Pacote) REFERENCES Pacote(ID_Pacote)
);


CREATE TABLE Escola (
    ID_Escola INT NOT NULL primary key,
    nome   VARCHAR(150) NOT NULL,
    CNPJ   VARCHAR(18) UNIQUE NOT NULL,
    endereco  VARCHAR(255),
    ID_Pacote INT,
    FOREIGN KEY (ID_Pacote) REFERENCES Pacote(ID_Pacote)
);


CREATE TABLE IP_Autorizado (
    ID_IP INT NOT NULL primary key,
    endereco_IP VARCHAR(45) NOT NULL,
    ID_Escola   INT NOT NULL,
    FOREIGN KEY (ID_Escola) REFERENCES Escola(ID_Escola)
);


CREATE TABLE Registro (
    ID_Registro INT NOT NULL primary key,
    data_hora  DATETIME NOT NULL,
    escola  VARCHAR(150),
    jogo  VARCHAR(150),
    IP  VARCHAR(45),
    resultado   VARCHAR(100),
    ID_Jogo  INT NOT NULL,
    ID_Escola INT NOT NULL,
    FOREIGN KEY (ID_Jogo)   REFERENCES Jogo(ID_Jogo),
    FOREIGN KEY (ID_Escola) REFERENCES Escola(ID_Escola)
);