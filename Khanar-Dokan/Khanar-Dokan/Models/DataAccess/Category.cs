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

    public partial class Category
    {
        [Key]
        public int catid { get; set; }

        public int fid { get; set; }

        public string catname { get; set; }
    
        public virtual FoodItem FoodItem { get; set; }
    }
}