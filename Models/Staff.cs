//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.Inventories = new HashSet<Inventory>();
            this.MedCheckHeaders = new HashSet<MedCheckHeader>();
        }
    
        [Required(ErrorMessage = "ID field is required")]
        public string StaffID { get; set; }
        public string StaffLast { get; set; }
        public string StaffFirst { get; set; }
        public string StaffMid { get; set; }
        public Nullable<int> StaffGender { get; set; }
        [Required(ErrorMessage = "Password field is required")]
        public string StaffPassword { get; set; }
        public string StaffJoinedDate { get; set; }
        public Nullable<int> StaffType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedCheckHeader> MedCheckHeaders { get; set; }
    }
}
