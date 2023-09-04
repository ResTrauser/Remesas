exec usp_CargarEmisor 'gabriel bejamin rivas reyes'

select * from ClienteEmisor as c where c.NombresEmisor+' '+c.Apellido1Emisor+' '+c.Apellido2Emisor like '%'+'gabriel benjamin rivas reyes'+'%'