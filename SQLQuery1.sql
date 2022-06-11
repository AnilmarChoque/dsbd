create database dsbd
use dsbd
create table Armas(
	CR varchar (8) constraint pk Primary Key,
	Calibre varchar (4) not null,
	Preco numeric (8,2) not null,
	Data_fabricacao date,
	Nome_fornecedor varchar (30),
	Lote varchar (6) 
)
insert into Armas values ('M48RT5AW','.762',9200.50,)
drop table Armas