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


select * from clientes;

select * from clientes order by 2 desc;

delete from  clientes where idcli < 12


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

