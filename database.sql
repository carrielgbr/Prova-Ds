drop database banco_trabalho_ds;
create database banco_trabalho_ds;
use banco_trabalho_ds;

create table tb_Usuario 
(
	Id_Usuario int primary Key auto_increment,
    nm_Usuario varchar (255) not null,
    Login_Usuario varchar (255) not null,
    Senha_Usuario varchar (255) not null
    );
Insert into tb_Usuario (nm_Usuario, Login_Usuario, Senha_Usuario) values
	('Murilo','adm','123');
    
create table tb_cliente 
(
	Id_cliente int primary Key auto_increment,
    nm_cliente varchar (255),
    cpf_cliente char (11),
    telefone_cliente char (11),
    endereço_cliente varchar (255) 
);

Insert into tb_cliente (nm_cliente, cpf_cliente, telefone_cliente, endereço_cliente) values
	('sem identificação', '00000000000', '00000000000', ''),
    ('Maria Silva', '12345678901', '987654321', 'Rua A, 123'),
	('João Santos', '98765432109', '123456789', 'Rua B, 456'),
	('Ana Oliveira', '45678912302', '789456123', 'Avenida C, 789'),
	('Pedro Rodrigues', '78912345603', '321654987', 'Travessa D, 987'),
	('Carla Souza', '65498732104', '456789123', 'Rua E, 654'),
	('Fernando Almeida', '32165498705', '987321654', 'Avenida F, 321'),
	('Mariana Costa', '98732165406', '654987321', 'Rua G, 987'),
    ('Gabriel Oliveira', '78945612308', '987654321', 'Rua I, 789'),
	('Lucas Pereira', '65412378907', '321789654', 'Travessa H, 654');
select * from tb_cliente;

create table tb_tipoProduto 
(
	Id_tipoProduto  int primary Key auto_increment,
    nm_tipoProduto  varchar (255)
);
INSERT INTO tb_tipoProduto (nm_tipoProduto) VALUES
	('Shampoo'),
	('Condicionador'),
	('Máscara Capilar'),
	('Finalizador'),
	('Coloração');


create table tb_Produto 
(
	Id_Produto  int primary Key auto_increment,
    nm_Produto  varchar (255),
    Preco_Produto  decimal (18,2),
    Id_tipoProduto  int ,
    foreign key (Id_tipoProduto) references tb_tipoProduto (Id_tipoProduto)
);
INSERT INTO tb_Produto (nm_Produto, Preco_Produto, Id_tipoProduto) VALUES
	('Shampoo A', 10.00, 1),
	('Shampoo B', 12.50, 1),
	('Shampoo C', 9.99, 1),
	('Condicionador A', 15.00, 2),
	('Condicionador B', 13.75, 2),
	('Condicionador C', 11.99, 2),
	('Máscara Capilar A', 20.00, 3),
	('Máscara Capilar B', 18.50, 3),
	('Máscara Capilar C', 16.99, 3),
	('Finalizador A', 10.00, 4),
	('Finalizador B', 8.50, 4),
	('Finalizador C', 7.99, 4),
	('Coloração A', 25.00, 5),
	('Coloração B', 22.50, 5),
	('Coloração C', 19.99, 5),
	('Shampoo D', 11.00, 1),
	('Shampoo E', 13.50, 1),
	('Condicionador D', 16.00, 2),
	('Condicionador E', 14.75, 2),
	('Máscara Capilar D', 22.00, 3);
select * from tb_Produto;

CREATE VIEW view_produto AS
SELECT tb_Produto.nm_Produto AS nome, tb_Produto.Preco_Produto AS preço, tb_tipoProduto.nm_tipoProduto AS tipo
FROM tb_Produto
right JOIN tb_tipoProduto ON tb_Produto.Id_tipoProduto = tb_tipoProduto.Id_tipoProduto;
select * from view_produto;

create table tb_estoque 
(
	Id_estoque  int primary Key auto_increment,
    Id_Produto  int,
    quantiadade_estoque  int (3),
    foreign key (Id_Produto) references tb_Produto (Id_Produto)
);
INSERT INTO tb_estoque (Id_Produto, quantiadade_estoque) VALUES
	(1, 10),
	(2, 5),
	(3, 8),
	(4, 15),
	(5, 12),
	(6, 7),
	(7, 20),
	(8, 18),
	(9, 25),
	(10, 10),
	(11, 8),
	(12, 13),
	(13, 30),
	(14, 25),
	(15, 20),
	(16, 7),
	(17, 4),
	(18, 10),
	(19, 9),
	(20, 15);
select*from tb_estoque;

SELECT tb_Produto.nm_Produto, tb_estoque.quantiadade_estoque
FROM tb_Produto
RIGHT JOIN tb_estoque ON tb_Produto.Id_Produto = tb_estoque.Id_estoque;


create table tb_servicos
(
	Id_servicos  int primary Key auto_increment,
	nm_servicos  varchar (255),
	Preco_servicos  decimal (18,2)
);
INSERT INTO tb_servicos (nm_servicos, Preco_servicos) VALUES
('Corte de Cabelo', 50.00),
('Coloração', 80.00),
('Escova Progressiva', 120.00),
('Hidratação Capilar', 40.00),
('Penteado para Festas', 60.00),
('Manicure', 30.00),
('Pedicure', 35.00),
('Design de Sobrancelhas', 25.00),
('Depilação', 50.00),
('Maquiagem', 70.00);
select * from tb_servicos;

create table tb_servicoscliente
(
	Id_servicoscliente  int primary Key auto_increment,
	Id_servicos  int,
	Id_cliente  int,
    foreign key (Id_servicos) references tb_servicos (Id_servicos),
    foreign key (Id_cliente) references tb_cliente (Id_cliente)
);
INSERT INTO tb_servicoscliente (Id_servicos, Id_cliente) VALUES
(1, 1), 
(2, 2), 
(3, 3), 
(1, 4), 
(2, 5); 


CREATE VIEW view_cliente_servicos AS
SELECT tb_cliente.nm_cliente AS cliente, tb_servicos.nm_servicos AS serviço, tb_servicos.Preco_servicos AS preço
FROM tb_servicoscliente
INNER JOIN tb_servicos ON tb_servicoscliente.Id_servicoscliente = tb_servicos.Id_servicos
INNER JOIN tb_cliente ON tb_servicoscliente.Id_servicoscliente = tb_cliente.Id_cliente;
select * from view_cliente_servicos;