create database Remesas;
use Remesas;

select c.CodigoEmisor,c.NombresEmisor,c.Apellido1Emisor,c.Apellido2Emisor,c.DireccionEmisor, c.TelefonoEmisor,c.Cedula,p.NombrePais
from ClienteEmisor as c inner join Pais as p on c.PaisId = p.Id;

select c.CodigoReceptor,c.NombresReceptor,c.Apellido1Receptor,c.Apellido2Receptor,c.DireccionReceptor,c.TelefonoReceptor,c.Cedula,p.NombrePais
from ClienteReceptor as c inner join Pais as p on c.PaisId = p.Id;

select t.CodigoTipoCambio,t.CambioDia,t.FechaTipoCambio,m.TipoMoneda from TipoDeCambio as t inner join Moneda as m on t.MonedaId = m.Id;
dbcc checkident([dbo.Moneda], noreseed)
dbcc checkident([dbo.Moneda], reseed,5)

USE Remesas;

CREATE PROCEDURE usp_BuscarCliente(@Nom varchar(50),@Apellido varchar(25))
AS
select ce.CodigoEmisor,ce.NombresEmisor,ce.Apellido1Emisor,ce.Apellido2Emisor,ce.DireccionEmisor,ce.TelefonoEmisor,ce.Cedula,
p.NombrePais
from ClienteEmisor as ce inner join Pais as p on ce.PaisId = p.Id
where ce.NombresEmisor like '%'+@Nom+'%' and ce.Apellido1Emisor like '%'+@Apellido+'%'

CREATE PROCEDURE usp_BuscarClienteReceptor(@Nom varchar(50),@Apellido varchar(25))
AS
select ce.CodigoReceptor,ce.NombresReceptor,ce.Apellido1Receptor,ce.Apellido2Receptor,ce.DireccionReceptor,ce.TelefonoReceptor,ce.Cedula,
p.NombrePais
from ClienteReceptor as ce inner join Pais as p on ce.PaisId = p.Id
where ce.NombresReceptor like '%'+@Nom+'%' and ce.Apellido1Receptor like '%'+@Apellido+'%'

exec usp_BuscarCliente 'ga','riv'
exec usp_BuscarClienteReceptor 'ale','riv'

CREATE PROCEDURE usp_BuscarTransaccion(@CodEnvio varchar(7))
as
select e.CodigoEnvio,e.FechaPago,e.MontoPagado,er.Estado,tc.CambioDia,m.TipoMoneda,ce.CodigoEmisor,ce.NombresEmisor,ce.Apellido1Emisor,
cr.CodigoReceptor,cr.NombresReceptor,cr.Apellido1Receptor,p.NombrePais as PaisDestino from Envio as e inner join ClienteEmisor as ce on e.ClienteEmisorId = ce.Id 
inner join ClienteReceptor as cr on e.ClienteReceptorId = cr.Id inner join Pais as p on cr.PaisId = p.Id
inner join EstadoRemesa as er on e.EstadoRemesaId = er.Id inner join TipoDeCambio as tc
on e.TipoDeCambioId = tc.Id inner join Moneda as m on tc.MonedaId = m.Id where CodigoEnvio like @CodEnvio

exec usp_BuscarTransaccion 170

CREATE PROCEDURE usp_BuscarMoneda(@NomMoneda varchar(25))
as
select m.Id,m.TipoMoneda,t.CambioDia,t.FechaTipoCambio from Moneda as m inner join TipoDeCambio as t on t.MonedaId=m.Id
where m.TipoMoneda like '%'+@NomMoneda+'%' order by FechaTipoCambio DESC

exec usp_BuscarMoneda 'Francos Suizos'

CREATE PROCEDURE usp_CargarEmisor(@NomEmi varchar(max))
as
select c.Id,c.NombresEmisor as Nombre,c.Apellido1Emisor as Apellido, c.Cedula
from ClienteEmisor as c where c.NombresEmisor+' '+c.Apellido1Emisor+' '+c.Apellido2Emisor 
like '%'+@NomEmi+'%'

CREATE PROCEDURE usp_CargarReceptor(@NomRec varchar(max))
as
select c.Id,c.NombresReceptor as Nombre,c.Apellido1Receptor as Apellido, c.Cedula
from ClienteReceptor as c where c.NombresReceptor+' '+c.Apellido1Receptor+' '+c.Apellido2Receptor 
like '%'+@NomRec+'%'

exec usp_CargarEmisor 'gabri'
exec usp_CargarReceptor 'ale'

select c.Id,c.NombresEmisor,c.Apellido1Emisor,c.Apellido2Emisor,c.Cedula 
from ClienteEmisor as c where c.NombresEmisor+' '+c.Apellido1Emisor+' '+c.Apellido2Emisor like 'gabriel'

select * from TipoDeCambio;
insert into EstadoRemesa(CodigoEstadoRemesa,Estado) values('Est2','Inactivo')
select * from ClienteEmisor;

select t.CambioDia,t.FechaTipoCambio, m.TipoMoneda from TipoDeCambio as t inner join Moneda as m on t.MonedaId=m.Id where 
t.FechaTipoCambio = '10/07/2023'

insert into TipoDeCambio(CodigoTipoCambio,CambioDia,FechaTipoCambio,MonedaId) 
values('Camb67',37,'10/07/2023',1)
select * from Envio;

select * from ClienteReceptor;
insert into Envio(CodigoEnvio,MontoPagado,FechaPago,CodigoRetiro,EstadoRemesaId,ClienteEmisorId,ClienteReceptorId,TipoDeCambioId)
values('Env2',500,'05/07/2023','012346',1,9,1,4);

select ce.CodigoEmisor,ce.NombresEmisor,ce.Apellido1Emisor,ce.Apellido2Emisor,ce.DireccionEmisor,ce.TelefonoEmisor,ce.Cedula,
p.NombrePais, e.CodigoEnvio,e.FechaPago, e.MontoPagado,COUNT(CodigoEnvio)
from ClienteEmisor as ce inner join Envio as e on ce.Id = e.ClienteEmisorId inner join Pais as p on ce.PaisId = p.Id
where ce.NombresEmisor like '%'+'gabriel'+'%' and ce.Apellido1Emisor like '%'+'rivas'+'%' group by CodigoEnvio,CodigoEmisor,NombresEmisor,Apellido1Emisor,Apellido2Emisor,DireccionEmisor,TelefonoEmisor,Cedula,NombrePais,CodigoEnvio,
FechaPago,MontoPagado

 drop database Remesas;