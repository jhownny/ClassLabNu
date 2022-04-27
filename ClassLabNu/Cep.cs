using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ClassLabNu
{
    public class Cep
    {
        private int id;
        private string cidade;
        private string bairro;
        private string logradouro;
        private string tpLogradouro;
        private string ncep;


        public int Id { get { return id; } set { id = value; } }
        public string Ncep { get { return ncep; } set { ncep = value; } }
        public string TpLogradouro { get { return tpLogradouro; } set { tpLogradouro = value; } }
        public string Bairro { get { return bairro; } set { bairro = value; } }
        public string Cidade { get { return cidade; } set { cidade = value; } }
        public string Logradouro { get { return logradouro; }set { logradouro = value; } }


        public Cep()
        {

        }

        public Cep(string ncep, string tpLogradouro, string bairro, string cidade, string logradouro)
        {
            Ncep = ncep;
            TpLogradouro = tpLogradouro;
            Bairro = bairro;
            Cidade = cidade;
            Logradouro = logradouro;
        }

        public Cep(int id, string ncep, string tpLogradouro, string bairro, string cidade, string logradouro)
        {
            Id = id;
            Ncep = ncep;
            TpLogradouro = tpLogradouro;
            Bairro = bairro;
            Cidade = cidade;
            Logradouro = logradouro;
        }










    }
}
