//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdeaPath.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Idea
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int StatusId { get; set; }
        public int TypeId { get; set; }
        public string Text { get; set; }
    
        public virtual Status Status { get; set; }
        public virtual Task Task { get; set; }
        public virtual Type Type { get; set; }
    }
}
