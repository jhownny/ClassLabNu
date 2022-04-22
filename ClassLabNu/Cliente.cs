using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace ClassLabNu
{
    public class Cliente
    {
        //atributos
        private int id;
        private string nome;
        private string cpf;
        private string email; 
        private DateTime data_Cad;    
        private bool ativo;

        //propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Cpf { get { return cpf; } set { cpf = value; } }
        public DateTime Data_Cad { get { return data_Cad; } set { data_Cad = value; } }
        public string Email { get { return email; } set { email = value; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }


        //construtores
        public Cliente()
        {
        }

        public Cliente(string nome, string cpf, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            //Data_Cad = DateTime.Now;
            //ativo = true;
        }

        public Cliente(int id, string nome, string cpf, string email, DateTime data_Cad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Data_Cad = data_Cad;
            Ativo = ativo;


        }

        //métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_inserir";
            cmd.Parameters.AddWithValue("_nome",Nome);
            cmd.Parameters.AddWithValue("_cpf",Cpf);
            cmd.Parameters.AddWithValue("_email",Email);
            
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }


        public bool Aterar(int _id, string _nome, string _email )
        {
            bool resultado = false;
            try
            {

                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                //recebe o nome da procedure

                cmd.CommandText = "sp_cliente_alterar";
                //adiciona os paâmetrod da procedure - no mysql
                cmd.Parameters.Add("_id", MySqlDbType.Int32).Value = _id;
                cmd.Parameters.Add("_email", MySqlDbType.VarChar).Value = _email;
                cmd.Parameters.Add("_nome", MySqlDbType.VarChar).Value = _nome;

                //cmd.Parameters.AddWithValue("_id", _id);
                //cmd.Parameters.AddWithValue("_nome", _nome);
                //cmd.Parameters.AddWithValue("_email", _email);

                cmd.ExecuteNonQuery();

                resultado = true;

                cmd.Connection.Close();

            }
            catch (Exception)
            {

                

            }

            return resultado;
           
        }

        public static Cliente ConsultarPorId(int _id)
        {

            Cliente cliente = new Cliente();
            MySqlCommand cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where idcli = " + _id;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                cliente.Id = Convert.ToInt32(dr["idCli"]);
                //cliente.Nome = dr["Nome"].ToString();
                //cliente.Nome = dr[1].ToString();
                cliente.Nome = dr.GetString(1);
                cliente.Cpf = dr.GetString(2);
                cliente.Email = dr.GetString(3);
                cliente.Data_Cad = dr.GetDateTime(4);
                cliente.Ativo = dr.GetBoolean(5);


            }

            return cliente;

        }
        public static Cliente ConsultarPorCpf(int _cpf)
        {

            Cliente cliente = new Cliente();
            MySqlCommand cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where cpf = " + _cpf;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                cliente.Id = Convert.ToInt32(dr["idCli"]);
                //cliente.Nome = dr["Nome"].ToString();
                cliente.Nome = dr[1].ToString();
                cliente.Cpf = dr.GetString(2);
                cliente.Email = dr.GetString(3);
                cliente.Data_Cad = dr.GetDateTime(4);
                cliente.Ativo = dr.GetBoolean(5);


            }
            return cliente;

        }

        public static List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from clientes where ativo = 1 order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                clientes.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    ));    

            }



            return clientes;

        }

        public void desativar(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "uupdate clientes set ativo = 0 where idcli = " + _id; 
            cmd.ExecuteReader();
            cmd.Connection.Close();

        }



    }//Fim da Classe Cliente
}
