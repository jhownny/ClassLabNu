using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLabNu
{
    public class Telefone
    {
        //Atributos
        private int id;
        private string numero;
        private string tipo;

        //Propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Numero { get { return numero; } set { numero = value; } }
        public string Tipo { get { return tipo; } set { tipo = value;} }


        //Construtores
        public Telefone()
        {

        }

        public Telefone(string numero, string tipo)
        {
            this.numero = numero;
            this.tipo = tipo;
        }

        public Telefone(int id, string numero, string tipo)
        {
            this.id = id;
            this.numero = numero;
            this.tipo = tipo;
        }

        //Métodos da Classe





    }
}
