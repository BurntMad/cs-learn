// * Coding Challenge: FizzBuzz
/* 
 todo: output values from 1 - 100, one number per line, inside the code block of interation statement
 * when the current value is divisible by 3, output the word "Fizz" instead of the number
 * when the current value is divisible by 5, output the word "Buzz" instead of the number
 * when the current value is divisible by both 3 and 5, output the word "FizzBuzz" instead of the number
 */

 for (int i = 1; i <= 100; i++)
 {
     if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
     else if (i % 3 == 0) Console.WriteLine("Fizz");
     else if (i % 5 == 0) Console.WriteLine("Buzz");
     else Console.WriteLine(i);
 }

// ? possible solution:
// for (int i = 1; i < 101; i++)
// {
//     if ((i % 3 == 0) && (i % 5 == 0))
//         Console.WriteLine($"{i} - FizzBuzz");
//     else if (i % 3 == 0)
//         Console.WriteLine($"{i} - Fizz");
//     else if (i % 5 == 0)
//         Console.WriteLine($"{i} - Buzz");
//     else
//         Console.WriteLine($"{i}");
// }
