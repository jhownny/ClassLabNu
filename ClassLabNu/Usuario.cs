using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using ClassLabNu;


namespace ClassLabNu
{
    public  class Usuario
    {
        //Atributos
        private int id;
        private string nome;        
        private string email;
        private string senha;
        private Nivel nivel;
        private bool ativo;



        //Propriedades
        public int Id { get { return id; } set { id = value; } }  
        public string Nome { get { return nome; } set { nome = value; } }
        public string Email { get { return email;} set { email = value; } }
        public string Senha { get { return senha; } set { senha = value; } }
        public Nivel Nivel { get { return nivel; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }



        //Métodos Construtores
        public Usuario(int _id = 0)
        {

            id = _id;

        }
        public Usuario(string nome, string email, Nivel nivel, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.nivel = nivel;
            this.senha = senha;
            Ativo = true;
        }

        public Usuario(int id, string nome, string senha, Nivel nivel, bool ativo, string email)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.nivel = nivel;
            this.ativo = ativo;
        }

        //Métodos da Classe

        public static Usuario ObterPorId(int _id)
        {
            Usuario usuario = new Usuario(0);
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from usuarios where id = " + _id;
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario.id = dr.GetInt32(0);
                usuario.nome = dr.GetString(1);
                usuario.email = dr.GetString(2);
                usuario.senha = dr.GetString(3);
                usuario.nivel = Nivel.ObterPorId(dr.GetInt32(4));
                usuario.ativo = dr.GetBoolean(5);
            }
            return usuario;
        }

        public List<Usuario> ListarUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from usuario";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                usuarios.Add(new Usuario(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    Nivel.ObterPorId(dr.GetInt32(0)),
                    dr.GetBoolean(4),
                    dr.GetString(5)
                    ));

            }

            return usuarios;

        }

        public static Usuario EfetuarLogin(string email, string senha)
        {
            Usuario usuario = new Usuario();
            // realiza validação e devolve verdadeiro ou falso
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from usuarios where email = '" +
                email + "' and senha = md5('" + senha + "')";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario.id = dr.GetInt32(0);
                usuario.nome = dr.GetString(1);
                usuario.email = dr.GetString(2);
                usuario.senha = dr.GetString(3);
                usuario.nivel = Nivel.ObterPorId(dr.GetInt32(4));
                usuario.ativo = dr.GetBoolean(5);
            }
            return usuario;
        }





        //public void inserir()
        //{

        //    var cmd = Banco.Abrir();
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    cmd.CommandText = "sp_usuario_inserir";
        //    cmd.Parameters.AddWithValue("_nome", Nome);
        //    cmd.Parameters.AddWithValue("_email", Email);
        //    cmd.Parameters.AddWithValue("_senha", senha);

        //    Id = Convert.ToInt32(cmd.ExecuteScalar());
        //    cmd.Connection.Close();

        //}







        //public bool Alterar(int _iduser,string _nome, string _email,string _senha,Nivel _nivel)
        //{

        //    bool resultado = false;

        //    try
        //    {
        //        var cmd = Banco.Abrir();
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        //receber nome Procedure
        //        cmd.CommandText = "sp_produto_alterar";

        //        //adicionar parametro procedure Mysql
        //        cmd.Parameters.Add("id", MySqlDbType.Int32).Value = _iduser;
        //        cmd.Parameters.Add("nome", MySqlDbType.String).Value = _nome;
        //        cmd.Parameters.Add("email", MySqlDbType.String).Value = _email;
        //        cmd.Parameters.Add("senha",MySqlDbType.String).Value = _senha;
        //        cmd.Parameters.Add("nivel", MySqlDbType.String).Value = _nivel;


        //        cmd.ExecuteNonQuery();

        //        resultado = true;

        //        cmd.Connection.Close();

        //    }
        //    catch (Exception)
        //    {







        //    }
        //    return resultado;
        //}



        //public static bool EfetuarLogin(string email, string senha)
        //{
        //    //Realiza validação e devolve verdadeiro ou falso
        //    return false;


        //}


    }//Fim da Class Usuario
}
