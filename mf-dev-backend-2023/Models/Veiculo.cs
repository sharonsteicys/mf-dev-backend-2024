﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace mf_dev_backend_2023.Models
{

    [Table("Veiculos")]

    public class Veiculo
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Placa!")]

        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano da Fabricação!")]
        [Display(Name ="Ano de Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano do Modelo!")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }
    }
}
