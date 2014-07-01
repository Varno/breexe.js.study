namespace Todo.Models
{
    using System.Data.Entity;
    using Todo.Models.Entities;

    public class TodosContext : DbContext 
    {
        // DEVELOPMENT ONLY: initialize the database
        static TodosContext()
        {
            Database.SetInitializer(new TodoDatabaseInitializer());
        }

        public DbSet<TodoItem> Todos { get; set; }
        // public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Region> Regions { get; set; }
        //public DbSet<Role> Roles { get; set; }
        //public DbSet<Supplier> Suppliers { get; set; }
        //public DbSet<Territory> Territories { get; set; }
        //public DbSet<User> Users { get; set; }
    }
}