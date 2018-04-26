namespace Lab2.PizzaOnline.Models
{
    using System.Data.Entity;

    public class PizzaContext: DbContext
    {
        public DbSet<Pizza> Pizzas { get; set; }
    }
}