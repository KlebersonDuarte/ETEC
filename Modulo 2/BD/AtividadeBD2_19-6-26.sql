create database  if not exists estudio;
use estudio;

create table if not exists tb_sala(
id_sala int unsigned auto_increment,
preco_sala numeric(5,2) not null,
primary key(id_sala)
)engine = InnoDB;

create table if not exists tb_cliente(
id_cliente int unsigned auto_increment,
nome_cliente varchar (60) not null,
rg_cliente char (13) not null unique,
telefone_cliente char(13) not null unique,
primary key(id_cliente)
)engine = InnoDB;

create table if not exists tb_agendamento(
id_agendamento int unsigned auto_increment,
id_sala int unsigned not null,
id_cliente int unsigned not null,
data_agendamento datetime not null,
duracao_agendamento int not null,
primary key(id_agendamento,id_sala,id_cliente),
foreign key(id_sala) references tb_sala(id_sala) on delete cascade,
foreign key(id_cliente) references tb_cliente(id_cliente) on delete cascade
)engine = InnoDB;

insert into tb_sala(preco_sala) values
(80.00),
(80.00),
(80.00);

insert into tb_cliente(nome_cliente,rg_cliente,telefone_cliente)values
("Carlos Eduardo da Silva", "11.111.111-11","11 98987-5432" ),
("Geonava Pnanhote Oliveira", "22.222.222-22", "11 76453-9821"),
("Alison Duarte Gomes", "33.333.333-33", "11 82346-2134"),
("Bruno Silva Costa", "44.444.444-44", "11 12384-2314"),
("Gabriela Sousa Lima", "55.555.555-55", "11 43456-4235");

insert into tb_agendamento(id_sala,id_cliente,data_agendamento,duracao_agendamento) values
(1,4, "2026-08-24 14:00:00", 3),
(2,3, "2026-05-12 15:00:00",2),
(2,5, now(),1);

select c.nome_cliente,s.id_sala ,a.data_agendamento from tb_agendamento as a inner join tb_sala as s on s.id_sala = a.id_sala inner join tb_cliente as c on c.id_cliente = a.id_cliente;

/*
Feito por:
Kleberson Duarte Santos
Leonardo de Oliveria Duarte
*/