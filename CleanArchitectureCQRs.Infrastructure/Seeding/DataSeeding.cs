using CleanArchitectureCQRs.Domain.Entites;
using CleanArchitectureCQRs.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Infrastructure.Seeding;

public class DataSeeding
{
    public static async Task dataseeding(ApplicationDbContext context)
    {

        //using (StreamReader r = new StreamReader(@"Z:\CQRS Project\CQRS Project\CleanArchitectureCQRs.Infrastructure\Seeding\Users.json"))
        //{
        //    string usersJson = r.ReadToEnd();
        //List<Users> usersList = JsonConvert.DeserializeObject<List<Users>>(usersJson);
        //    context.users.AddRange(usersList);
        //    context.SaveChanges();
        //}


        if (context.wishLists == null)
        {

            using (StreamReader r = new StreamReader(@"Z:\CQRS Project\CQRS Project\CleanArchitectureCQRs.Infrastructure\Seeding\WishList.json"))
            {
                string wishListJson = r.ReadToEnd();
                List<WishList> wishListItems = JsonConvert.DeserializeObject<List<WishList>>(wishListJson);
                context.wishLists.AddRange(wishListItems);
                context.SaveChanges();
            }
        }


        if (context.categories == null)
        {
            using (StreamReader r = new StreamReader(@"Z:\CQRS Project\CQRS Project\CleanArchitectureCQRs.Infrastructure\Seeding\Category.json"))
            {
                string CategoryJson = r.ReadToEnd();
                List<Category> CategoryList = JsonConvert.DeserializeObject<List<Category>>(CategoryJson);
                context.categories.AddRange(CategoryList);
                context.SaveChanges();
            }
        }

        using (StreamReader r = new StreamReader(@"Z:\CQRS Project\CQRS Project\CleanArchitectureCQRs.Infrastructure\Seeding\Products.json"))
        {
            string productsJson = r.ReadToEnd();
            List<Product> productsList = JsonConvert.DeserializeObject<List<Product>>(productsJson);
            context.products.AddRange(productsList);
            context.SaveChanges();
        }

    }
}
