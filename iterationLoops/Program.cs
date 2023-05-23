// ------------------------ Iteration Loops ------------------------ //

// ** Create and configure iteration for loops 

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }
// ? This code presents a simple for statement that loops through its code block 10 times, printing the current value of i.

// // iterate by counting down 
// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// ** differemt iteration patterns
// for (int i= 0; i < 10; i +=3 )
// {
//     Console.WriteLine(i);
// }
// ? this code prints 0, 3, 6, 9, which skips every other number in the sequence

// ** use the break keyword to exit a loop early
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }
// ? this code prints 0, 1, 2, 3, 4, 5, 6, 7, which is the same as the previous example, but the loop is exited early when i is equal to 7.

// ** loop through each element of an array
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }
// ? this code prints Michael, David, Eddie, Alex, iterating through the array in reverse order.

// ** Examine the limitation of the foreach statement
// string[] names = { "Alex", "Eddie", "David", "Michi"};
// foreach (var name in names)
// {
// ! this wont work
// ! if (name == "David") name = "Sammy";
// }
// ? output: Cannot assign to name because it is a 'foreach iteration variable'

// todo: Overcoming the limitation of the foreach statement
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);
