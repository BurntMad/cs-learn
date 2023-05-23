// Switch Cases dotnet learn
int employeeLvl = 200;
string employeeName = "John Doe";

string title = "";

switch (employeeLvl)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName} is a {title}.");

