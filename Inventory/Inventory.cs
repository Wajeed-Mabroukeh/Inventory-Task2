namespace Inventory;



public class Inventory
{
    private  List<Product> product = new List<Product>();

    public void Add_a_product(Product product )
    {
        this.product.Add(product);
    }
   
    public void View_all_products()
    {
        foreach (Product pr in product)
        {
            Console.WriteLine($"Name Product : {pr.name} , Price Product : {pr.price} , Quantity : {pr.quantity}");
        }
    }

    public void Edit_a_product(Product pr_new ,string name ,double price , int quantity )
    {
        string name_old = pr_new.name;
        double price_old = pr_new.price;
        int quantity_old = pr_new.quantity;
        
        pr_new.name = name;
        pr_new.price = price;
        pr_new.quantity = quantity;
        Console.WriteLine($"Successful Edit on Product old {name_old}, {price_old},{quantity_old} to Product new {pr_new.name},{pr_new.price},{pr_new.quantity} ");
    }

    public Product Search_With_name(string name)
    {
        Product? pr_test = null;
        foreach (Product pr in product)
        {
            if (pr.name.Trim() == name.Trim())
            {
                pr_test = pr;
                return pr;
            }
        }
        Console.WriteLine(pr_test == null ? "The value is not Exit" : "jj");
        return null;
    }




}