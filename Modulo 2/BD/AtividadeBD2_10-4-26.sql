CREATE DATABASE IF NOT EXISTS MOBILIARIA;
USE MOBILIARIA;

CREATE TABLE IF NOT EXISTS IMOVEL(
id_imovel int unsigned auto_increment,
valor_imovel decimal(10,2) not null,
quant_quartos_imovel int not null,
endereco_imovel varchar(35) not null,
bairro_imovel varchar(35) not null,
cidade_imovel varchar(35) not null,
status_imovel varchar(35) not null,
data_cadastro_imovel date,
primary key(id_imovel)
);

select * from IMOVEL;

INSERT INTO IMOVEL(valor_imovel, quant_quartos_imovel, endereco_imovel, bairro_imovel, cidade_imovel, status_imovel, data_cadastro_imovel) values
("3.000","4", "R. Carmo Oliveira, 34", "Silvina", "Porto ferreira", "Alugada", "2022-12-22"),
("500.000", "5", "R. João Ramalho, 230", "São Pedro", "Piracicaba", "À venda", "2020-08-14"),
("200.000", "2", "R. das Cerejeiras, 110", "Nova Petropólis", "Sorocaba","Vendido", "2018-09-30"),
("1.500", "2", "R. Tiradentes, 700", "Santa Terezinha", "Votorantim", "Aluguel", "2025-07-24"),
("1.300", "1", "R. Senador Vergueiro, 70", " Baeta Neves", "Bauru", "Aluguel", "2021-03-20");

select * from IMOVEL order by cidade_imovel;
select endereco_imovel,bairro_imovel,status_imovel from IMOVEL where cidade_imovel = "Piracicaba";
select * from IMOVEL where endereco_imovel = "R. Carmo Oliveira, 34" && cidade_imovel = "Porto ferreira";
select valor_imovel from IMOVEL order by status_imovel;
select * from IMOVEL order by valor_imovel;
select * from IMOVEL where cidade_imovel = "Votorantim" || "Sorocaba" && valor_imovel <= 2.000;
select * from IMOVEL where year(data_cadastro_imovel) < "2022" && cidade_imovel = "Bauru" order by quant_quartos_imovel;
select * from IMOVEL where quant_quartos_imovel between 2 and 3; 
