using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public  class Usuario
    {
        //Atributos
        private int id;
        private string nome;        
        private string email;
        private string password;
        private bool ativo;

        //Propriedades
        public int Id { get { return id; } set { id = value; } }  
        public string Nome { get { return nome; } set { nome = value; } }
        public string Email { get { return email;} set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }

        //Métodos Construtores
        public Usuario()
        {

        }
        public Usuario(string nome,string email,string password)
        {
            this.nome = nome;
            this.email = email;
            this.password = password;
        }

        public Usuario(int id, string nome, string password, bool ativo, string email)
        {
            this.id = id;
            this.nome = nome;
            Email = email;
            this.password = password;
            Ativo = ativo;
        }

        //Métodos da Classe
        
        public int inserir()
        {
            //Chamadas de Banco que grava registro
            return id;  


        }
        public static bool EfetuarLogin(string email, string password)
        {
            //Realiza validação e devolve verdadeiro ou falso
            return false;


        }


    }
}
