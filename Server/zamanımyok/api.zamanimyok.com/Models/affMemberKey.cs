//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace api.zamanimyok.com.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class affMemberKey
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public affMemberKey()
        {
            this.affMemberDetails = new HashSet<affMemberDetail>();
        }
    
        public int PK { get; set; }
        public Nullable<int> MemberFK { get; set; }
        public string Value { get; set; }
        public string Extras { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime RemovalDate { get; set; }
        public string RemovedBy { get; set; }
        public bool Present { get; set; }
    
        public virtual affMember affMember { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<affMemberDetail> affMemberDetails { get; set; }
    }
}
