using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert clientes(nome, cpf, email, datacad, ativo) values('"+Nome+"', '"+Cpf+"', '"+Email+"', default, default)";

            cmd.ExecuteNonQuery();
            cmd.CommandText = "Select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }


        public bool Aterar(Cliente cliente)
        {
            return true;
        }

        public static Cliente ConsultarPorId(int id)
        {

            Cliente cliente = new Cliente();

            return cliente;

        }
        public static Cliente ConsultarPorCpf(string cpf)
        {

            Cliente cliente = new Cliente();

            return cliente;

        }

        public static List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();
            

            return clientes;

        }

    }
}
