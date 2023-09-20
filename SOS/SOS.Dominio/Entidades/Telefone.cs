using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.Dominio.Entidades
{
    public class Telefone
    {
        public int DDD { get; set; }
        public int Numero { get; set; }
        /// <summary>
        /// RAMAL, RECADO, CELULAR
        /// </summary>
        public string? Tipo { get; set; }

    }
}
