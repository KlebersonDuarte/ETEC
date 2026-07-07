create database if not exists Escola;
use Escola;

create table if not exists Aluno(
id_matricula int unsigned,
nome_aluno varchar(60) not null,
cpf_aluno char (14) not null unique,
cidade_aluno varchar (60) not null,
curso_aluno varchar(60) not null,
periodo_aluno varchar (15) not null,
dta_nascimento_aluno date not null,
primary key(id_matricula)
);


insert into Aluno values
(1234, "Joao", "999.999.999-99", "SBC", "info", "M" ,"2010-03-31"),
(2345, "Monica", "888.888.888-88", "SCS", "Log", "N", "2005-02-28"),
(3456, "Carlos","777.777.777-77", "SBC", "adm", "T","2011-01-15"),
(4567, "Jessica", "666.666.666-66", "Maua", "adm", "N"," 2012-01-06"),
(5678,"Beatriz", "555.555.555-55", "Diad", "DS", "T", "2007-05-05"),
(6789, "Matheus", "444.444.444-44", "sa", "ds", "N", "2009-11-13"),
(7890, "Carla", "333.333.333-33", "Maua", "Meca","M","2004-03-23");

desc Aluno;
select * from Aluno;
select id_matricula , nome_aluno , cidade_aluno from Aluno;
select * from Aluno where cidade_aluno = "SCS";
select * from Aluno where cidade_aluno = "SBC" && curso_aluno = "adm";
select count(*) as 'Total' from Aluno where periodo_aluno = "N";
select nome_aluno, cpf_aluno,periodo_aluno from Aluno order by curso_aluno;
select * from Aluno where periodo_aluno = "M" && curso_aluno = "Meca";
select nome_aluno from Aluno where year(dta_nascimento_aluno) > "2007";
select * from Aluno order by dta_nascimento_aluno;
select * from Aluno where year( dta_nascimento_aluno )between "2005" and "2012";

create table if not exists Mensalidade(
id_mensalidade int unsigned auto_increment,
id_matricula int unsigned,
vl_mensalidade numeric (6,2) not null,
vl_pago_mensalidade numeric (6,2) not null,
dta_pagto_mensalidade date not null,
dta_pagar_mensalidade date not null,
primary key(id_mensalidade),
foreign key(id_matricula) references Aluno(id_matricula)
);

insert into Mensalidade(id_matricula,vl_mensalidade,vl_pago_mensalidade,dta_pagto_mensalidade,dta_pagar_mensalidade) values
(1234, 1290.75, 1300.50, '2026-03-10', '2026-03-05'),
(2345, 990.00, 990.00, '2026-03-05', '2026-03-05'),
(3456, 1300.50, 1429.50, '2026-03-15', '2026-03-10'),
(1234, 1290.75, 1290.75, '2026-04-05', '2026-04-05'),
(3456, 1300.50, 1500.00, '2026-04-30', '2026-04-10');

drop table Mensalidade;