using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dto
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "O Campo titulo é obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Campo Diretor é obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O genero não poderá conter mais de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A Duração deverá ser entre 1 e no maxximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
