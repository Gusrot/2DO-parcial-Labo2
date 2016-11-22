/*Select simple*/
select id,nombre,apellido,sexo
from Persona 
where id>100;

/*Insert*/
insert into Persona
(nombre,apellido,sexo)
values
('Pepe','Perez','Femenino'),
('Jimena','Lopez','Femenino'),
('Juan','a','Femenino'),
('Pablo','b','Femenino'),
('Pedro','c','Femenino');

/*Update*/
update Persona set sexo='mujer' where sexo='Femenino';

/*Delete*/
delete from Persona where nombre='Pepe';