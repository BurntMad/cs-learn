// ** Code challenge 2 - write code that validates string input

// ? Output:
/* Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted. */

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
string input = Console.ReadLine();
string role = input.Trim().ToLower();

do 
{
    if (role != "administrator" && role != "manager" && role != "user")
    {
        Console.WriteLine($"The role name that you entered, \"{input}\" is not valid. Enter your role name (Administrator, Manager, or User)");
        input = Console.ReadLine();
        role = input.Trim().ToLower();
    }
    else
    {
        Console.WriteLine($"Your input value ({input}) has been accepted.");
        break;
    }
}
while (true);
