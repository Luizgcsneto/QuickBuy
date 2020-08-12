using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }

        public String Email { get; set; }

        public String Senha { get; set; }

        public String Nome { get; set; }

        public String SobreNome { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

    }
}
