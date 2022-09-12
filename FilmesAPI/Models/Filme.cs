﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage ="Gênero não deve ultrapassar 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "Duração deve ser entre 1 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
