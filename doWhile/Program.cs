//* Do - while iteration loops

// ? what is a do-while loop?
// * A do-while loop is a post-test loop, meaning that the condition is tested after the loop body is executed.

// do {
//  loop body
// } while (condition);

// todo: Write a while statement that iterates only while a random number is greater than some value
Random random = new Random();
int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");



