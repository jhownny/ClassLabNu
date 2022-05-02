using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassLabNu
{
    //Documentação de Classes de Projeto. - XML Docs
    public class Pedido
    {
       //ID_Ped Data    Status_Ped  Desconto    idcli_ped    iduser_ped
       //Atributos



        //Propriedades
        public int Id { get; set; }
        public DateTime DataPed { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public List<ItemPedido> Itens { get; set; }

        //Construtores

        public Pedido()
        {
        }


        public Pedido(Cliente cliente,Usuario usuario) 
        {
            Cliente = cliente;
            Usuario = usuario;
        
        }


        public Pedido(DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {
            DataPed = dataPed;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }

        public Pedido(int id, DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {
            Id = id;
            DataPed = dataPed;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }

        //Métodos da Classe - Operações/Açoes/Funções
        public void Inserir() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_inserir";
            cmd.Parameters.AddWithValue("_idCli", Cliente.Id);
            cmd.Parameters.AddWithValue("_idUser", Usuario.Id);
            var dr = cmd.ExecuteReader();
            dr.Read();
            Id = dr.GetInt32(0);
            Status = dr.GetString(1);
            cmd.Connection.Close();


        }
        public bool Alterar (int _id, string _status, double _desconto)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedidos_alterar";
            cmd.Parameters.AddWithValue("_desconto",_desconto);
            cmd.Parameters.AddWithValue("_status",_status);

            if (cmd.ExecuteNonQuery() > -1)
            {
                return true;
            }


            return false;
        }

        public static Pedido ConsultarPorId(int _id)
        {
            Pedido pedido = null;
            //conecta ao banco e realiza a consulta pelo id do pedido
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from produtos where idPed = " + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedido = new Pedido(
                    dr.GetInt32(0),
                    dr.GetDateTime(1),
                    dr.GetString(2),
                    dr.GetDouble(3),
                    Cliente.ConsultarPorId(dr.GetInt32(4)),
                    Usuario.ObterPorId(dr.GetInt32(5)),
                    ItemPedido.ListarItens(dr.GetInt32(0))
                    );
            }
            return pedido;

            public static List<Pedido> ConsultarPorClienteId(int _id)
            {
                List<Pedido> pedidos = new List<Pedido>();
                Pedido pedido = new Pedido();
                // graça...conecta ao banco e realiza a consulta pelo id do pedido
                var cmd = Banco.Abrir();
                cmd.CommandText = "select * from produtos where idPed = " + _id;
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pedido.Id = dr.GetInt32(0);
                    pedido.DataPed = dr.GetDateTime(1);
                    pedido.Status = dr.GetString(2);
                    pedido.Desconto = dr.GetDouble(3);
                    pedido.Cliente = Cliente.ConsultarPorId(dr.GetInt32(4));
                    pedido.Usuario = Usuario.ObterPorId(dr.GetInt32(5));
                    pedido.Itens = ItemPedido.ListarItens(dr.GetInt32(0));
                    pedidos.Add(pedido);
                }
                return pedidos;
            }


        }




    }//Fim da Classe Pedido
}
