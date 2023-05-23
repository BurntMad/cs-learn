// ** Code Project 1 - write code that validates integer input
// todo: 
// 1. solution must include either a do-while or while iteration 
/* 2. before the iteration block: your solution must use a Console.Writeline()
statement to prompt the user for and integer value between 5 and 10*/
// ... inside the iteration block: ...
// > the solution must use a Console.ReadLine() statement to read the user's input
// > must ensure the input value is a valid representation of an integer 
// > if the integer value is not between 5 - 10 the code must display an error message
// > the solution must ensure that the integer value is between 5 - 10 before exiting the iteration block

// ? output: 
/* 
Enter an integer value between 5 and 10
two
Sorry, you entered an invalid number, please try again
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.
 */

Console.WriteLine("Enter an integer value between 5 and 10");
string input = Console.ReadLine();
int number = int.Parse(input);

do
{
    if (number < 5 || number > 10)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
        input = Console.ReadLine();
        number = int.Parse(input);
    }
    else
    {
        Console.WriteLine($"Your input value ({number}) has been accepted.");
        break;
    }
} while (true);



