//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobPost
    {
        public int JobPostId { get; set; }
        public Nullable<int> PosterId { get; set; }
        public string JobDescription { get; set; }
        public string RequiredSkills { get; set; }
        public string SalaryRange { get; set; }
        public string OperationHours { get; set; }
        public string Location { get; set; }
    
        public virtual JinderUser JinderUser { get; set; }
    }
}
