using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class UpdateFilmeDto
    {
     
        [Required(ErrorMessage = "O Titulo é obrigatório")]
        [MinLength(2, ErrorMessage = "O Titulo deve ter pelo menos 2 caracteres")]
        [MaxLength(50, ErrorMessage = "O Gênero não pode conter mais de 50 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O Gênero é obrigatório")]
        [StringLength(50, ErrorMessage = "O Gênero não pode conter mais de 50 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "A Duração é obrigatório")]
        [Range(70, 600, ErrorMessage = "A Duração deve ter entre 70 e 600 minutos")]
        public int Duracao { get; set; }

        [Required(ErrorMessage = "O Diretor é obrigatório")]
        [MinLength(2, ErrorMessage = "O Diretor deve ter pelo menos 2 caracteres")]
        [MaxLength(50, ErrorMessage = "O Diretor não pode conter mais de 50 caracteres")]
        public string Diretor { get; set; }
    }
}
