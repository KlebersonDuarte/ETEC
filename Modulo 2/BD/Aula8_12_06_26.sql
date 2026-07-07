create database if not exists sistema;
use sistema;

create table if not exists Pessoa(
id_pes int unsigned auto_increment,
nome_pes varchar(255) not null,
data_nasc_pes date not null,
primary key(id_pes)
)engine = InnoDB;

create table if not exists Resevista(
id_res int unsigned auto_increment,
num_res char(10) not null unique,
data_emiss_res date not null,
id_pes int unsigned not null unique,
primary key(id_res),
foreign key(id_pes) references Pessoa(id_pes) on delete cascade
)engine = InnoDB;

show tables;

create table if not exists Veiculo(
id_vec int unsigned auto_increment,
modelo_vec varchar(50) not null,
marca_vec varchar(50) not null,
id_pes int unsigned not null,
primary key(id_vec),
foreign key(id_pes) references Pessoa(id_pes) on delete cascade
)engine = InnoDB;

create table if not exists Estacionamento(
id_est int unsigned auto_increment,
nome_est varchar(50) not null unique,
vaga_est int unsigned,
primary key(id_est)
)engine = InnoDB;

create table if not exists veic_has_est(
id_has int unsigned auto_increment,
id_vec int unsigned not null,
id_est int unsigned,
data_entrada datetime not null,
data_saida datetime,
vaga int,
primary key(id_has,id_vec,id_est),
foreign key(id_vec) references Veiculo(id_vec) on delete cascade,
foreign key(id_est) references Estacionamento(id_est) on delete cascade
)engine = InnoDB;

desc pessoa;

insert into Pessoa(nome_pes, data_nasc_pes) values
('Vanessa Alves' , '2001-05-10'),
('Ricardo Feltrim', '1995-08-18'),
('José da Silva', '2004-04-20'),
('Camila Garcia', '1999-07-11');

select * from Pessoa;

insert into Resevista(num_res,data_emiss_res,id_pes) values
('382782744', '2011-08-19',2);

insert into Veiculo(modelo_vec,marca_vec,id_pes) values
('X1', 'BMW', 1),
('t-cross','volkswagen',2),
('sanderi','renault',2),
('fox','volkswagen',4);

insert into Estacionamento(nome_est,vaga_est) values
('Central Park','550'),
('Pátio Ipiranga','620');

insert into veic_has_est(id_vec,id_est,data_entrada) values
(4,2,'2026-06-10 13:45'),
(1,1,now()),
(2,2,now());

select p.nome_pes , v.modelo_vec, e.nome_est,ve.data_entrada from pessoa as p 
inner join veiculo as v on p.id_pes = v.id_pes 
inner join veic_has_est as ve on v.id_vec = ve.id_vec 
inner join estacionamento as e on e.id_est = ve.id_est;