//Marcel Rodriguez
//10-17-22 4pm
//Say Hello
//This program will ask name and respond with a greeting with said name
//Peer review - 

Console.Clear();

string end = "yes";

while (end == "yes")
{

bool isContainer = false;
bool isNumber;
int validNumber = 0;


while (isContainer == false)
{
Console.WriteLine("Good morning, what is your name?\n");
string myName = Console.ReadLine();
isNumber = Int32.TryParse(myName, out validNumber);

if(isNumber == false)
{
    isContainer = true;

    Console.WriteLine("\nHello " + myName + ", have an awesome day!");
}

else
{
    Console.WriteLine("\nPlease enter a name and not a number\n");
}


}


Console.WriteLine("\n\nWould you like to try again? Yes / No");
end = Console.ReadLine().ToLower();
Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

}

