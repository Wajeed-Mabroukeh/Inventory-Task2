namespace Inventory;

public class Product
{
    public string name { get; internal set; }
    public double price { get; internal set; }
    public int quantity { get; internal set; }

    public Product(string name ,double price , int quantity )
    {
        this.price = price;
        this.name = name;
        this.quantity = quantity;
    }
}