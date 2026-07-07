create database if not exists Escola;
use Escola;

create table if not exists Alunos(
Matricula int unsigned primary key,
Nome varchar (60) not null,
Email varchar (60) unique not null,
Nascimento date not null,
cpf char(11) unique not null ,
Foto blob not null
);

select * from Alunos;

create table if not exists Mensalidade(
id_mensalidade int unsigned auto_increment,
Matricula int not null,
data_pagamento date not null,
valor_pagar decimal(4,2) not null,
valor_bruto decimal(4,2) not null,
primary key(id_mensalidade),
foreign key(Matricula) references Alunos(Matricula)
);

select * from Mensalidade;