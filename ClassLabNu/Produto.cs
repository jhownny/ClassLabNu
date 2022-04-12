using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Produto> ListarTodos()
        {
            List<Produto> produtos = new List<Produto>();
            // conecta banco e realiza consulta retornando todos produtos
            return produtos;
        }
        public bool Alterar()
        {
            return true;
        }

    }// fim da classe produto






}
