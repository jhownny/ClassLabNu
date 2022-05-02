using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLabNu
{
    public class Endereco
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
        private string tipo;

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
        public string Tipo { get { return tipo; } set { tipo = value; } }

        //Consrtutores
        public Endereco()
        {
        }

        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Uf = uf;
            Tipo = tipo;
        }

        public Endereco(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo)
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
            Tipo = tipo;
        }

        //Métodos da Classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_enderecos_inserir";
            cmd.Parameters.AddWithValue("_logradouro", Logradouro);
            cmd.Parameters.AddWithValue("_numero", Numero);
            cmd.Parameters.AddWithValue("_complemento", Complemento);
            cmd.Parameters.AddWithValue("_bairro", Bairro);
            cmd.Parameters.AddWithValue("_cidade", Cidade);
            cmd.Parameters.AddWithValue("_estado", Estado);
            cmd.Parameters.AddWithValue("_uf", Uf);
            cmd.Parameters.AddWithValue("_tipo", Tipo);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }











    }
}
