//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaPro
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CinemaProEntities2 : DbContext
    {
        public CinemaProEntities2()
            : base("name=CinemaProEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AgeCategory_ID> AgeCategory_ID { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<FilmCompany> FilmCompany { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Hall> Hall { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<Сountry> Сountry { get; set; }
    }
}
