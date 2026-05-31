CREATE DATABASE PetShopBanco;
GO

USE PetShopBanco;
GO

CREATE TABLE Usuarios (
	ID INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(250) NOT NULL,
	Cargo VARCHAR(250) NOT NULL,
	Login VARCHAR(250) NOT NULL,
	Senha VARCHAR(250) NOT NULL,
	AcessaProdutos BIT DEFAULT 0 NOT NULL,
	AcessaClientes BIT DEFAULT 0 NOT NULL,
	AcessaCidades BIT DEFAULT 0 NOT NULL,
	AcessaCategorias BIT DEFAULT 0 NOT NULL,
	Admin BIT DEFAULT 0 NOT NULL,
	Ativo BIT DEFAULT 1 NOT NULL
);
GO

INSERT INTO Usuarios VALUES
('Fernando', 'CEO', 'datorre', '1234', 1,1,1,1,1,1),
('Maria', 'Caixa', 'maria', '123',    1,1,1,1,0,1),
('Pedro', 'caixa', 'pedro', '123',    1,1,1,1,0,0);
GO


CREATE TABLE Categorias (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(100) NOT NULL,
    Descricao VARCHAR(250) NULL
);
GO

CREATE TABLE Produtos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(250) NOT NULL,
    Preco DECIMAL(10,2) NOT NULL,
    Estoque INT DEFAULT 0,
    IDCategoria INT NOT NULL,
    Ativo BIT DEFAULT 1 NOT NULL, -- Arquiteto Sênior: Exclusão Lógica implementada nativamente
    FOREIGN KEY (IDCategoria) REFERENCES Categorias(ID)
);
GO

CREATE TABLE Clientes (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(250) NOT NULL,
    CPF VARCHAR(15) NULL,
    Telefone VARCHAR(20) NOT NULL,
    Cidade VARCHAR(150) NOT NULL,
    Estado CHAR(2) NOT NULL
);
GO

CREATE TABLE Agendamentos (
    ID INT PRIMARY KEY IDENTITY(1,1),
    IDCliente INT NOT NULL,
    NomeAnimal VARCHAR(150) NOT NULL,
    TipoAnimal VARCHAR(100) NOT NULL,
    Servico VARCHAR(200) NOT NULL, 
    DataAgendamento DATE NOT NULL,
    Horario TIME NOT NULL,
    Valor DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IDCliente) REFERENCES Clientes(ID),

    CONSTRAINT UQ_Agendamento_Data_Hora UNIQUE (DataAgendamento, Horario)
);
GO