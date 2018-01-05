namespace Insurance.Data.Common
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class InsuranceDbContext : DbContext
    {
        // Your context has been configured to use a 'InsuranceDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Insurance.Data.Common.InsuranceDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'InsuranceDbContext' 
        // connection string in the application configuration file.
        public InsuranceDbContext()
            : base("name=InsuranceDbContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Orders> OrderDetails { get; set; }
        public virtual DbSet<OrderCategory> OrderCategories { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}