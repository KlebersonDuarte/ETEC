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
select * from produto where categoria_prod in('alimento','pet shop');
select * from produto where categoria_prod = 'alimento' || categoria_prod ='pet shop';

/*Consulta por trecho em texto*/
select * from produto where nome_prod like '%am%ci%';
select * from produto where preco_unit_prod*0.7 <30;

/*Função:É uma operação que pode ser aplicada a um conjunto de respostas
sum: Soma o valor de uma coluna durante uma consulta.
*/
select sum(estoque_prod) as soma from produto;

## Soma do estoque menor  que 100 
select sum(estoque_prod) as soma from produto where estoque_prod < 100;

## somar estoques do produto da categoria alimento

select sum(estoque_prod) as soma from produto where categoria_prod like "alim%";

/* Soma do valor do estoque*/

select *,estoque_prod*preco_unit_prod from produto;
select sum(estoque_prod*preco_unit_prod) from produto;

/*Somar os produtos agrupados por categoria*/
select categoria_prod,sum(estoque_prod) from produto group by categoria_prod;

##AVG: calcula a média do valor de uma coluna

##Preço médio unitário
select avg(preco_unit_prod) from produto;

##preço médio dos produtos alimentícios
select avg(preco_unit_prod) from produto where categoria_prod like 'alim%';

##Média de preços agrupado por categorias
select categoria_prod,avg(preco_unit_prod) from produto group by categoria_prod;

##produtos que estão com preço acima da média geral
select * from produto where 
preco_unit_prod>(select avg(preco_unit_prod) from produto);

/*Agrupar os produtos pela média de preço, mas somente
aqueles que tem média maior que 30 reais*/
select categoria_prod,avg(preco_unit_prod) from
produto group by categoria_prod having avg(preco_unit_prod)>30;

/*Count: retorna a quantidade de linhas da consulta
contar quantos produtos foram cadastrados
*/

select count(*) from produto;

##Contar quantas categorias possuem
select count(distinct categoria_prod) from produto;

##Agrupar a quantidade de produtos por categoria
select categoria_prod, count(categoria_prod) from produto group by categoria_prod;

##Max: busca o maior valor
select nome_prod,max(preco_unit_prod) from produto where preco_unit_prod = (select max(preco_unit_prod) from produto);

##Produto mais c aro por categoria
select categoria_prod,max(preco_unit_prod) from produto group by categoria_prod;

##Mostrar o produto mais caro agrupado por categoria
select nome_prod,categoria_prod,preco_unit_prod from produto where preco_unit_prod in(select max(preco_unit_prod)from produto group by categoria_prod);
