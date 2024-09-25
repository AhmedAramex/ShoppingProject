//using CleanArchitectureCQRs.Domain.Entites;
//using CleanArchitectureCQRs.Infrastructure.Context;
//using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http.Json;
//using System.Text;
//using System.Text.Json.Serialization;
//using System.Threading.Tasks;

//namespace CleanArchitectureCQRs.Infrastructure.Seeding;

//public class DataSeeding
//{
//    public static async Task dataseeding(ApplicationDbContext context, string userName)
//    {

//        //using (StreamReader r = new StreamReader(@"Z:\CQRS Project\CQRS Project\CleanArchitectureCQRs.Infrastructure\Seeding\Users.json"))
//        //{
//        //    string usersJson = r.ReadToEnd();
//        //List<Users> usersList = JsonConvert.DeserializeObject<List<Users>>(usersJson);
//        //    context.users.AddRange(usersList);
//        //    context.SaveChanges();
//        //}


//        if (!context.Wishlists.ToList().Any())
//        {

//            using (StreamReader r = new StreamReader(@$"C:\Users\{userName}\source\repos\ShoppingProject\CleanArchitectureCQRs.Infrastructure\Seeding\WishList.json"))
//            {
//                string wishListJson = r.ReadToEnd();
//                List<Wishlist> wishListItems = JsonConvert.DeserializeObject<List<Wishlist>>(wishListJson);
//                List<Wishlist> wish = [new Wishlist
//                {
//                    Id = new Guid("f64b9b84-02f8-4f57-b9b2-57d0c8a78d3f"),
//                    UsersId = new Guid("4ad65545-897a-4160-a29c-08dcd5abe2dd")
//                }];
//                context.Wishlists.AddRange(wishListItems);
//                context.SaveChanges();
//            }
//        }


//        if (!context.Categories.ToList().Any())
//        {
//            using (StreamReader r = new StreamReader(@$"C:\Users\{userName}\source\repos\ShoppingProject\CleanArchitectureCQRs.Infrastructure\Seeding\Category.json"))
//            {
//                string CategoryJson = r.ReadToEnd();
//                List<Category> CategoryList = JsonConvert.DeserializeObject<List<Category>>(CategoryJson);
//                context.Categories.AddRange(CategoryList);
//                context.SaveChanges();
//            }
//        }

//        using (StreamReader r = new StreamReader(@$"C:\Users\{userName}\source\repos\ShoppingProject\CleanArchitectureCQRs.Infrastructure\Seeding\products.json"))
//        {
//            string productsJson = r.ReadToEnd();
//            List<Product> productsList = JsonConvert.DeserializeObject<List<Product>>(productsJson);
//            context.Products.AddRange(productsList);
//            context.SaveChanges();
//        }
//    }
//}
