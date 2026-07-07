create database if not exists Aula7_29_05_2026;
use Aula7_29_05_2026;

create table if not exists Pessoa(
id_pes int  unsigned auto_increment ,
	cpf_pes char (11) not null unique,
    nome_pes varchar(100) not null,
    data_nasc_pes date,
    primary key(id_pes)
)engine=InnoDB;

insert into Pessoa(cpf_pes,nome_pes,data_nasc_pes) values
('15985315478','Josney da Silva','1993-04-09'),
('52648971230','Camila Alves', 1999-10-21),
('32156489710','Edson Arantes','2003-08-17');

select * from Pessoa;

/*
Restriçoes de chave estrangeira:
Restrict (Padrão): Rejeita atualização ou exclução de um registro da tabela "pai" se houver registro na tabela filho
Cascade: Atualiza ou exclui os registros da tabela "filha" automática
Set Null: Defgine como null o valor do campo na tabela "filha" em caso de exclução
No Action: Equivale ao Restrict
Set Default: Define um valor padrão na coluna da tabela "filha"
*/

 create table if not exists Reservista(
 id_res int unsigned auto_increment,
 num_res char(10) not null unique,
 status_res enum ("Ativo","Reserva"),
 data_exp_res date not null,
 id_pes int unsigned not null unique,
 primary key(id_res),
 foreign key(id_pes) references Pessoa(id_pes)
 on delete cascade
 )engine=InnoDB;
 
 insert into Reservista(num_res,data_exp_res,status_res,id_pes) values
 ('1202548910','2005-07-15','Reserva',1);
 
insert into Pessoa(cpf_pes,nome_pes,data_nasc_pes) values
('88745698412','Carlos da Silva','1979-10-15');

 insert into Reservista(num_res,data_exp_res,status_res,id_pes) values
 ('9102548910','2000-01-15','Reserva',last_insert_id());
 
 select * from Reservista;
 
 create table if not exists Veiculo(
 id_vec int unsigned auto_increment,
 marca_vec varchar(25) not null,
 modelo_vec varchar(25) not null,
 placa_vec char(7) unique not null,
 id_pes int unsigned,
 primary key(id_vec),
 foreign key(id_pes) references Pessoa(id_pes) on delete cascade
 )engine=InnoDB;
 
 insert into Veiculo(marca_vec,modelo_vec,placa_vec,id_pes) values
 ('Hyundai','HB20S','fje8s38',1),
 ('Chevrolet','Opala','uds4d29',1);
 
  insert into Veiculo(marca_vec,modelo_vec,placa_vec) values
 ('Ford','Ecosport','bcu4k27');
 
 select * from Veiculo;
 
 #Vinculando o carro após o insert
 update Veiculo set id_pes = 2 where id_vec = 3;
 
 delete from Pessoa where id_pes=1;