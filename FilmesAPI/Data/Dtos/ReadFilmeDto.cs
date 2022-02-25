using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class ReadFilmeDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Titulo é obrigatório.")]
        public string Titulo { get; set; }

        [StringLength(30, ErrorMessage = "O campo Gênero não pode ultrapassar 30 caracteres.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo Diretor é obrigatório")]
        public string Diretor { get; set; }

        [Range(1, 200, ErrorMessage = "A Duração deve ter no mínimo 1 e no máximo 200 minutos.")]
        public int Duracao { get; set; }

        public DateTime HoraDaConsulta { get; set; }
    }
}
