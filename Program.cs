using EntityFrameworkCase;

Console.WriteLine("Change operation");
Console.WriteLine("1) Show product");
Console.WriteLine("2) Add product");
Console.WriteLine("3) Delete product");
Console.WriteLine("4) Update product");
var userChoice = Console.ReadLine();
if (userChoice == "1")
{
    ProductService productService = new ProductService();
    Console.WriteLine("Write id Product");
    int productId = Convert.ToInt32(Console.ReadLine());
    productService.ShowProduct(productId);
}
if(userChoice == "2")
{
    ProductService productService = new ProductService();
    Product productToAdd = new Product();
    Console.WriteLine("Write Name and Price");
    productToAdd.Name = Console.ReadLine();
    productToAdd.Price = Convert.ToInt32(Console.ReadLine());
    productService.Add(productToAdd);
}
if(userChoice == "3")
{
    ProductService productService = new ProductService();
    Console.WriteLine("Write ID product to Delete");
    int productToDelete = Convert.ToInt32(Console.ReadLine());
    productService.Delete(productToDelete);
}
if(userChoice == "4")
{
    ProductService productService = new ProductService();
    Product productToUpdate = new Product();
    Console.WriteLine("Write ID, Name and Price");
    productToUpdate.Id = Convert.ToInt32(Console.ReadLine());
    productToUpdate.Name = Console.ReadLine();
    productToUpdate.Price = Convert.ToInt32(Console.ReadLine());
    productService.Update(productToUpdate);
}






