//Console.WriteLine("Hello, Big World!");
//Console.WriteLine("My name is Lauren,");
//Console.WriteLine("I like gardening and beer!");
//Console.WriteLine("I am studdying C#");
//Console.WriteLine("and it can do anything!\n");

//Console.WriteLine("\nBread is ready!");
//Console.WriteLine("Who is the bread for? ");
//var name = Console.ReadLine();
//Console.WriteLine(name + " got bread.\n");

Console.WriteLine("\nWhat kind of thing are we talking about?");

//Variable a holds the name of the thing we are talking about. In the store it is The Name Maker
var itemName = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

//Variable string b holds the description of variable a
var itemDescription = Console.ReadLine();

//Holds impending doom
string doom = "Doom";

//The model number of the thing (The Name Maker)
string modelNo = "3000";
Console.WriteLine("The " + itemDescription + " " + itemName + " of " + doom + " " + modelNo + "!\n");