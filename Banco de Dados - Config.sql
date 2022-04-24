use comercialdb0191;

--  emailnomeidCliclientescaixasdelete from cliente where idCli between 1 and 5; 

select * from clientes;

-- drop procedure sp_cliente_inserir
delimiter 
CREATE PROCEDURE sp_cliente_inserir(
_nome varchar(60),
_cpf varchar(11),
_email varchar(60)
)
BEGIN
insert into clientes(nome,cpf,email,datacad,ativo)
values (_nome,_cpf,_email,default,default);
select * from clientes where idCli = (select @@identity);
end


-- drop PROCEDURE sp_cliente_alterar;
delimiter
CREATE PROCEDURE sp_cliente_alterar(
_id int,
_nome varchar(60),
_email varchar (60)
)
BEGIN
update clientes set nome = _nome, email = _email where idcli = _id;
END
|	

update clientes set ativo = 1 where idCli = 17

select * from clientes where idcli = 5;


select * from clientes;

select * from clientes order by 2 desc;

delete from  clientes where idcli < 12
insert usuarios (nome, email, senha, nivel, ativo )values('sdgfgfs', 'fgsfgsdg@gmail.com', md5('Senha'),default,default)


/*
select * from produto;

-- drop procedure sp_produto_inserir
delimiter 
CREATE PROCEDURE sp_produto_inserir(
_unidade varchar(14),
_valor decimal(10,2),
_desconto decimal(10,2),
_codbar varchar(13),
_descricao varchar(100)
)
BEGIN
insert into produtos(unidade,valor,desconto,codbar,descricao,ativo)
values (_unidade,_valor,_desconto,_codbar,_descricao,default);
select * from produtos where idProd = (select @@identity);
end


select * from produtos;
*/
