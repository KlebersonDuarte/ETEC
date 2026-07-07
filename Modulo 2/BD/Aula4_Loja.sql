create database if not exists Aula4_Loja;
use Aula4_Loja;

create table if not exists produto(
id_prod int auto_increment,
nome_prod varchar(100) not null,
estoque_prod int unsigned default 0,
categoria_prod varchar(50) not null,
preco_unit_prod decimal (6,2),
data_at_prod datetime not null,
primary key(id_prod)
);


insert into produto(nome_prod,estoque_prod,categoria_prod,preco_unit_prod,data_at_prod)values
("Chocolate milka morango",380,"Alimento",15.90,'2025-10-24'),
("Óleo Girassol Liza",438,"Alimento",13.59,'2026-02-22'),
('Ovo da páscoa lactadiante negro 163g',200,"Alimento",46.99,'2026-03-19'),
('Detergente Liquido Ipê',147,'Limpeza',2.25,'2026-02-26'),
('Água Sanitária Suprema 2L',284,'Limpeza',5.48,'2026-02-04'),
("Amaciante Ipê 500ml",178,'Limpeza',3.20,'2026-01-28'),
("Ali. para Cães pedigree carne/frango 2.7kg",204,'Pet Shop',47.89,'2026-03-04'),
("Ali. para Gatos Whiska Carne 2.7kg",307,'Pet Shop',47.89,now()),
("Areia higiênica para gatos pipicat 4kg",94,'Pet Shop',11.40,'2026-01-09');

/*Consulta de dados*/
select "Olá mundo";
/*select geral*/
select * from produto;
/*colunas específicas*/
select nome_prod,preco_unit_prod from produto;
/*apelidando colunas*/
select nome_prod as 'Nome',preco_unit_prod as 'Preço unitário' from produto;
/*Realizando cálculo na consulta
obs: a função round arredonda valores reais*/
select nome_prod,preco_unit_prod,round( preco_unit_prod*0.7,2) from produto;
/*mudando a ordem da consulta
asc: crescente
desc: decrescente
ordem descente do estoque*/
select * from produto order by estoque_prod desc;
/*Ordem alfabética do produto*/
select id_prod,nome_prod as 'Nome',estoque_prod from produto order by Nome;
##Ordem decrescente da data de atualização
select * from produto order by data_at_prod desc;
/*Limite de linhas de resposta*/
select * from produto order by estoque_prod desc limit 3;
/*limit ignorando um certo numero de linhas*/
select * from produto order by estoque_prod desc limit 1,3;

/*
Operadores Relacionais
= igualdade
!= <> desingualdade
< menor
> maior
<= menor ou igual
>= maior ou igual
*/
select * from produto where id_prod =2;
select * from produto where categoria_prod = "pet shop";select * from produto where id_prod =2;
select * from produto where estoque_prod > 150 order by estoque_prod;
select * from produto where data_at_prod < '2026-01-01';
select * from produto where categoria_prod!="Alimento";
select * from produto where preco_unit_prod<10;

/*Operadores Lógicos
E - Conjunção && and
Ou - Disjunção || or
Não - Negação ! not
*/

/*Utilizando o OU*/
select * from produto where categoria_prod ='Limpeza' || categoria_prod = "Alimento";
##Preço abaixo de R$15 OU estoque menor que 150
select * from produto where preco_unit_prod <15 || estoque_prod <150;

/*Operador E
alimento e preço menor que 20*/
select * from produto where categoria_prod ='alimento' && preco_unit_prod <=20;
/*Produtos com extoque entre 150 e 200*/
select * from produto where estoque_prod >= 150 && estoque_prod <=200;
select * from produto where estoque_prod between 150 and 200;
/*Produtos com estoque fora do intervalo entre 150 150 e 200*/
select * from produto where estoque_prod < 150 || estoque_prod >200;
select * from produto where estoque_prod not between 150 and 200;

select * from produto where (categoria_prod ='alimento'|| categoria_prod = "pet shop") && estoque_prod > 300;
