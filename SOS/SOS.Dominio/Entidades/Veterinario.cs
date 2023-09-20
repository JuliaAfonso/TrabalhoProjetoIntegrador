using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.Dominio.Entidades
{
    public class Veterinario
    {
        public int VeterinarioID { get; set; }
        public string? CPF { get; set; }
        public string? NomeCompleto { get; set; }
        public string? CRMV { get; set; }
        public List<Telefone> Telefone { get; set; }
    }
}
