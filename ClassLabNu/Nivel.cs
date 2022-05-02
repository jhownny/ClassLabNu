using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public class Nivel
    {
        // atributos - campos
        private int id;
        private string nome;
        private string sigla;
        

        // criando propriedades
        public int Id { get { return id; } }
        public string Nome { get { return nome; } private set { nome = value; } }
        public string Sigla { get { return sigla; } }



        // métodos construtores
        public Nivel(int _id = 0)
        {
        }
        public Nivel(string nome, string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
            
        }
        public Nivel(int id, string nome, string sigla )
        {
            this.id = id;
            this.nome = nome;
            this.sigla = sigla;
            
        }
        // Métodos da classe
        public void InserirNovo()
        {
            // inserir um novo nível
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_niveis_inserir";
            cmd.Parameters.AddWithValue("_nome",Nome);
            cmd.Parameters.AddWithValue("_sigla",Sigla);
            id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }
        /// <summary>
        /// Altera a sigla do nível indicado. Apenas administradores.
        /// </summary>
        /// <param name="id">identificação do nível</param>
        /// <param name="sigla">valor literal da nova sigla</param>
        /// <returns>Retorna valor par teste lógico, confirmando a alteração</returns>
        public bool Alterar(int id, string sigla)
        {
            return true;
        }

        public static Nivel ObterPorId(int _id)
        {
            Nivel nivel = null;
            
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from niveis where idNv = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                nivel = new Nivel(dr.GetInt32(0), dr.GetString(1), dr.GetString(2));

            }
            return nivel;
            //throw new NotImplementedException();

            public static List<Nivel> Listar()
            {
                List<Nivel> niveis = new List<Nivel>();
                var cmd = Banco.Abrir();
                cmd.CommandText = "select * from niveis";
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    niveis.Add(new Nivel(dr.GetInt32(0), dr.GetString(1), dr.GetString(2)));

                }
                return niveis;

            }

        }
    }//Fim da Classe NIvel

}
