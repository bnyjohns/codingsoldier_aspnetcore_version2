//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodingSoldier.Core.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Study : IModel
    {
        public int Id { get; set; }
        public string StudyHeader { get; set; }
        public string StudyContent { get; set; }
        public string CategoryName { get; set; }
        public virtual Category Category { get; set; }
    }
}