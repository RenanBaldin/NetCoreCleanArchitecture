using System.ComponentModel.DataAnnotations;

namespace testeef.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }        
        
        [Required(ErrorMessage="Este campo é obrigatório")]
        [MaxLength(60,ErrorMessage="este campo deve cobter entre 3 e 60 caracteres")]
        [MinLength(60,ErrorMessage="este campo deve cobter entre 3 e 60 caracteres")]
        public string Title { get; set; }

        
        
    }
}