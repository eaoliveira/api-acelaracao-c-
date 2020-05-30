using System;
using System.Collections.Generic;
using System.Text;
    
namespace NovaSolucao.Dominio.Entities
{
    class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Modelo> Modelos { get; set; }
    }
}
