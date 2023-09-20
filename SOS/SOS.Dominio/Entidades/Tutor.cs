using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.Dominio.Entidades
{
    public class Class1
    {
        public int TutorID { get; set; }
        public string? CPF { get; set; }
        public string? NomeCompleto { get; set; }
        public int EnderecoID { get; set; }
        public List<Telefone> Telefone { get; set; }
    }
}
