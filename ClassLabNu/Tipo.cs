using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLabNu
{


    //Tipo de Usuario
    public class Tipo
    {

        //Atributos da Classe
        private int id;
        private string nome;
        private string sigla;


        //Propriedades
        public int Id { get { return id; } }
        public string Nome { get { return nome; } }
        public string Sigla { get { return sigla; } }


        //Construtores
        public Tipo()
        {
        }

        public Tipo(string nome, string sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }

        public Tipo(int id, string nome, string sigla)
        {
            this.id = id;
            this.nome = nome;
            this.sigla = sigla;
        }

        //Métodos da Classe


        //Inserir Tipo de Usuario
        public void inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipo_inserir";

            cmd.Parameters.AddWithValue("_nome", nome);
            cmd.Parameters.AddWithValue("sigla", sigla);

            id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        //Alterar Tipo de Usuario
        public bool alterar(int _idtipo, string _nome, string _sigla)
        {

            bool resultado = false;

            try
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;

                //Receber Nome Procedure
                cmd.CommandText = "sp_tipo_alterar";

                //Adiciona Parametros da Procedure do MySQL
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = _idtipo;
                cmd.Parameters.Add("nome", MySqlDbType.String).Value = _nome;
                cmd.Parameters.Add("sigla", MySqlDbType.String).Value = _sigla;

                cmd.ExecuteNonQuery();

                resultado = true;

                cmd.Connection.Close();


            }
            catch (Exception)
            {



            }
            return resultado;



        }
    }
}
