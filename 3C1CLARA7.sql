CREATE database  3C1CLARA7;
USE  3C1CLARA7;

CREATE TABLE tbl_Funcionarios(
	id int not null primary key auto_increment,
    email varchar(100) not null,
    senha varchar(100) not null
) ENGINE = InnoDB;

create table tbl_Produtos(
	id int not null primary key auto_increment,
    Produto varchar(100) not null,
    categoria varchar(50) not null,
    quantidade int not null,
    preco DOUBLE not null
)ENGINE = InnoDB;