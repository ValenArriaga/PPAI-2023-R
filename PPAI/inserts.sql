

insert into Estado(nombre)
values( 'Iniciada')
insert into Estado( nombre)
values( 'EnCurso')
insert into Estado(nombre)
values('Finalizada')

insert into CategoriaLlamada(nroOrden, nombre)
values(1,'Robo')

insert into OpcionLlamada(nroOrden, nombre, idCategoria)
values(1,'Solicitar nueva tarjeta', 1)

insert into SubOpcionLlamada(nroOrden, nombre, idOpcion)
values(1,'Comunicarse con Operador',1)

insert into Validacion(nroOrden, nombre, idOpcion, idSubopcion)
values(1,'Cantidad de hijos',1,1)
insert into Validacion(nroOrden, nombre, idOpcion, idSubopcion)
values(2,'Nombre de mascota',1,1)
insert into Validacion( nroOrden, nombre, idOpcion, idSubopcion)
values(3,'Edad',1,1)

insert into OpcionValidacion(idOpcionValidacion, correcta,descripcion,idValidacion)
values(1,'2','2',1)
insert into OpcionValidacion(idOpcionValidacion, correcta,descripcion,idValidacion)
values(2,'Ramses','Ramses',2)
insert into OpcionValidacion(idOpcionValidacion, correcta,descripcion,idValidacion)
values(3,'32','32',3)

insert into Cliente(dni,nombre,apellido,nroCelular)
values(123,'Pedro Jose','Crespo',123)

insert into InformacionCliente(idInfoCliente, datoAValidar, idOpcionCorrecta, idValidacion, tipo, idCliente)
values(1,'Cantidad de hijos', 1, 1, 'cantidad', 1)
insert into InformacionCliente(idInfoCliente, datoAValidar, idOpcionCorrecta, idValidacion, tipo, idCliente)
values(2,'Nombre de mascota', 2, 2, 'nombre', 1)
insert into InformacionCliente(idInfoCliente, datoAValidar, idOpcionCorrecta, idValidacion, tipo, idCliente)
values(3,'Edad', 3, 3, 'cantidad', 1)

insert into accion( descripcion)
values( 'Denunciar un robo')

insert into Usuario(nombreUsuario)
values('pjcrespo')

insert into Llamada( idCliente, idSubOpcionLlamada, idOpcionLlamada, idUsuario)
values(1,1,1,1)

insert into CambioEstado( fechaHoraInicio,idEstado,idLlamada)
values('23/5/2023',1,1)

