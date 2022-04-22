using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace ClassLabNu
{
    public  class Usuario
    {
        //Atributos
        private int id;
        private string nome;        
        private string email;
        private string senha;
        private string nivel;
        private bool ativo;



        //Propriedades
        public int Id { get { return id; } set { id = value; } }  
        public string Nome { get { return nome; } set { nome = value; } }
        public string Email { get { return email;} set { email = value; } }
        public string Senha { get { return senha; } set { senha = value; } }
        public string Nivel { get { return nivel; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }



        //Métodos Construtores
        public Usuario()
        {



        }
        public Usuario(string nome,string email,string nivel,string senha)
        {
            this.nome = nome;
            this.email = email;
            this.nivel = nivel;
            this.senha = senha;
        }

        public Usuario(int id, string nome, string senha,string nivel, bool ativo, string email)
        {
            this.id = id;
            this.nome = nome;
            Email = email;
            this.senha = senha;
            this.nivel = nivel;
            Ativo = ativo;
        }

        //Métodos da Classe
        
        public void inserir()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_inserir";
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_email", Email);
            cmd.Parameters.AddWithValue("_senha", senha);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }



        public bool Alterar(int _iduser,string _nome, string _email,string _senha,string _nivel)
        {

            bool resultado = false;

            try
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;

                //receber nome Procedure
                cmd.CommandText = "sp_produto_alterar";

                //adicionar parametro procedure Mysql
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = _iduser;
                cmd.Parameters.Add("nome", MySqlDbType.String).Value = _nome;
                cmd.Parameters.Add("email", MySqlDbType.String).Value = _email;
                cmd.Parameters.Add("senha",MySqlDbType.String).Value = _senha;
                cmd.Parameters.Add("nivel", MySqlDbType.String).Value = _nivel;


                cmd.ExecuteNonQuery();

                resultado = true;

                cmd.Connection.Close();

            }
            catch (Exception)
            {







            }
            return resultado;
        }



        public List<Usuario> ListarUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from usuario order";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                usuarios.Add(new Usuario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetBoolean(4),
                    dr.GetString(5)
                    )) ;

            }
            
            return usuarios;

        }

        public static bool EfetuarLogin(string email, string senha)
        {
            //Realiza validação e devolve verdadeiro ou falso
            return false;


        }


    }//Fim da Class Usuario
}
