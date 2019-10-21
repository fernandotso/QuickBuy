using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario: Entidade
    {

        public int id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Naome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// Um usuário pode ter nenhum ou muitos pedidos 
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
