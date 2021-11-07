using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoiSaudeWebApplication.Models
{
    public class Words
    {   
        //criação do modelo da tabela
        [Key]
        public int WordsId { get; set; }
        [Column(TypeName="varchar(50)")]
        [Required(ErrorMessage="Preenchimento obrigatório")]
        [DisplayName("Descrição")]
        public string Description { get; set; }
    }
}
