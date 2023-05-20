CREATE DATABASE Proyecto;

USE Proyecto;

CREATE TABLE Ventas (
    id_venta INT IDENTITY(1,1) PRIMARY KEY,
    id_producto INT,
    cantidad INT,
	codigo_cliente int, 
	nombre varchar(80), 
	direccion varchar(120), 
	correo varchar(150), 
	nit int
);




CREATE TABLE Compras (
    id_compras INT IDENTITY(1,1) PRIMARY KEY,
    id_producto INT,
    cantidad INT,
	NIT int, 
	nombre varchar(100),
	direccion varchar(100),
	telefono int,
	correo varchar(120), 
	portal varchar(50)
);




CREATE TABLE productos (
id_producto INT NOT NULL PRIMARY KEY, 
descripción VARCHAR(80), 
id_categoria INT NOT NULL, 
precio INT NOT NULL, 
disponible INT NOT NULL, 
detalles VARCHAR(80)
);

INSERT INTO productos(id_producto, descripción, id_categoria, precio, disponible, detalles) VALUES
(7, 'Lapicero Bic Rosado', 1, 3, 8,'Lapicero especial para escritura en carta'),
(8, 'Lapicero BIC azul', 1, 2, 9,'Lapicero especial para escritura en matemática'),
(9, 'Lapicero BIC Rojo', 1, 3, 11,'Lapicero especial para escritura en caligrafía'),
(10, 'Bolson Totto Mx-352', 3, 350, 15, 'Especial para traslado de computadoras');




CREATE TABLE categorías (
  id INT PRIMARY KEY,
  descripcion VARCHAR(45) NOT NULL
);

INSERT INTO categorías(id, descripcion) VALUES
(4, 'Marcador permanente'),
(3, 'Lapiceros'),
(1, 'libros'),
(2, 'Lapices'),
(5, 'Crayones'),
(6, 'Bolsones');





CREATE TABLE customer (codigo_cliente int IDENTITY(1,1) not null primary key, 
nombre varchar(80) not null, 
direccion varchar(120) not null, 
correo varchar(150) not null, 
nit int not null);

INSERT INTO customer VALUES ('José Carlos de León Juárez', 'Aldea Estanzuelas', 'jose02@gmail.com', 19558889); 






CREATE TABLE proveedores (NIT int primary key not null, 
nombre varchar(100) not null, 
direccion varchar(100) not null, 
telefono int not null, 
correo varchar(120) not null, 
portal varchar(50) not null);

INSERT INTO proveedores VALUES (105192933, 'Luis Felipe Herrera Donis', 'Aldea La Casita', 49888936, 'luisherrera.lh925@gmail.com', 'Físico');






CREATE TABLE factura (numero int identity (1,1), 
NIT int not null, 
serie varchar(10) not null, 
nombre varchar(80) not null);

INSERT INTO factura VALUES (105991929, 'A-2', 'La Republicana'),
(19557899, 'A-3', 'La Democrática'),
(20788899, 'A-7', 'El Porvenir'), 
(48778997, 'A-4', 'Caballeros S.A.');


CREATE TRIGGER realizar_ventas
ON Ventas FOR INSERT AS
BEGIN 
	DECLARE @producto AS INT
	DECLARE @cantidad AS INT

SET @producto = (SELECT id_producto FROM inserted)
SET @cantidad = (SELECT cantidad FROM inserted)

UPDATE productos
SET disponible = disponible - @cantidad
WHERE id_producto LIKE @producto

END 


CREATE TRIGGER realizar_compras
ON Compras FOR INSERT AS
BEGIN 
    DECLARE @producto AS INT
    DECLARE @cantidad AS INT

    SET @producto = (SELECT id_producto FROM inserted)
    SET @cantidad = (SELECT cantidad FROM inserted)

    UPDATE productos
    SET disponible = disponible + @cantidad
    WHERE id_producto = @producto
END