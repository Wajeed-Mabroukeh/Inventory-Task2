
using Inventory;

class Programs
{
    public static void Main()
    {
        Product p1 = new Product("Jus", 20.0 , 2);
        Product p2 = new Product("Jus", 20.0 , 2);
        Product p3 = new Product("Jus", 20.0 , 2);

        Inventory.Inventory I1 = new Inventory.Inventory();
        
        I1.Add_a_product(p1);
        I1.Add_a_product(p1);
        I1.Add_a_product(p1);
        
        
        
       // Console.WriteLine("d");
    }
}