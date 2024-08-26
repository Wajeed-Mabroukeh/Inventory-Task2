namespace Inventory;



public class Inventory
{
    private  List<Product> product = new List<Product>();

    public void Add_a_product(Product product )
    {
        this.product.Add(product);
       // Console.WriteLine(product.name);
    }
   
    public void View_all_products()
    {
        foreach (Product pr in product)
        {
            Console.WriteLine($"Name Product : {pr.name} , Price Product : {pr.price} , Quantity : {pr.quantity}");
        }
    }
    




}