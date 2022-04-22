using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLabNu
{
    public class Produto
    {
        
        
        // atributos da classe
        private int id;
        private double unidade;
        private int valor;
        private double desconto;
        private string codBar;
        private string descricao;
        private bool descontinuado;

        // propriedades
        public int Id { get { return id; } }
        public double Unidade { get { return unidade; } }
        public int Valor { get { return valor; } }
        public double Desconto { get { return desconto; } }
        public string CodBar { get { return codBar; } }
        public string Descricao { get { return descricao; } }
        public bool Descontinuado { get { return descontinuado; } }

        // construtores
        public Produto()
        {
        }

        public Produto(string descricao, double unidade, string codBar, int valor, double desconto)
        {
            this.descricao = descricao;
            this.unidade = unidade;
            this.codBar = codBar;
            this.valor = valor;
            this.desconto = desconto;
        }

      

        public Produto(int id, string descricao, double unidade, string codBar, int valor, double desconto, bool descontinuado)
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

        public static List<Produto> Listar()
        {
            throw new NotImplementedException();
        }



        public void Inserir() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_inserir";
            cmd.Parameters.AddWithValue("_unidade", Unidade);
            cmd.Parameters.AddWithValue("_valor", Valor);
            cmd.Parameters.AddWithValue("_dsconto", Desconto);
            cmd.Parameters.AddWithValue("_codBar", CodBar);
            cmd.Parameters.AddWithValue("_descricao", Descricao);

            id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();



        }

        public bool Alterar(int _idprod, string _unidade, string _valor, int _desconto, double _codbar, string _descricao)
        {
            bool resultado = false;

            try
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;

                //receber nome Procedure
                cmd.CommandText = "sp_produto_alterar";

                //adicionar parametro procedure Mysql
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = _idprod;
                cmd.Parameters.Add("unidade", MySqlDbType.Double).Value = _unidade;
                cmd.Parameters.Add("valor", MySqlDbType.Int32).Value = _valor;
                cmd.Parameters.Add("desconto", MySqlDbType.Int32).Value = _desconto;
                cmd.Parameters.Add("cod_Bar", MySqlDbType.Int32).Value = _codbar;
                cmd.Parameters.Add("descrição", MySqlDbType.String).Value = _descricao;



                cmd.ExecuteNonQuery();

                resultado = true;

                cmd.Connection.Close();

            }
            catch (Exception)
            {



            }
            return resultado;
        }



        public Produto BuscarPorId(int _id)
        {
            Produto produto = new Produto();
            MySqlCommand cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where idProd = " + id;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto.id = Convert.ToInt32(dr["dProd"]);
                produto.unidade = dr.GetDouble(1);
                produto.valor = dr.GetInt32(2);
                produto.desconto = dr.GetInt32(3);
                produto.codBar = dr.GetString(4);
                produto.descricao = dr.GetString(5);
                produto.descontinuado = dr.GetBoolean(6);




            }
          


                return produto;
        }


        public Produto BuscarPorCodBar(string _codBar)
        {
            Produto produto = new Produto();
            // conecta banco e realiza consulta por código de barras do produtos
            MySqlCommand cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where codBar = " + codBar;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto.id = Convert.ToInt32(dr["idProd"]);
                produto.unidade = dr.GetDouble(1);
                produto.valor = dr.GetInt32(2);
                produto.desconto = dr.GetInt32(3);
                produto.codBar = dr.GetString(4);
                produto.descricao = dr.GetString(5);
                produto.descontinuado = dr.GetBoolean(6);


            }

               
                return produto;
        }


        public Produto BuscarPorDescricao(string _descricao)
        {
            Produto produto = new Produto();
            // conecta banco e realiza consulta por parte da descriação do produtos
            MySqlCommand cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where descricao = " + descricao;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto.id = Convert.ToInt32(dr["idProd"]);
                produto.unidade = dr.GetDouble(1);
                produto.valor = dr.GetInt32(2);
                produto.desconto = dr.GetInt32(3);
                produto.codBar = dr.GetString(4);
                produto.descricao = dr.GetString(5);
                produto.descontinuado = dr.GetBoolean(6);
            }



            return produto;
        }


        public List<Produto> ListarTodos()
        {
            List<Produto> produtos = new List<Produto>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from produtos order";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                produtos.Add(new Produto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDouble(2),
                    dr.GetString(3),
                    dr.GetInt32(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6)
                    ));

            }
            return produtos;
        }




      

    }// fim da classe produto






}
