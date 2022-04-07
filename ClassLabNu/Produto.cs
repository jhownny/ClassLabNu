using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public class Produto
    {

        //Atributos
        private int id;
        private string descricao;
        private string unidade;
        private string cod_Bar;
        private int valor;
        private int desconto;

        //Propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public int Valor { get { return valor; } set { valor = value; } } 
        public string Cod_Bar { get { return cod_Bar; } set { cod_Bar = value; } }
        public int Desconto { get { return desconto; } set { desconto = value; } }
        public string Unidade { get { return unidade; } set { unidade = value; } } 

        //Métodos Construtores
        public Produto()
        {

        }

        public Produto( string descricao, int valor, string cod_Bar, int desconto,string unidade)
        {
            Descricao = descricao;
            Valor = valor;
            Cod_Bar = cod_Bar;
            Desconto = desconto;
            Unidade = unidade;
        }

        public Produto(int id, string descricao, string unidade, string cod_Bar, int valor, int desconto)
        {
            this.id = id;
            this.descricao = descricao;
            this.unidade = unidade;
            this.cod_Bar = cod_Bar;
            this.valor = valor;
            this.desconto = desconto;
        }


        //Métodos da Classe

        public static ConsultarCompraPorId(int id)
        {



        }


    }
}
