/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

string[] fraudulentOrderIDs = {"A123", "B456", "C789"}; 

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are currently {fraudulentOrderIDs.Length} Fraudulent orders to process.");

string[] names = {"Jerry" , "Terry", "Perry"};
foreach (string name in names)
{
    Console.WriteLine(name);
}
*/
int[] inventory = {324, 554, 23, 540, 903, 234};
int sum = 0;
foreach (int item in inventory)
{
    sum += item;
    Console.WriteLine(item);
}
    Console.WriteLine($"We have {sum} items in inventory.");