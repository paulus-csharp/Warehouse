using System;
using System.Xml;

namespace Warehouse;

class Program
{
    public const string FILE_NAME = "/home/paulus/RiderProjects/Warehouse/Warehouse/data/ImportFile.xlsx";
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to warehouse app!");
        Console.WriteLine("Please let me know what you want to do:");
        Console.WriteLine("1. Add Item");
        Console.WriteLine("2. Remove Item");
        Console.WriteLine("3. Check Item");
        Console.WriteLine("Press 1, 2 or 3...");
            
        string operation = Console.ReadLine();
            
        Console.WriteLine($"You have chosen option number: {operation}");

        int chosenOperation = 0;

        Int32.TryParse(operation, out chosenOperation);

        Console.WriteLine("Select item category:");
        Console.WriteLine("1. Grocery");
        Console.WriteLine("2. Clothing");
        Console.WriteLine("3. Electronics");

        string category = Console.ReadLine();

        Helpers.ItemType chosenCategory;
        
        Enum.TryParse(category, out chosenCategory);
        Helpers.ItemService itemService = new Helpers.ItemService();
        

        // switch (chosenOperation)
        // {
        //     case 1:
        //         itemService.AddItem();
        //         break;
        //     case 2:
        //         itemService.RemoveItem();
        //         break;
        //     default:
        //         //np wyrzucić wyjątek z informacją o błędnym wyborze
        //         break;
        // }

        // if (chosenOperation == 1)
        // {
        //     Item item = new Item() { Id = 4, Name = "Strawberry" };
        //     item.CategoryId = chosenCategory == Helpers.ItemType.Grocery ? 1 : 2;
        // }

        // if (chosenOperation == 1)
        // {
        //     //Operacje zwiazane z dodawaniem dowego produktu
        //     Item = new Item() { Id = 2, Name = "Strawberry" };
        // }
        // else if (chosenOperation == 2)
        // {
        //     //Operacje zwiazane z usuwaniem istniejacego produktu
        //     
        // }
        // else if (chosenOperation = 3)
        // {
        //     //Inne operacje
        // }
        // else 
        // {
        //     //Operacja jeżeli żaden warunek nie został spełniony
        // }
        

        // int a = 5;
        // int b = a;
        //
        // Console.WriteLine(a); //wyświetli 5
        // Console.WriteLine(b); //wyswietli 5
        //
        // b = 50;
        //
        // Console.WriteLine(a); //wyświetli 5
        // Console.WriteLine(b); //wyswietli 50
        //
        // Item item = new Item() { Id = 1, Name = "Apple" };
        // Item item2 = item; // nie przydzielamy nowego obiektu tylko przypisujemy do zmiennej item2 referencję (adres na stercie) zmiennej item
        //
        // Console.WriteLine(item.Name); //wyświetli Apple
        // Console.WriteLine(item2.Name); //wyświetli Apple
        //
        // item2.Name = "Watermelon";
        //
        // Console.WriteLine(item.Name); //wyświetli Apple
        // Console.WriteLine(item2.Name); //wyświetli Apple

        // string str = "Napisy o tak naprawdę dowolnej długości";
        //     
        // Console.Write("Select item category: \r\n 1. Grocery \r\n 2. Clothing \r\n 3. Electronics \r\n");
        // Console.WriteLine($"To jest backslash {str}, {chosenCategory}");
    }
}