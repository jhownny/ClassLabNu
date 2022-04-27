using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLabNu
{
    public class Enderecos
    {
        //Atributos
        private int id;
        private string cep;
        private string logradouro;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private string uf;

        //Propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Cep { get { return cep; }set{ cep = value; } }
        public string Logradouro {get{ return logradouro; }set{ logradouro = value; } }
        public string Numero {get{ return numero; }set{ numero = value; } }
        public string Complemento {get{ return complemento; }set{ complemento = value; } }
        public string Bairro {get{ return bairro; }set{ bairro = value; } }
        public string Cidade {get { return cidade; }set{ cidade = value; } }
        public string Estado {get{ return estado; }set{ estado = value; } }
        public string Uf {get{ return uf; }set{ uf = value; } }

        //Consrtutores
        public Enderecos()
        {
        }

        public Enderecos(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
        }

        public Enderecos(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
        }

        //Métodos da Classe

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = 





        }











    }
}
