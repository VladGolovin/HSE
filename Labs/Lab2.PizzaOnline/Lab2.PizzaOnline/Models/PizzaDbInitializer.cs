using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.PizzaOnline.Models
{
    using System.Data.Entity;

    public class PizzaDbInitializer: DropCreateDatabaseAlways<PizzaContext>
    {
        protected override void Seed(PizzaContext db)
        {

            db.Pizzas.Add(new Pizza { Name = "Пепперони", Description = "Cыры Моцарелла и Пармезан, шампиньоны, бекон, колбаса пепперони, помидоры, куриная грудка, чеснок, лук красный, зелень.", Price = 220, ImagePath = "~/Content/Images/peperoni350x220.png" });

            db.Pizzas.Add(new Pizza { Name = "Маргарита", Description = "Cыр Моцарелла, помидоры, бекон, колбаса пепперони, помидоры, куриная грудка, чеснок, лук красный, зелень.", Price = 200, ImagePath = "~/Content/Images/margarita_350x220.png" });

            db.Pizzas.Add(new Pizza { Name = "Гавайская", Description = "Cыр Моцарелла, ветчина, ананасы, бекон, колбаса пепперони, помидоры, куриная грудка, чеснок, лук красный, зелень.", Price = 200, ImagePath = "~/Content/Images/gavai350x220.png" });

            db.Pizzas.Add(new Pizza { Name = "Дракон", Description = "Состав:  пицца-соус, сыры, бекон, колбаса пепперони, помидоры, куриная грудка, чеснок, лук красный, зелень.", Price = 490, ImagePath = "~/Content/Images/dragon350x220.png" });

            db.Pizzas.Add(new Pizza { Name = "Нью-Йорк", Description = "Пицца-соус, сладкий перец, бекон, колбаса пепперони, помидоры, куриная грудка, чеснок, лук красный, зелень..", Price = 500, ImagePath = "~/Content/Images/new-york350x220.png" });

            db.Pizzas.Add(new Pizza { Name = "Домашняя", Description = "Состав:  пицца-соус, сыры, бекон, колбаса пепперони, помидоры, куриная грудка, чеснок, лук красный, зелень.", Price = 200, ImagePath = "~/Content/Images/home350x220.png" });

            base.Seed(db);
        }
    }
}