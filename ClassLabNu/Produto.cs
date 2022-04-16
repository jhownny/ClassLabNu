using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLabNu
{
    public class Produto
    {

        // atributos da classe
        private int id;
        private string descricao;
        private double unidade;
        private string codBar;
        private double valor;
        private double desconto;
        private bool descontinuado;

        // propriedades
        public int Id { get { return id; } }
        public string Descricao { get { return descricao; } }
        public double Unidade { get { return unidade; } }
        public string CodBar { get { return codBar; } }
        public double Valor { get { return valor; } }
        public double Desconto { get { return desconto; } }
        public bool Descontinuado { get { return descontinuado; } }

        // construtores
        public Produto()
        {
        }

        public Produto(string descricao, double unidade, string codBar, double valor, double desconto)
        {
            this.descricao = descricao;
            this.unidade = unidade;
            this.codBar = codBar;
            this.valor = valor;
            this.desconto = desconto;
        }

        public static List<Produto> Listar()
        {
            throw new NotImplementedException();
        }

        public Produto(int id, string descricao, double unidade, string codBar, double valor, double desconto, bool descontinuado)
        {
            this.id = id;
            this.descricao = descricao;
            this.unidade = unidade;
            this.codBar = codBar;
            this.valor = valor;
            this.desconto = desconto;
            this.descontinuado = descontinuado;
        }

        // métodos da Classe
        public void Inserir() { }
        public Produto BuscarPorId(int _id)
        {
            Produto produto = new Produto();
            // conecta banco realiza consulta por Id do produto
            return produto;
        }
        public Produto BuscarPorCodBar(string _codBar)
        {
            Produto produto = new Produto();
            // conecta banco e realiza consulta por código de barras do produtos
            return produto;
        }
        public List<Produto> BuscarPorDescricao(string _descricao)
        {
            List<Produto> produtos = new List<Produto>();
            // conecta banco e realiza consulta por parte da descriação do produtos
            return produtos;
        }
        public void InserirProduto()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_inserir";
            cmd.Parameters.AddWithValue("_descricao", descricao);
            cmd.Parameters.AddWithValue("_unidade", unidade);
            cmd.Parameters.AddWithValue("_codBar", codBar);
            cmd.Parameters.AddWithValue("_valor",valor);
            cmd.Parameters.AddWithValue("_desconto",desconto);


            id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();


        }





        public List<Produto> ListarTodos()
        {
            List<Produto> produtos = new List<Produto>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from clientes order";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                produtos.Add(new Produto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDouble(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6)
                    ));

            }
            return produtos;
        }
        public bool Alterar()
        {
            return true;
        }

    }// fim da classe produto






}
