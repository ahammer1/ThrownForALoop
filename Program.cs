// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Welcome to Thrown for a Loop!");\

// LESSON ON STRINGS +++++++++++++++++++++++++++++++++++++++

string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine(greeting);

Console.WriteLine("Please enter a product name: ");

// string response = Console.ReadLine();
// In order to explicitly tell the program to interpret the string as an int, we can use int.Parse, like this:
int response = int.Parse(Console.ReadLine().Trim());

// LESSON ON LOOPS AND CONDITIONS ++++++++++++++++++++++++++++++++++++++++

// if (string.IsNullOrWhiteSpace(response))
// {
//     Console.WriteLine("You didn't choose anything!");
// }
// else
// {
//     Console.WriteLine($"You chose: {response}");
// }

// ==================================================================

// while (string.IsNullOrEmpty(response))
// {
//     Console.WriteLine("You didn't choose anything, try again!");
//     response = Console.ReadLine();
// }

// Console.WriteLine($"You chose: {response}");

//==========WHILE LOOPS========================================

// while (string.IsNullOrEmpty(response))
// {
//     Console.WriteLine("You didn't choose anything, try again!");
//     response = Console.ReadLine().Trim();
// }

// Console.WriteLine($"You chose: {response}");

while (response > 5 || response < 1)
{
    Console.WriteLine("Choose a number between 1 and 5!");
    response = int.Parse(Console.ReadLine().Trim());
}

// SUBJECT ON INTEGERS ++++++++++++++++++++++++++++++

// Console.WriteLine(@"Products:
// 1. Football
// 2. Hockey Stick
// 3. Boomerang
// 4. Frisbee
// 5. Golf Putter");
// Console.WriteLine("Please enter a product number: ");

// SUBJECT ON LISTS +++++++++++++++++++++++++++++++++++

// List<string> products = new List<string>()
// {
//     "Football",
//     "Hockey Stick",
//     "Boomerang",
//     "Frisbee",
//     "Golf Putter"
// };

// CLASSES INTRO....
List<Product> products = new List<Product>()
{
    new Product()
    { 
        Name = "Football", 
        Price = 15, 
        Sold = false
    },
    new Product() 
    { 
        Name = "Hockey Stick", 
        Price = 12, 
        Sold = false
    }
};

Product chosenProduct = products[response - 1];
Console.WriteLine($"You chose: {chosenProduct.Name}, which costs {chosenProduct.Price} dollars and is {(chosenProduct.Sold ? "" : "not ")}sold.");


// LESSON OON DATE AND TIME ++++++++++++++++++++++++++++++++++
DateTime now = DateTime.Now;

TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old. 
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");


// DOUBLES AND DECIMALS =====================================
decimal totalValue = 0.0M;
foreach (Product product in products)
{
    if (!product.Sold)
    {
        totalValue += product.Price;
    }
}
Console.WriteLine($"Total inventory value: ${totalValue}");

// EXCEPTIONS LESSON==================================================
