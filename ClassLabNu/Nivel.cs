using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public class Nivel
    {
        //atributos - campos
        private int id;
        private string nome;
        private int sigla;
        public readonly bool ativo;

        //criando propriedades

        public int Id { get { return id; } }
        public string Nome { get { return nome; } private set { nome = value; } }
        public string Sigla { get { return Sigla; } }



        //Métodos Construtores

        public Nivel()
        {



        }

        public Nivel(string nome, int sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
            ativo = true;
        }

        public Nivel(int id, string nome, int sigla, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.sigla = sigla;
            this.ativo = ativo;
        }

        //Métodos da Classe

        public void InserirNovo()
        {

            //InserirNovo um novo nível

        }
        ///<summary>       
        ///Altera a sigla do nível indicado. Apenas administradores.
        ///</summary>
        ///<param name="id">identificação do nível</param>
        ///<param name="sigla">valor literal da nova sigla</param>
        ///<returns>retorna valor para teste lógico, confirmando a alteração</returns>

        public bool Alterar(int id, string sigla)
        {
            return true;
        }
           




    }

}
