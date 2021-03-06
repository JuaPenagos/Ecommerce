﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Department
    {

        [Key]
        public int DepartmentId { get; set; }

        [Required (ErrorMessage= "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage ="El campo {0} debe tener maximo {1} caracteres")]
        [Display (Name="Departamento")]
        public String Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}