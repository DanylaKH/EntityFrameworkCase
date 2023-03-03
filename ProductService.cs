using EntityFrameworkCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCase
{
    public class ProductService
    {
        ProductContext context = new ProductContext();
        public void Add(Product product)
        {
            if(product != null)
            {
                context.Product.Add(new Product {Name = product.Name, Price = product.Price });
                context.SaveChanges();
                Console.WriteLine("Successful Add");
            }
            else
            {
                Console.WriteLine("Add Error");
            }
            
        }
        public void Update(Product updatedProduct) 
        {
            var productToUpdate = context.Product.Attach(updatedProduct);
            if (productToUpdate != null)
            {
                productToUpdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                Console.WriteLine("Successfull Update");
            }
            else
                Console.WriteLine("Product to Update not found");
            
        }
        public void Delete(int id) 
        { 
            var productToDelete = context.Product.Where(x => x.Id == id).FirstOrDefault();
            if (productToDelete != null)
            {
                context.Product.Remove(productToDelete);
                context.SaveChanges();
                Console.WriteLine("Successfull delete");
            }
            else
                Console.WriteLine("Product to delete not Found");
        }          
        public void ShowProduct(int id) 
        {
            var productToShow = context.Product.Where(x => x.Id == id).FirstOrDefault();
            if (productToShow != null)
            {
                Console.WriteLine($"ID {productToShow.Id} Name {productToShow.Name} Price {productToShow.Price}");
            }
            else
                Console.WriteLine("Product not Found");
        }
    }
}



