using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolRepository.Models
{
    public class StudentViewModel
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Nombre")]
        [StringLength(60,
            ErrorMessage = "El campo {0} requiere como maximo {1} y minimo {2} caracteres",
            MinimumLength = 5)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Apellidos")]
        [StringLength(60, 
            ErrorMessage ="El campo {0} requiere como maximo {1} y minimo {2} caracteres",
            MinimumLength = 5)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Fecha de inscripcion")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
    }
}