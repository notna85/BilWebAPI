//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BilWebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class event_creations
    {
        public int id { get; set; }
        public int event_id { get; set; }
        public string user_registration_no { get; set; }
        public System.DateTime time { get; set; }
    
        public virtual @event @event { get; set; }
        public virtual user user { get; set; }
    }
}
