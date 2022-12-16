create database Escola
go

create table Alunos
(
    ID integer not null identity,
    NOME varchar(2000) not null,
    RM integer not null
)
go

insert into Alunos (nome, rm) values ('Lucas', 123456)
go
