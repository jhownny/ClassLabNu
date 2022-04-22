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
        private string password;
        private Nivel nivel;
        private bool ativo;

        //Propriedades
        public int Id { get { return id; } set { id = value; } }  
        public string Nome { get { return nome; } set { nome = value; } }
        public string Email { get { return email;} set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
        public Nivel Nivel { get { return nivel; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }

        //Métodos Construtores
        public Usuario()
        {



        }
        public Usuario(string nome,string email,Nivel nivel,string password)
        {
            this.nome = nome;
            this.email = email;
            this.nivel = nivel;
            this.password = password;
        }

        public Usuario(int id, string nome, string password,Nivel nivel, bool ativo, string email)
        {
            this.id = id;
            this.nome = nome;
            Email = email;
            this.password = password;
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
            cmd.Parameters.AddWithValue("_senha", Password);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            
             


        }

        public List<Usuario> ListarUsuario(Nivel)
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
                    dr.(3),
                    dr.GetBoolean(4),
                    dr.GetString(5)
                    )) ;

            }
            
            return usuarios;

        }

        public static bool EfetuarLogin(string email, string password)
        {
            //Realiza validação e devolve verdadeiro ou falso
            return false;


        }


    }
}
