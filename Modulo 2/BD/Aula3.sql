create database if not exists cinema;
use cinema;
create table if not exists filme(
id_filme int auto_increment,
nome_filme varchar (100) not null,
data_lanc_filme date not null,
dur_filme time not null,
genero_filme varchar(50),
primary key(id_filme)
);

insert into filme (nome_filme,data_lanc_filme,dur_filme,genero_filme) values
('A Lista de Schindler', '1993-12-15', '03:15','Biografia/Drama/História'),
('O Senhor dos Aneis: A Sociedade do Anel', '2001-12-23', '02:58','Fantasia/Ação'),
('Matrix','1999-03-31','02:16','Ação/Ficção'),
('Interestelar','2014-11-07','02:49','Ficção/Aventura'),
('À espera do milagre','1999-12-10','03:09','Crime/Drama');

select * from filme;

/*Alterar dados já cadastrados*/
update filme set dur_filme ='02:30' where id_filme = 3;

/*Alterar mais de uma coluna*/
update filme set nome_filme = 'Teste',
data_lanc_filme = curdate() where id_filme = 5;

update filme set genero_filme = 'Ficção' where id_filme = 4;

/*Adicionando uma coluna para bilheteria*/
alter table filme add bilheteria_filme int;

update filme set bilheteria_filme = 100 where id_filme =3;

/*Calculo no update*/
update filme set bilheteria_filme = bilheteria_filme + 50 where id_filme = 3;

/*Colocar 100 de bilheteria em todos os filmes*/
update filme set bilheteria_filme = 100 where bilheteria_filme is null;

/*Aumentar pra 300 a bilheteria de interestelar*/
update filme set bilheteria_filme = bilheteria_filme + 300 where id_filme = 4;

/*Deletar linha de tabela*/
delete from filme where  id_filme = 5;
delete from filme where  id_filme = 2;

/*Deleter todos os dados da tabela*/
truncate filme;