using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtHome.ControleDeEstoque.Data
{
    public class BaseDeDadosDAO
    {
        //lista de tabelas
        const String TABELA_GRUPO = "TAB_GRUPO";
        const String TABELA_ITEM = "TAB_ITEM";
        const String TABELA_PEDIDO = "TAB_PEDIDO";
        const String TABELA_PEDIDO_ITEM = "TAB_PEDIDO_ITEM";
        const String TABELA_CONFIGURACAO = "TAB_CONFIGURACAO";
        const String TABELA_LOG = "TAB_LOG";

        //lista de constraints
        //pks
        const String PK_GRUPO = "PK_GRUPO";
        const String PK_ITEM = "PK_ITEM";
        const String PK_PEDIDO = "PK_PEDIDO";
        const String PK_PEDIDO_ITEM = "PK_PEDIDO_ITEM";

        //fks
        const String FK_ITEM1 = "FK_ITEM1";
        const String FK_PEDIDO_ITEM1 = "FK_PEDIDO_ITEM1";

        public void AtualizarBaseDeDados()
        {
            try
            {
                CriarTabelaGrupo();
                CriarTabelaItem();
                CriarTabelaPedido();
                CriarTabelaPedidoItem();
                CriarTabelaConfiguracao();
                CriarTabelaLog();
                CriarConstraints();
            }
            catch (Exception)
            { throw; }
        }

        public void CriarTabelaGrupo()
        {
            StringBuilder sql = new StringBuilder();
            AppDbConnection _appConn;

            if (ExisteObjeto(TABELA_GRUPO))
                return;

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append("create table tab_grupo ");
                    sql.Append("( ");
                    sql.Append("    grupo_id numeric not null identity, ");
                    sql.Append("    grupo_desc varchar(200) not null ");
                    sql.Append(") ");

                    _appConn.ExecuteNonQuery(sql.ToString());
                }

            }
            catch (Exception)
            { throw; }
        }

        public void CriarTabelaItem()
        {
            StringBuilder sql = new StringBuilder();
            AppDbConnection _appConn;

            if (ExisteObjeto(TABELA_ITEM))
                return;

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append("create table tab_item");
                    sql.Append("(");
                    sql.Append("    item_id numeric not null identity, ");
                    sql.Append("    item_desc varchar(200) not null, ");
                    sql.Append("    grupo_id numeric not null, ");
                    sql.Append("    item_qtd_atual numeric(6), ");
                    sql.Append("    item_estoque_minimo numeric(6), ");
                    sql.Append("    item_tamanho varchar(100), ");
                    sql.Append("    item_preco_custo numeric(8,2), ");
                    sql.Append("    item_porcetagem_lucro numeric(5,2), ");
                    sql.Append("    item_preco_venda numeric(8,2) ");
                    sql.Append(")");

                    _appConn.ExecuteNonQuery(sql.ToString());
                }

            }
            catch (Exception)
            { throw; }
        }

        public void CriarTabelaPedido()
        {
            StringBuilder sql = new StringBuilder();
            AppDbConnection _appConn;

            if (ExisteObjeto(TABELA_PEDIDO))
                return;

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append("create table tab_pedido");
                    sql.Append("(");
                    sql.Append("    pedido_id numeric not null identity, ");
                    sql.Append("    pedido_numero numeric (10) not null, ");
                    sql.Append("    pedido_data_hora datetime, ");
                    sql.Append("    pedido_finalizado numeric(1), ");
                    sql.Append("    pedido_tipo_operacao numeric(1), ");
                    sql.Append("    pedido_observacao varchar(500), ");
                    sql.Append("    pedido_valor numeric(10,2) ");
                    sql.Append(")");

                    _appConn.ExecuteNonQuery(sql.ToString());
                }

            }
            catch (Exception)
            { throw; }
        }

        public void CriarTabelaPedidoItem()
        {
            StringBuilder sql = new StringBuilder();
            AppDbConnection _appConn;

            if (ExisteObjeto(TABELA_PEDIDO_ITEM))
                return;

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append("create table tab_pedido_item");
                    sql.Append("(");
                    sql.Append("    pedido_id numeric not null, ");
                    sql.Append("    item_id numeric not null, ");
                    sql.Append("    item_desc varchar(200), ");
                    sql.Append("    pedido_item_tamanho varchar(3), ");
                    sql.Append("    grupo_desc varchar(200), ");
                    sql.Append("    pedido_quantidade numeric(6), ");
                    sql.Append("    pedido_valor_unitario numeric(8,2), ");
                    sql.Append("    pedido_valor_total numeric(10,2) ");
                    sql.Append(")");

                    _appConn.ExecuteNonQuery(sql.ToString());
                }

            }
            catch (Exception)
            { throw; }
        }

        public void CriarTabelaConfiguracao()
        {
            StringBuilder sql = new StringBuilder();
            AppDbConnection _appConn;

            if (ExisteObjeto(TABELA_CONFIGURACAO))
                return;

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append("create table tab_configuracao");
                    sql.Append("(");
                    sql.Append("    config_solicita_senha numeric(1), ");
                    sql.Append("    config_senha varchar(20), ");
                    sql.Append("    config_rel_cabecalho varchar(4000), ");
                    sql.Append("    config_rel_telefone varchar(200), ");
                    sql.Append("    config_rel_nome_empresa varchar(100), ");
                    sql.Append("    config_logoTipo varchar(500) ");
                    sql.Append(")");

                    _appConn.ExecuteNonQuery(sql.ToString());
                }

            }
            catch (Exception)
            { throw; }
        }

        public void CriarTabelaLog()
        {
            StringBuilder sql = new StringBuilder();
            AppDbConnection _appConn;

            if (ExisteObjeto(TABELA_LOG))
                return;

            try
            {
                using (_appConn = new AppDbConnection())
                {

                    sql.Append("create table tab_log");
                    sql.Append("(");
                    sql.Append("    log_data_hora datetime, ");
                    sql.Append("    log_item_id numeric, ");
                    sql.Append("    log_item_desc varchar(200), ");
                    sql.Append("    log_quantidade_anterior numeric(10), ");
                    sql.Append("    log_quantidade numeric(10), ");
                    sql.Append("    log_quantidade_informada numeric(10), ");
                    sql.Append("    log_origem varchar(100), ");
                    sql.Append("    log_tipo_operacao varchar(20), ");
                    sql.Append("    log_pedido_id numeric(10), ");
                    sql.Append("    log_pedido_numero numeric(10) ");
                    sql.Append(")");

                    _appConn.ExecuteNonQuery(sql.ToString());
                }

            }
            catch (Exception)
            { throw; }
        }

        private void CriarConstraints()
        {
            StringBuilder sql = new StringBuilder();
            AppDbConnection _appConn;

            try
            {
                if (!ExisteObjeto(PK_GRUPO))
                {
                    using (_appConn = new AppDbConnection())
                    {
                        sql.Clear();
                        sql.Append("alter table tab_grupo add constraint pk_grupo primary key (grupo_id)");
                        _appConn.ExecuteNonQuery(sql.ToString());
                    }
                }

                if (!ExisteObjeto(PK_ITEM))
                {
                    using (_appConn = new AppDbConnection())
                    {
                        sql.Clear();
                        sql.Append("alter table tab_item add constraint pk_item primary key (item_id)");
                        _appConn.ExecuteNonQuery(sql.ToString());
                    }
                }

                if (!ExisteObjeto(FK_ITEM1))
                {
                    using (_appConn = new AppDbConnection())
                    {
                        sql.Clear();
                        sql.Append("alter table tab_item add constraint fk_item1 foreign key (grupo_id) references tab_grupo(grupo_id)");
                        _appConn.ExecuteNonQuery(sql.ToString());
                    }
                }

                if (!ExisteObjeto(PK_PEDIDO))
                {
                    using (_appConn = new AppDbConnection())
                    {
                        sql.Clear();
                        sql.Append("alter table tab_pedido add constraint pk_pedido primary key (pedido_id)");
                        _appConn.ExecuteNonQuery(sql.ToString());
                    }
                }

                if (!ExisteObjeto(PK_PEDIDO_ITEM))
                {
                    using (_appConn = new AppDbConnection())
                    {
                        sql.Clear();
                        sql.Append("alter table tab_pedido_item add constraint pk_pedido_item primary key (pedido_id, item_id)");
                        _appConn.ExecuteNonQuery(sql.ToString());
                    }
                }

                if (!ExisteObjeto(FK_PEDIDO_ITEM1))
                {
                    using (_appConn = new AppDbConnection())
                    {
                        sql.Clear();
                        sql.Append("alter table tab_pedido_item add constraint fk_pedido_item1 foreign key (pedido_id) references tab_pedido(pedido_id)");
                        _appConn.ExecuteNonQuery(sql.ToString());
                    }
                }

            }
            catch (Exception)
            { throw; }

        }

        private bool ExisteObjeto(String objeto)
        {
            StringBuilder sql = new StringBuilder();
            AppDbConnection _appConn;
            bool result;

            try
            {
                using (_appConn = new AppDbConnection())
                {
                    sql.Append("select 1");
                    sql.Append("  from sys.objects");
                    sql.Append(" where schema_id = schema_id('dbo')");
                    sql.Append(String.Format("   and upper(name) = '{0}'", objeto.ToUpper()));

                    result = _appConn.ExecuteScalar(sql.ToString()) > 0;
                }
            }
            catch (Exception)
            { throw; }

            return result;
        }
    }
}
