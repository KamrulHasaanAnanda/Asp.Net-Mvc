//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Khanar_Dokan.Models.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        [Key]
        public int eid { get; set; }

        public int uid { get; set; }

        [Required]
        public string etype { get; set; }

        [Required]
        public decimal esalary { get; set; }
    
        public virtual User User { get; set; }
    }
}
