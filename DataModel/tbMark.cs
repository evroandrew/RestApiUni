//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbMark
    {
        public int Id { get; set; }
        public int StudentsMark { get; set; }
        public Nullable<int> Student_Id { get; set; }
        public Nullable<int> TeachSubj_TeacherId { get; set; }
        public Nullable<int> TeachSubj_SubjId { get; set; }
    
        public virtual tbStudent tbStudent { get; set; }
        public virtual tbTeachSubj tbTeachSubj { get; set; }
    }
}
