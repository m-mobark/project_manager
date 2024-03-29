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
    
    public partial class pm_project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pm_project()
        {
            this.pm_projectTeam = new HashSet<pm_projectTeam>();
            this.pm_projectComments = new HashSet<pm_projectComments>();
        }
    
        public int id { get; set; }
        public string title { get; set; }
        public string p_description { get; set; }
        public Nullable<int> admin_approved { get; set; }
        public Nullable<int> project_manger_id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public Nullable<int> p_state { get; set; }
        public Nullable<int> price { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
    
        public virtual pm_User pm_User { get; set; }
        public virtual pm_User pm_User1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pm_projectTeam> pm_projectTeam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pm_projectComments> pm_projectComments { get; set; }
    }
}
