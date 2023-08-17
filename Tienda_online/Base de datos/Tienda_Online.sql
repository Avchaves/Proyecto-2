use Tienda_online

create TABLE productos
(
id_producto INT IDENTITY PRIMARY KEY,
nombre VARCHAR(100),
precio DECIMAL(10,2),
categoria int not null,
cantidad int not null,
proveedor int not null
)

create table categoria
(id_categoria int primary key,
nombre varchar(50),
descripcion varchar(100)
)

INSERT INTO categoria
VALUES (1,'materiales','casa')
select * from categoria

create TABLE clientes (
id_cliente INT IDENTITY PRIMARY KEY,     
nombre VARCHAR(50),     
apellido varchar(100),
direccion VARCHAR(100),     
telefono VARCHAR(50)
)

CREATE TABLE USUARIOS
(
ID  INT IDENTITY,
USUARIO VARCHAR (50),
CLAVE VARCHAR (50),
CONSTRAINT PK_IDUSUARIO PRIMARY KEY (ID),
CONSTRAINT UQ_USUARIO UNIQUE (USUARIO)
)
create table Proveedores
( 
id_proveedor int primary key,
nombre varchar (100),
tipo varchar (50),
ciudad varchar (50)
)

CREATE TABLE ordenes (     
id_orden INT PRIMARY KEY,
id_clientes INT,
fecha DATE,
total DECIMAL(10,2),     
FOREIGN KEY (id_clientes) REFERENCES clientes(id_cliente) );


CREATE TABLE detalles_ordenes (
id_detalle INT IDENTITY PRIMARY KEY,
id_orden INT,
id_producto INT,     
cantidad INT,     
FOREIGN KEY (id_orden) REFERENCES ordenes(id_orden),
 FOREIGN KEY (id_producto) REFERENCES productos(id_producto) );


 CREATE TABLE USUARIOS
(
	ID  INT IDENTITY,
	USUARIO VARCHAR (50),
	CLAVE VARCHAR (50),
	CONSTRAINT PK_IDUSUARIO PRIMARY KEY (ID),
	CONSTRAINT UQ_USUARIO UNIQUE (USUARIO)
)

CREATE PROCEDURE ValidarUsuario
@usuario Varchar (50),
@clave VARCHAR (50)
as
	begin
		select USUARIO, CLAVE FROM USUARIOS WHERE USUARIO=@usuario AND CLAVE=@clave
	END

	INSERT  INTO USUARIOS(USUARIO,CLAVE) VALUES ('alo','523')
	INSERT  INTO USUARIOS(USUARIO,CLAVE) VALUES ('adrian',123)
	SELECT * From USUARIOS
INSERT  INTO USUARIOS(USUARIO,CLAVE) VALUES ('oli','523')
EXEC ValidarUsuario 'alo','523'
