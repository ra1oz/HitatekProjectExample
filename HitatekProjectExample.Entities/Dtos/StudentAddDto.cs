using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitatekProjectExample.Entities.Dtos
{
    public class StudentAddDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Ögrenci Adı")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]
        public string Adi { get; set; }

        [DisplayName("Ögrenci Soyadı")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]        
        public string Soyadi { get; set; }

        [DisplayName("Ögrenci Ortalaması")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]       
        public int NotOrtalamasi { get; set; }
    }
}
