//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projects_management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class pm_projectComments
    {
        public int id { get; set; }
        public Nullable<int> project_id { get; set; }
        public Nullable<int> member_id { get; set; }
        public string comment { get; set; }
    
        public virtual pm_project pm_project { get; set; }
        public virtual pm_User pm_User { get; set; }
    }
}
