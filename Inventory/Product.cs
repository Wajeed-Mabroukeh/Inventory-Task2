namespace Inventory;

public class Product
{
    public string name { get; private set; }
    public double price { get; private set; }
    public int quantity { get; private set; }

    public Product(string name ,double price , int quantity )
    {
        this.price = price;
        this.name = name;
        this.quantity = quantity;
    }
}