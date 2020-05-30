using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NovaSolucao.Dominio
{
    public class Car
    {
        public int Id { get; set; }


        [DisplayName("Marca")]
        [Required]
        public string Marca { get; set; }



        [DisplayName("Modelo")]
        [Required]
        public string Modelo { get; set; }

        [DisplayName("Versao")]
        [Required]
        public string Versao { get; set; }

        [DisplayName("Ano")]
        [Required]
        public int Ano { get; set; }

        [DisplayName("Quilomtragem")]
        [Required]
        public int Quilomtragem { get; set; }

        [DisplayName("Observacao")]
        [Required]
        public string Observacao { get; set; }


    }
}
