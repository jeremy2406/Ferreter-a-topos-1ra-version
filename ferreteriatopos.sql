Create database Ferreteria_Topos
use Ferreteria_Topos

Create table Clientes(
ID_Cliente int primary key,
Nombre_cliente Varchar (20),
Apellido_cliente Varchar (20),
Edad_cliente int,
Telefono_cliente Varchar (10),
Correo_cliente Varchar (50),
Direccion_cliente Varchar (50),
Cedula_cliente int
);
select * from Clientes;
delete clientes;

Create table Productos(
ID_Producto int primary key,
Nombre_producto Varchar (50),
Categoria_producto Varchar (50), 
Imagen_producto varbinary(max),
Proveedor_producto Varchar (50), 
);

Create table Detalle_Producto(
Codigo_Producto int, foreign key(Codigo_Producto) references Productos(ID_Producto),
Nombre_producto Varchar (50),
Stock_Producto int,
Precio float,
Especificaciones Varchar (100),
Calidad_Producto Varchar (50),
Codigo_Facturacion int, foreign key(Codigo_Facturacion) references Facturacion(ID_Facturacion)
);

Create table Categoria(
ID_Categoria int primary key,
Nombre_cat Varchar (50),
Descripcion_cat Varchar (50),
Estado_cat Varchar (50),
);

Create table Proveedor(
ID_Proveedor int primary key,
Nombre_proveedor Varchar (50),
Telefono_proveedor Varchar (50),
Estado_proveedor Varchar (50)
);

Create table Empleado (
ID_Empleado int primary key,
Nombre_empleado Varchar (50),
Apellido_empleado Varchar (50),
Direccion_empleado Varchar (50),
Telefono_empleado Varchar (50),
Correo_empleado varchar (50),
Cedula_empleado int 
);

Create table Facturacion (
ID_Facturacion int primary key,
Nombre_cliente varchar (50),
Fecha Varchar (50),
Producto varchar (50),
Precio Float,
Cantidad float,
Metedo_Pago Varchar (50),
Descuento Float,
Itbis Float,
Sub_total float,
Total float,
);


Create table Tarjeta(
Codigo_Facturacion int, foreign key(Codigo_Facturacion) references Facturacion (ID_Facturacion),
Numero_tarjeta int,
Tipo_tarjeta Varchar (50),
Fecha_Vencimiento Varchar (50)
);

Create table Factura(
Codigo_Facturacion int, foreign key(Codigo_Facturacion) references Facturacion (ID_Facturacion),
RNC int,
Fecha time,
Producto varchar (50),
Precio Int,
Cantidad int,
Itebis Float,
Sub_total Float,
Total Float
);

Create table Usuarios(
ID_Usuario int Primary Key not null,
Nombre_Usuario varchar(30) not null,
Contraseña varchar(10) not null,
Nombre_Empleado varchar(20) not null,
Apellido_Empleado varchar(20) not null,
Posición  varchar(20) not null,
Gmail_Empleado varchar(40) not null

);
declare @Usuario varchar(30)= 'Admin'
declare @Contraseña varchar(10)= 'Admin'
Select * from Usuarios where Nombre_Usuario = @Usuario and Contraseña =@Contraseña;

insert into Usuarios values(1, 'Admin','Admin','Jeremy','Diaz','Jefe','diazjeremy344@gmail.com');
insert into Usuarios values(2,'Pro','1234','Enmanuel','Abreu','Empleado','abreuenmanuel123@gmail.com');
select * from Usuarios;

create proc Estadisticadatos
@totVentas float output,
@totalprod int output,
@total int output,
@totalcateg int output,
@numclient int output,
@numprove int output,
@numemple int output
as
Set @totVentas =(select sum(Codigo_Facturacion)as TotalVentas from Factura	 )
Set @numclient=(select count (ID_Cliente)  as Clientes from Clientes)
Set @numprove =(select count (ID_Proveedor) as Proveedores from Proveedor)
Set @numemple  =(select count (ID_Empleado)as Empleados from Empleado )
Set @totalprod=(select count (ID_Producto) as Productos  from PRODUCTOS)
set @total  = (select count (Total ) AS marcas from Factura)
set @totalcateg = (select count (ID_Categoria) AS categorias from Categoria)
go

create proc MostrarClientes
as
select *from Clientes
go

create proc InsertarClientes
@ID int,
@nombre varchar (100),
@Apellido varchar (100),
@Edad int,
@Telefono varchar(16),
@Correo varchar(100),
@Direccion varchar(100),
@Cedula int
as
insert into Clientes values (@ID,@nombre,@Apellido,@Edad,@Telefono,@Correo,@Direccion,@Cedula)
go

create proc Siguientenumero
@ID int
as
select count(ID_Cliente) from Clientes where @ID = ID_Cliente
go

create proc EditarClientes
@ID int,
@nombre varchar (100),
@Apellido varchar (100),
@Edad int,
@Telefono varchar(16),
@Correo varchar(100),
@Direccion varchar(100),
@Cedula int
as
update Clientes set Nombre_cliente=@nombre, Apellido_cliente=@Apellido, Edad_cliente=@Edad, Telefono_cliente=@Telefono, Correo_cliente=@Correo, Direccion_cliente=@Direccion, Cedula_cliente= @Cedula where ID_Cliente=@ID
go

create proc EliminarClientes
@ID int
as
delete from Clientes where ID_Cliente=@ID
go

