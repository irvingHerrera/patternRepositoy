//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolRepository.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enrollment
    {
        public int EnrollmentId { get; set; }
        public string Grade { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
