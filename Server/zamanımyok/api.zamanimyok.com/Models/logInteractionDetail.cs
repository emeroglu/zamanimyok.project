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
    
    public partial class logInteractionDetail
    {
        public int PK { get; set; }
        public Nullable<int> InteractionFK { get; set; }
        public Nullable<int> KeyFK { get; set; }
        public string Value { get; set; }
        public string Extras { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime RemovalDate { get; set; }
        public string RemovedBy { get; set; }
        public bool Present { get; set; }
    
        public virtual logInteraction logInteraction { get; set; }
        public virtual logInteractionKey logInteractionKey { get; set; }
    }
}
