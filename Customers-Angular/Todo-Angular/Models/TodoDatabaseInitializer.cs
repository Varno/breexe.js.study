using System;
using System.Data.Entity;
using System.Linq;
using Todo.Models.Entities;

namespace Todo.Models
{
    public class TodoDatabaseInitializer: DropCreateDatabaseIfModelChanges<TodosContext>
    {
        protected override void Seed(TodosContext context)
        {
            SeedDatabase(context);
        }

        public static void SeedDatabase(TodosContext context)
        {
            Enumerable.Range(1, 50)
                .ToList()
                .ForEach(a => context.Customers.Add(CreateItem()));

            context.SaveChanges(); // Save 'em
        }

        private static Customer CreateItem()
        {
            return new Customer()
            {
                CustomerID = Guid.NewGuid(),
                CompanyName = "company1",
                ContactName = "contact",
                ContactTitle = "title",
                Address = "address",
                City = "city",
                Region = "region",
                PostalCode = "почтовый индекс",
                Country = "страна",
                Phone = "телефон"
            };
        }

        public static void PurgeDatabase(TodosContext context)
        {
            var todos = context.Todos;
            foreach (var todoItem in todos)
            {
                todos.Remove(todoItem);
            }

            context.SaveChanges();
        }

    }


}