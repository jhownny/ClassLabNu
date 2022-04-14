﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
        
        public int inserir()
        {
            //Chamadas de Banco que grava registro
            return id;  


        }

        public List<Usuario> ListarUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();

            return usuarios;


        }

        public static bool EfetuarLogin(string email, string password)
        {
            //Realiza validação e devolve verdadeiro ou falso
            return false;


        }


    }
}
