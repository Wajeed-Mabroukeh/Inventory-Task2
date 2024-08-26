
using Inventory;

class Programs
{
    public static void Main()
    {
        Inventory.Inventory I1 = new Inventory.Inventory();
        while (true)
        {
            Console.WriteLine("Welcome To my Inventory -_- \n" +
                              "1.Add a product\n" +
                              "2.View all products\n" +
                              "3.Edit a product\n" +
                              "4.Delete a product\n" +
                              "5.Search for a product\n" +
                              "6.Exit");
            try
            {
                int? num = (int)Int64.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Please Enter Name,Price,Quantity For Product");
                        string? input_product = Console.ReadLine();
                        string?[] product = input_product.Split(',');
                        Product p = new Product(product[0], double.Parse(product[1]), (int)Int64.Parse(product[2]));
                        I1.Add_a_product(p);
                        break;
                    case 2:
                        I1.View_all_products();
                        break;
                    case 3:
                        Console.WriteLine("Please enter the product name you want to edit");
                        string? name_product = Console.ReadLine();
                        Product? pr_Result_Search_E = I1.Search_With_name(name_product);
                        if (!(pr_Result_Search_E == null))
                        {
                            Console.WriteLine(
                                "Please enter the  product Edit Name and Price and Quantity you want to edit");
                            string? input_product_Edit = Console.ReadLine();
                            string?[] product_Edit = input_product_Edit.Split(',');
                            I1.Edit_a_product(pr_Result_Search_E, product_Edit[0], double.Parse(product_Edit[1])
                                , (int)Int64.Parse(product_Edit[2]));
                        }

                        break;
                    case 4:
                        Console.WriteLine("Please enter the product name you want to edit");
                        string? name_product_D = Console.ReadLine();
                        Product? pr_Result_Search_D = I1.Search_With_name(name_product_D);
                        if (!(pr_Result_Search_D == null))
                        {
                            I1.Delete_a_product(pr_Result_Search_D);
                        }

                        break;
                    case 5:
                        Console.WriteLine("Please enter the product name you want to edit");
                        string? name_product_S = Console.ReadLine();
                        Product? pr_Result_Search_S = I1.Search_With_name(name_product_S);
                        if (!(pr_Result_Search_S == null))
                        {
                            I1.Search_for_a_product(pr_Result_Search_S);
                        }

                        break;

                    case 6:
                        return;
                        break;
                }
            }
            catch (Exception e)
            {
               Console.WriteLine("You entered an Error"); 
            }
        }
    }
}