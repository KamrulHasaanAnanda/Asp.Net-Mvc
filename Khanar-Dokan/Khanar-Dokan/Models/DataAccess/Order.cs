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

    public partial class Order
    {
        [Key]
        public int oId { get; set; }

        public int hId { get; set; }

        public int uId { get; set; }

        public string oStatus { get; set; }
    
        public virtual History History { get; set; }
        public virtual User User { get; set; }
    }
}
