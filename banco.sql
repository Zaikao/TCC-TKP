create database tkp;

create table cadastro (
id int not null auto_increment,
nome varchar (30) not null,
idade date not null,
email varchar (30) not null,
senha varchar (20) not null,
primary key (id)
);

create table receitas (
salario float not null,
receita float not null,
pessoa int not null,
foreign key (pessoa)
references cadastro(id)
);

create table despesas (
gastosdad float,
contadea float,
contadel float,
contasgerais float,
aluguel float,
planodes float,
escola float
);