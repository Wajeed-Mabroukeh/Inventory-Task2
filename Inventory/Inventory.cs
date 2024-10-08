﻿namespace Inventory;
public class Inventory
{
    private  List<Product> product = new List<Product>();

    public void Add_a_product(Product product )
    {
        this.product.Add(product);
        Console.WriteLine("Successful Add Product ");
    }
   
    public void View_all_products()
    {
        if (product.Count != 0)
        {
            foreach (Product pr in product)
            {
                Console.WriteLine($"Name Product : {pr.name} , Price Product : {pr.price} , Quantity : {pr.quantity}");
            }
        }
        else
        {
            Console.WriteLine("The List of Product is Empty");
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

    public void Delete_a_product(Product pr_Delete)
    {
        string name = pr_Delete.name;
        product.Remove(pr_Delete);
        Console.WriteLine($"Successful Delete Product {name}");
    }

    public void Search_for_a_product(Product pr_disaply)
    {
        Console.WriteLine($"The Result Search is "+
                          $"Name product ({pr_disaply.name})" +
                          $", Price Product ({pr_disaply.price}) ," +
                          $" Quantity Product ({pr_disaply.quantity})");
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
        Console.WriteLine(pr_test == null ? "The value is not Exit" : "");
        return null;
    }


   


}