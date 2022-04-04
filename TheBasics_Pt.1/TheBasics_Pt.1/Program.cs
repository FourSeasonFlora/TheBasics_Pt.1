/* Level Three */
Console.WriteLine("Hello, Big World!");
Console.WriteLine("My name is Lauren,");
Console.WriteLine("I like gardening and beer!");
Console.WriteLine("I am studdying C#");
Console.WriteLine("and it can do anything!\n");

Console.WriteLine("\nBread is ready!");
Console.WriteLine("Who is the bread for? ");
var name = Console.ReadLine();
Console.WriteLine(name + " got bread.\n");


/* Level Four */
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


/*Level Six*/
int intExample = -30;
Console.WriteLine($"{intExample}\n");

short shortExample = -32_768;
Console.WriteLine($"{shortExample}\n");

long longExample = 2_147_483_649;
Console.WriteLine($"{longExample}\n");

byte byteExample = 30;
Console.WriteLine($"{byteExample}\n");

sbyte sbyteExample = 127;
Console.WriteLine($"{sbyteExample}\n");

uint uintExample = 4_294_967_000;
Console.WriteLine($"{uintExample}\n");

ushort ushortExample = 20_000;
Console.WriteLine($"{ushortExample}\n");

ulong ulongExample = 1;
Console.WriteLine($"{ulongExample}\n");

float floatExample = 3.1f;
Console.WriteLine($"{floatExample}\n");

double doubleExample = 3.1;
Console.WriteLine($"{doubleExample}\n");

decimal decimalExample = 3.1m;
Console.WriteLine($"{decimalExample}\n");

char charExample = 'A';
Console.WriteLine($"{charExample}\n");

string stringExample = "Lauren";
Console.WriteLine($"{stringExample}\n");

/*Level Seven - Math */
calculating the area of a triangle
Console.WriteLine("What is the base of your triangle?");
var triangleBase = Console.ReadLine();
Console.WriteLine("\nWhat is the height of your triangle?");
var triangleHeight = Console.ReadLine();
Console.WriteLine($"\nThe triangle base has been recorded as {triangleBase} and the height recorded as {triangleHeight}.");
float triBase = Convert.ToSingle(triangleBase);
float triHeight = Convert.ToSingle(triangleHeight);
float area = (triBase * triHeight) / 2;
Console.WriteLine($"\nThe area of the triangle is: {area}");

/*The duckbear and chocolate eggs - the modulus*/
Console.WriteLine("Please enter number of chocolate eggs collected: ");
var eggNum = Console.ReadLine();
int eggs = Convert.ToInt32(eggNum);

int sisters = 4;
int distributeEggs = eggs / sisters;

int duckbearEggs = eggs % sisters;

Console.WriteLine($"Each sister should receive {distributeEggs} eggs.");
Console.WriteLine($"Duckbear receives {duckbearEggs} eggs.\n");

/*The Dominion of Kings*/
int estatePointValue = 1;
int duchyPointValue = 3;
int provincePointValue = 6;

Console.WriteLine("Please enter the number of Estates: ");
var getNumberofEstates = Console.ReadLine();

Console.WriteLine("Please enter the number of Duchys: ");
var getNumberofDuchys = Console.ReadLine();

Console.WriteLine("Please enter the number of Provinces ");
var getNumberofProvinces = Console.ReadLine();

int numEstates = Convert.ToInt32(getNumberofEstates);
int estateValue = estatePointValue * numEstates;
Console.WriteLine($"Estate Point Value:{estateValue}");

int numDuchy = Convert.ToInt32(getNumberofDuchys);
int duchyValue = duchyPointValue * numDuchy;
Console.WriteLine($"Duchy Point Value: {duchyValue}");

int numProvince = Convert.ToInt32(getNumberofProvinces);
int provinceValue = provincePointValue * numProvince;
Console.WriteLine($"Province Point Value: {provinceValue}");

int totalPoints = estateValue + duchyValue + provinceValue;
Console.WriteLine($"The total point value calculated: {totalPoints}");