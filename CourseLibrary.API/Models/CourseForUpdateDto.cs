using CourseLibrary.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.Models
{

    public class CourseForUpdateDto : CourseForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out a description.")]
        public override string Description { get => base.Description; set => base.Description = value; }
    }
}
