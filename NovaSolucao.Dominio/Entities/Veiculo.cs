using System;
using System.Collections.Generic;
using System.Text;

namespace NovaSolucao.Dominio.Entities
{
    class Veiculo
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Versao { get; set; }
        public string Imagem { get; set; }
        public string KM { get; set; }
        public double preco { get; set; }
        public int AnoModelo { get; set; }
        public int AnoFabricao { get; set; }
        public string Cor { get; set; }
    }
}
