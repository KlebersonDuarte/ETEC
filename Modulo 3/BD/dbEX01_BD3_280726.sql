create database if not exists dbEX01_BD3_280726;
use dbEX01_BD3_280726;

create table if not exists tb_estados(
uf char (2) not null primary key,
uf_desc varchar (35) not null,
constraint uquf_desc unique (uf_desc) 
);

insert into tb_estados (uf,uf_desc) values
('SP','São Paulo'),
('MG','Minas Gerais'),
('RJ','Rio de Janeiro');

create table if not exists tb_cliente(
id_cliente int auto_increment not null primary key,
nome_cliente varchar (60) not null,
end_cliente varchar (120) not null,
uf char (2) not null,
cpf_cliente char(14) not null,
constraint uqcpf_cliente unique (cpf_cliente),
foreign key (uf) references tb_estados(uf)
);

/*Em um sistema muito provavelmente os dados serão inseridos em varios inserts*/
/*Simulação:*/

insert into tb_cliente (nome_cliente,end_cliente,uf,cpf_cliente) values
('Ana Paula','Rua A','SP','111.222.333-44');

insert into tb_cliente (nome_cliente,end_cliente,uf,cpf_cliente) values
('Paulo','Rua P','MG','222.333.444-55');

insert into tb_cliente (nome_cliente,end_cliente,uf,cpf_cliente) values
('Luis Carlos','Rua LC','RJ','333.444.555-66');

insert into tb_cliente (nome_cliente,end_cliente,uf,cpf_cliente) values
('Rosa','Rua R','SP','444.555.666-77');

insert into tb_cliente (nome_cliente,end_cliente,uf,cpf_cliente) values
('Hugo','Rua H','RJ','555.666.777-88');

alter table tb_cliente drop index uqcpf_cliente;

insert into tb_cliente (nome_cliente,end_cliente,uf,cpf_cliente) values
('Tabata','Rua T','RJ','555.666.777-88');