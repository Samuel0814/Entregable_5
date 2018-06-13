CREATE DATABASE Entregable5Db
GO
USE Entregable5Db
GO
CREATE TABLE Grupos(
	GrupoId int primary key identity,
	Fecha date,
	Descripcion varchar(50),
	Cantidad int,
	Grupox int,
	Integrantes int
);