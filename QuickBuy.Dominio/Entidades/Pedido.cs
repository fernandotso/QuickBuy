﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        
        /// <summary>
        /// Pedido deve ter pelo menos um pedio ou muitos pedidos
        /// </summary>
        public ICollection<ItemPedido> ItemPedidos { get; set; }
    }
}
