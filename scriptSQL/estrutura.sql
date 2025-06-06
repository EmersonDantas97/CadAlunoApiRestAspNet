-- Criando banco de dados
create database SistemaAcademia;
go

Use SistemaAcademia;

-- Criando minha tabela
Create table Aluno 
(
	Id int identity(1,1),
	NomeCompleto Varchar(100) not null,
	Cpf Varchar(11) not null,
	Telefone Varchar(15),
	Sexo char(1) not null,
	DataNascimento Date not null,
	Altura decimal (3,2),
	Peso decimal (4,1),
	DataCadastro DateTime not null,
	Status char(1) not null,
	Constraint pk_Aluno primary key (Id)
);
