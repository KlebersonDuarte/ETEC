create database if not exists Aula6_15_05_26;
use Aula6_15_05_26;

create table if not exists Pessoa(
id_pes int unsigned auto_increment,
nome_pes varchar(100) not null,
data_nasc_pes date not null,
primary key(id_pes)
)engine="InnoDB";

create table if not exists Reservista(
id_res int unsigned auto_increment,
num_res char(10) not null unique,
data_exp_resp date not null,
status_res enum('Reserva',"Ativo","baixa"),
id_pes int  unsigned not null unique ,
primary key(id_res), 
foreign key(id_pes) references Pessoa(id_pes)
) engine="InnoDB";

insert into Pessoa(nome_pes,data_nasc,nasc_pes)values
('Jonsey da Silva','2001-04-05'),('Murilo Gomes', '2008-05-12'),('Kleberson Duarte','2009-09-07');
select* from pessoa;

insert into Reservista(num_res,data_exp_resp,status_res,id_pes)values
('557434324','2006-11-17', 'reserevista',2);

insert into Reservista(num_res,data_exp_resp,status_res,id_pes)values
('557434324','2006-11-17', 'reserevista',2);

insert into Pessoa(nome_pes,data_nasc_pes)values
('Roberto Camargo de Almeida','2005-07-18');

insert into Reservista(num_res,data_exp_res,status_res,id_pes)values
('994837495',curdate(),'reserva',last_insert_id());

