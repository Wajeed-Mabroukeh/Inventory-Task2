namespace Inventory;

public class Product
{
    private string name { get; set; }
    private double price { get; set; }
    private int quantity { get; set; }

    Product(string name ,double price , int quantity )
    {
        this.price = price;
        this.name = name;
        this.quantity = quantity;
    }
}