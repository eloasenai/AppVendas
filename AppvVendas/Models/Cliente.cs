﻿using System.Data;

namespace AppvVendas.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string ClienteName { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public bool CadastroAtivo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
