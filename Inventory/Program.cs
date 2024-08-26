
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
        I1.Add_a_product(p2);
        I1.Add_a_product(p3);
        
        I1.View_all_products();

        string name = "Shhh";
        double price =90;
        int quantity = 1;

        Product? pr_Result_Search = I1.Search_With_name("Milk;");
        if (!(pr_Result_Search == null))
        {
            I1.Edit_a_product(pr_Result_Search,name,price,quantity);
        }
        I1.View_all_products();
        
       // Console.WriteLine("d");
    }
}