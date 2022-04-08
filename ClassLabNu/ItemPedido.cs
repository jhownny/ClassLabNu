using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public class ItemPedido
    {
        //idped_ip idprod-ip     valor quantidade desconto
        //Atributos
        private Pedido pedido;
        private double valor;
        private double Quantidade;
        private double Desconto;


        public Produto Pedido { get { return Pedido; } set { pedido = value;  } }
        public double quantidade { get { return Quantidade; } set { Quantidade = value; } } 
        public double desconto { get { return Desconto; } set { Desconto = value; } }
        public double Valor { get { return Valor; } set { Valor = value; } }

        public ItemPedido()





    }
}
