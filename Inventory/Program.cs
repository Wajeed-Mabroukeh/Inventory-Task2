
using Inventory;

class Programs
{
    public static void Main()
    {
        Product p1 = new Product("Chocolate", 20.0 , 55);
        Product p2 = new Product("Jus", 30.0 , 20);
        Product p3 = new Product("Milk", 10.5 , 10);

        Inventory.Inventory I1 = new Inventory.Inventory();
        
        I1.Add_a_product(p1);
        I1.Add_a_product(p1);
        I1.Add_a_product(p1);
        
        I1.View_all_products();
        
       // Console.WriteLine("d");
    }
}