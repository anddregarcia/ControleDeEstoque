-----------------------------
--script para cria��o de base
-----------------------------

drop table tab_item
go
drop table tab_grupo
go
drop table tab_configuracao
go
drop table tab_pedido_item
go
drop table tab_pedido
go
drop table tab_log
go

create table tab_grupo
(
	grupo_id numeric(10) not null identity, --identificador interno
	grupo_desc varchar(200) not null --descri��o do grupo
)
go

create table tab_item
(
	item_id numeric(10) not null identity, --identificador interno
	item_desc varchar(200) not null, --descri��o do item
	grupo_id numeric(10) not null, --identificador do grupo
	item_qtd_atual numeric(6), --quantidade dispon�vel em estoque
	item_estoque_minimo numeric(6), --estoque m�nimo
	item_tamanho varchar(100), --tamanho
	item_preco_custo numeric(8,2), --pre�o de custo
	item_porcetagem_lucro numeric(5,2), --porcetagem de lucro
	item_preco_venda numeric(8,2) --pre�o de venda
)
go

create table tab_pedido
(
	pedido_id numeric(10) not null identity, --identificador interno
	pedido_numero numeric (10) not null, --numero do pedido
    pedido_data_hora datetime, --data e hora em que o pedido foi salvo
	pedido_finalizado numeric(1), --indica que o pedido n�o poder� mais ser alterado
	pedido_tipo_operacao numeric(1), --indica se foi compra (soma) ou venda (subtrai)
	pedido_observacao varchar(500), --observa��o
    pedido_valor numeric(10,2) -- pre�o total da venda
)
go

create table tab_pedido_item
(
	pedido_id numeric(10) not null, --identificador interno
	item_id numeric(10) not null, --identificador interno do item
	item_desc varchar(200), --nome do item
	pedido_item_tamanho varchar(3), --tamanho do item
	pedido_quantidade numeric(6), -- quantidade do pedido
	pedido_valor_unitario numeric(8,2), --pre�o de venda unit�rio
	pedido_valor_total numeric(10,2) --pre�o de venda total
)
go

create table tab_configuracao
(
	config_solicita_senha numeric(1), --1: exige senha para entrar, 0: n�o exige
	config_senha varchar(20), --cadastro da senha
    config_logotipo varchar(300), --guarda o caminho da imagem do logo
	config_rel_cabecalho varchar(4000), --texto que ser� exibido no cabe�alho do relat�rio
    config_rel_telefone varchar(200), --telefone que ser� exibido no relat�rio
    config_rel_nome_empresa varchar(100) --nome da empresa para exibir no relat�rio
)
go

create table tab_log
(
    log_data_hora datetime, --data e hora do registro do log
    log_item_id numeric(10), --identificador do item 
    log_item_desc varchar(200), --descricao do item
	log_quantidade_anterior numeric(10), --a quantidade que estava no estoque antes da altera��o
    log_quantidade numeric(10), --quantidade que ficou no estoque
    log_quantidade_informada numeric(10), --quantidade utilizada na opera��o
    log_origem varchar(100), --onde ocorre a altera��o (em qual tela)
    log_tipo_operacao varchar(20), --tipo da opera��o
    log_pedido_id numeric(10), --identificador do pedido
    log_pedido_numero numeric(10) --n�mero do pedido
)
go

alter table tab_grupo add constraint pk_grupo primary key (grupo_id)
go

alter table tab_item add constraint pk_item primary key (item_id)
go

alter table tab_item add constraint fk_item1 foreign key (grupo_id) references tab_grupo(grupo_id)
go

alter table tab_pedido add constraint pk_pedido primary key (pedido_id)
go

alter table tab_pedido_item add constraint pk_pedido_item primary key (pedido_id, item_id)
go

alter table tab_pedido_item add constraint fk_pedido_item1 foreign key (pedido_id) references tab_pedido(pedido_id)
go


---------------------------------------------------
--queries
---------------------------------------------------
select * from tab_grupo

select * from tab_item


select b.item_desc, 
	   b.item_tamanho, 
	   a.grupo_desc, 
	   b.item_qtd_atual, 
	   b.item_estoque_minimo,
	   null as adicionar,
	   null as subtrair,
	   null as substituir,
	   b.item_preco_custo,
	   b.item_preco_venda
  from tab_grupo a inner join
	   tab_item b on (a.grupo_id = b.grupo_id)
 


 select a.pedido_id,
        a.pedido_numero,
        a.pedido_observacao,
        a.pedido_tipo_operacao,
        a.pedido_finalizado,
        a.pedido_valor
   from tab_pedido a
   
 
 select a.pedido_id,
        a.item_id,
        a.item_desc,
        a.pedido_item_tamanho,
        a.pedido_quantidade,
        a.pedido_valor_total,
        a.pedido_valor_unitario
   from tab_pedido_item a

select coalesce(max(a.pedido_numero),0) + 1 as proximo  from dbo.tab_pedido a


select a.pedido_id,        
       a.pedido_numero,        
       a.pedido_data_hora,        
       a.pedido_observacao,        
       a.pedido_tipo_operacao,        
       a.pedido_finalizado,        
       a.pedido_valor   
  from dbo.tab_pedido a 


select *
  from tab_log
order by 1 desc


 select * from tab_configuracao


 select * 
   from sys.objects
  where schema_id = schema_id('dbo')
    --and upper(name) = ''
    order by 1




select 1  from sys.objects where schema_id = schema_id('dbo')   and upper(name) = 'pTAB_PEDIDO'

select 1  from sys.objects where schema_id = schema_id('dbo')   and upper(name) = 'TAB_GRUPO'