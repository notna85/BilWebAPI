﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ComCarsEntities : DbContext
    {
        public ComCarsEntities()
            : base("name=ComCarsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<event_creations> event_creations { get; set; }
        public virtual DbSet<event_descriptions> event_descriptions { get; set; }
        public virtual DbSet<event_types> event_types { get; set; }
        public virtual DbSet<@event> events { get; set; }
        public virtual DbSet<user> users { get; set; }
    
        public virtual int create_event(Nullable<int> event_type_id, Nullable<decimal> lon, Nullable<decimal> lat, string user_registration_no)
        {
            var event_type_idParameter = event_type_id.HasValue ?
                new ObjectParameter("event_type_id", event_type_id) :
                new ObjectParameter("event_type_id", typeof(int));
    
            var lonParameter = lon.HasValue ?
                new ObjectParameter("lon", lon) :
                new ObjectParameter("lon", typeof(decimal));
    
            var latParameter = lat.HasValue ?
                new ObjectParameter("lat", lat) :
                new ObjectParameter("lat", typeof(decimal));
    
            var user_registration_noParameter = user_registration_no != null ?
                new ObjectParameter("user_registration_no", user_registration_no) :
                new ObjectParameter("user_registration_no", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("create_event", event_type_idParameter, lonParameter, latParameter, user_registration_noParameter);
        }
    
        public virtual int CreateEventInfo(Nullable<int> event_type_id, Nullable<decimal> lon, Nullable<decimal> lat, string user_registration_no)
        {
            var event_type_idParameter = event_type_id.HasValue ?
                new ObjectParameter("event_type_id", event_type_id) :
                new ObjectParameter("event_type_id", typeof(int));
    
            var lonParameter = lon.HasValue ?
                new ObjectParameter("lon", lon) :
                new ObjectParameter("lon", typeof(decimal));
    
            var latParameter = lat.HasValue ?
                new ObjectParameter("lat", lat) :
                new ObjectParameter("lat", typeof(decimal));
    
            var user_registration_noParameter = user_registration_no != null ?
                new ObjectParameter("user_registration_no", user_registration_no) :
                new ObjectParameter("user_registration_no", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateEventInfo", event_type_idParameter, lonParameter, latParameter, user_registration_noParameter);
        }
    }
}
