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
CREATE TABLE Personas
(
	Id int primary key identity(1,1),
	Nombre varchar(30),
	Telefono varchar(13),
	Cedula varchar(13),
	Direccion varchar(max)
);