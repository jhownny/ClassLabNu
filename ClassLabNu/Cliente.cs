using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public class Cliente
    {
        //atributos
        private string id;
        private string nome;
        private string cpf;
        private string email; 
        private DateTime data_Cad;    
        private bool ativo;

        //propriedades
        public string Id { get { return id; } set { id = value; } }
        public string Nome { get { return id; } set { id = value; } }
        public string Cpf { get { return nome; } set { nome = value; } }
        public DateTime Data_Cad { get { return data_Cad; } set { data_Cad = value; } }
        public string Email { get { return email; } set { email = value; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }

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

     
        



        //construtores


        //métodos da classe
        public void Inserir(Cliente cliente)
        {



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


            Cliente cliente2 = new Cliente();
            cliente2 = Cliente.ConsultarPorCpf("12345678900");
            return cliente;

        }

        public static List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente = new Cliente();

            return clientes;

        }

    }
}
