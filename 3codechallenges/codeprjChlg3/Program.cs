// ** Code project 3 - Write code to implement code that achieves the project conditions

// ? Project conditions using the following logic:
/* 
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
 */
// 1. must declare an integer variable named 'periodLocation' and can be used to hold the location of the period character within a string
// 2. the solution must contain an outer foreach or for loop that can be useed to process each string element in the array. the string variable that process the loops should be named 'myString'
// 3. in the outer loop the solution must use the IndexOf() method of the string class to get the location of the first period character in the 'myString' variable. the method call should be similar to: myString.IndexOf(".") - if there is no period character in the string, a value of -1 should be returned
// 5. the solution must include either a do-while or while loop, that can be used to process the myString variable
// 6. in the inner loop, the solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed
// 7. the inner loop of the solution must not display the period character
// 8. in the inner loop of the solution, it must use the Remove(), Substring() amd TrimStart() methods to process the string information

// ? Output of expected results:
/* 
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices 
*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    // the remaining portion of speciesToListSelection is the final species name 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}