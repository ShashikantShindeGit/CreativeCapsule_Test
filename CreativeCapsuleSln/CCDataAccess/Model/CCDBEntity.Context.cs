//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CCDataAccess.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CreativeCapsuleDBEntities : DbContext
    {
        public CreativeCapsuleDBEntities()
            : base("name=CreativeCapsuleDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<DiscountOffer> DiscountOffers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
