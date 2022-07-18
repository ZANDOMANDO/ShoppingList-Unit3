


Dictionary<string, decimal> shoppingItems = new Dictionary<string, decimal>()

{
{"Rice", 1.50m},
{ "2 Ltr Coca-Cola", 2.50m},
{ "Madeline Cookies", 2.60m},
{ "Lemon Cake", 4.30m},
{ "Llerba Mate", 1.20m},
{ "Colombian Coffee", 1.41m},
{ "Doritos", 1.70m},
{ "Corona Familiar 12 pack", 13.40m}
};


List<string> shoppingList = new List<string>();


string itemChosen;
bool itemFound=false;
decimal sumShoppingList = 0.00m;
String addAnotherItem ;
bool goAgain;
do
{
    do
    {
        itemFound = false;
        Console.WriteLine("Enter an item to add to shopping cart:");
        itemChosen = Console.ReadLine();


        if (shoppingItems.ContainsKey(itemChosen))
        {
            itemFound = true;
            shoppingList.Add(itemChosen);
            Console.WriteLine($"Item: {itemChosen}\nHas been successfully added to your shopping cart!");





        }
        else
        {
            Console.WriteLine($"{itemChosen} does NOT exist.\nPlease Choose another item.");

        }

    }
    while (!itemFound);

    Console.WriteLine("Would you like to add more items to your shopping list? y/n");
    addAnotherItem = Console.ReadLine().ToLower();
    if (addAnotherItem.Equals('y')){
        goAgain = true;
    }
    else
    {
        goAgain = false;
        break;
    }
}
while (goAgain);

decimal myKey;
for (int i = 0; i < shoppingList.Count; i++)
{
    Console.WriteLine(shoppingList[i]);
    myKey = shoppingItems.FirstOrDefault(x => x.Key == shoppingList[i]).Value;
    sumShoppingList += myKey;

}
Console.WriteLine($"Total Cost of all shopping items is: ${sumShoppingList}");





