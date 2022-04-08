using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string status { get; set; }
        public double desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public List<ItemPedido> Itens { get; set; }

        //Construtores
        public Pedido() { }

        public Pedido(DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {
            DataPed = dataPed;
            this.status = status;
            this.desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }

        public Pedido(int id, DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {
            Id = id;
            DataPed = dataPed;
            this.status = status;
            this.desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }

        //Métodos da Classe - Operações/Açoes/Funções
        public void Inserir() { }
        public bool Alterar (Pedido pedido)
        {
            return false;
        }

        public static List<Pedido> ConsultarPorClienteId(int id)
        {
            List<Pedido> pedido = new List<Pedido>();
            //conecta ao banco e realiza a consulta pelo id do pedido
            return pedido;
        }




    }
}
