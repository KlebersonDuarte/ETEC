CREATE DATABASE IF NOT EXISTS Proj13;
USE Proj13;

CREATE TABLE IF NOT EXISTS Tutor(
    cpf_tutor char(11) not null,
    nome_tutor varchar(60) not null,
    cel_tutor char(11) not null,
    email_tutor varchar(50) not null unique,
    primary key(cpf_tutor)
)engine=InnoDB;

CREATE TABLE IF NOT EXISTS Pet(
	cod_pet int auto_increment unique,
    cpf_tutor char(11) not null,
	nasc_pet date not null,
    gene_pet enum("Macho","Fêmea") not null,
    raca_pet varchar(30) not null,
    foto_pet blob not null,
    nome_pet varchar(20) not null,
    especie_pet enum("Cachorro", "Gato") default ("Indefinido"),
    primary key(cod_pet),
    foreign key (cpf_tutor) references Tutor (cpf_tutor) on delete cascade
)engine=InnoDB;


CREATE TABLE IF NOT EXISTS Servicos(
	id_serv int auto_increment,
	tipo_serv enum("Banho", "Tosa") not null,
	data_serv date not null,
    valor_serv decimal(4,2),
    cod_pet int,
    primary key(id_serv),
    foreign key(cod_pet) references Pet (cod_pet) on delete cascade
)engine=InnoDB;

CREATE TABLE IF NOT EXISTS Consulta(
	id_consulta int auto_increment,
	cod_pet int,
    data_consulta date not null,
    presc_consulta varchar(90),
    primary key(id_consulta),
    foreign key(cod_pet) references Pet (cod_pet) on delete cascade
)engine=InnoDB;

select * from Pet;