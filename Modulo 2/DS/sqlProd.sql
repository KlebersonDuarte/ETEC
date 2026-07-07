create database if not exists Etec;
use Etec;

create table if not exists Produtos(
Codigo int unsigned primary key,
Descricao varchar (60) not null,
Valor decimal (5,2) not null,
Vencimento datetime not null);

select * from Produtos;