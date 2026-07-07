##CRIANDO UMA BASE DE BANCO DE DADOS NO MTSQL

CREATE DATABASE IF NOT exists aula_20_02;

##Entrando em uma base de dados
use aula_20_02;

##Criando a tabela
create table if not exists Pessoa(
	id_pes int unsigned auto_increment not null,                                     ##unsigned(comando q impede numeros negativos)            ## da pra definir a chame primary key por aqui tbm no msm estilo do sql server
    nome_pes varchar(45) not null,
    log_pes varchar(45) not null,
    bairro_pes varchar(45) not null,
    cidade_pes varchar(45) not null,
    cpf_pes char (11) unique not null,
    data_nasc_pes date,
	status_pes enum('bronze','prata','ouro','platina') default'bronze',
    primary key(id_pes)
);

## exibir bases de dados existentes
show databases;

##exibir tabelas existentes em uma base
show tables;

##descriçâo da tabe

desc Pessoa;		

##acrecentar uma coluna em uma tabela q ja foi criado
alter table Pessoa add estado_pes char(2) not null;

##alterando o nome e/ou tipo de uma coluna existente                                       
alter table Pessoa change estado_pes est_pes char (2) not null;
##modify alera só o tipo

alter table Pessoa modify  status_pes enum('bronze','prata','ouro','platina','diamante') default'bronze';

##Constrait check para validação de valores
alter table Pessoa add constraint const_cpf check(length(cpf_pes)=11);

##excluindo coluna de uma tabela existente
alter table Pessoa drop column bairro_pes;

##inserindo dados na tabela
insert into Pessoa (nome_pes,log_pes,cidade_pes,est_pes,cpf_pes,
data_nasc_pes,status_pes) values
("Josney da Silva","R.romério Almeida,43","Osasco",upper("sp"),"45515897201","1995-04-24","prata"),
("Vanessa Loger","Av. Vital Brasil,1545","Carapicuiba","sp","48745632159",curdate(),"bronze");
##curdate ou current_date/data 0atual
##curtime ou current_time/horáiro atual
##now()/data e hora atual

insert into Pessoa (nome_pes,log_pes,cidade_pes,est_pes,cpf_pes) values
("Carlos Almeida","R. Carlos de Campo,245","Capivari",'sp',"49862148764"),
("Giovanna Fernandes","R. Galvão buena,383","São Paulo","SP","48963210518");


##selecionando
select * from Pessoa;
select * from Pessoa where est_pes is null;

##deletando cadastro
delete from pessoa where id_pes = 2;

##deletando a tabela
drop table Pessoa;

##deletando base de dados
drop database aula_20_02;
