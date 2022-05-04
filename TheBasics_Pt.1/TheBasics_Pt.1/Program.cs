/* Level Three */
//Console.WriteLine("Hello, Big World!");
//Console.WriteLine("My name is Lauren,");
//Console.WriteLine("I like gardening and beer!");
//Console.WriteLine("I am studdying C#");
//Console.WriteLine("and it can do anything!\n");

//Console.WriteLine("\nBread is ready!");
//Console.WriteLine("Who is the bread for? ");
//var name = Console.ReadLine();
//Console.WriteLine(name + " got bread.\n");


/* Level Four */
//Console.WriteLine("\nWhat kind of thing are we talking about?");

//Variable a holds the name of the thing we are talking about. In the store it is The Name Maker

//var itemName = Console.ReadLine();
//Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

//Variable string b holds the description of variable a
//var itemDescription = Console.ReadLine();

//Holds impending doom
//string doom = "Doom";

//The model number of the thing (The Name Maker)
//string modelNo = "3000";
//Console.WriteLine("The " + itemDescription + " " + itemName + " of " + doom + " " + modelNo + "!\n");


/*Level Six*/
//int intExample = -30;
//Console.WriteLine($"{intExample}\n");

//short shortExample = -32_768;
//Console.WriteLine($"{shortExample}\n");

//long longExample = 2_147_483_649;
//Console.WriteLine($"{longExample}\n");

//byte byteExample = 30;
//Console.WriteLine($"{byteExample}\n");

//sbyte sbyteExample = 127;
//Console.WriteLine($"{sbyteExample}\n");

//uint uintExample = 4_294_967_000;
//Console.WriteLine($"{uintExample}\n");

//ushort ushortExample = 20_000;
//Console.WriteLine($"{ushortExample}\n");

//ulong ulongExample = 1;
//Console.WriteLine($"{ulongExample}\n");

//float floatExample = 3.1f;
//Console.WriteLine($"{floatExample}\n");

//double doubleExample = 3.1;
//Console.WriteLine($"{doubleExample}\n");

//decimal decimalExample = 3.1m;
//Console.WriteLine($"{decimalExample}\n");

//char charExample = 'A';
//Console.WriteLine($"{charExample}\n");

//string stringExample = "Lauren";
//Console.WriteLine($"{stringExample}\n");

/*Level Seven - Math */
//calculating the area of a triangle
//Console.WriteLine("What is the base of your triangle?");
//var triangleBase = Console.ReadLine();
//Console.WriteLine("\nWhat is the height of your triangle?");
//var triangleHeight = Console.ReadLine();
//Console.WriteLine($"\nThe triangle base has been recorded as {triangleBase} and the height recorded as {triangleHeight}.");
//float triBase = Convert.ToSingle(triangleBase);
//float triHeight = Convert.ToSingle(triangleHeight);
//float area = (triBase * triHeight) / 2;
//Console.WriteLine($"\nThe area of the triangle is: {area}");

/*The duckbear and chocolate eggs - the modulus*/
//Console.WriteLine("Please enter number of chocolate eggs collected: ");
//var eggNum = Console.ReadLine();
//int eggs = Convert.ToInt32(eggNum);

//int sisters = 4;
//int distributeEggs = eggs / sisters;

//int duckbearEggs = eggs % sisters;

//Console.WriteLine($"Each sister should receive {distributeEggs} eggs.");
//Console.WriteLine($"Duckbear receives {duckbearEggs} eggs.\n");

/*The Dominion of Kings*/
//int estatePointValue = 1;
//int duchyPointValue = 3;
//int provincePointValue = 6;

//Console.WriteLine("Please enter the number of Estates: ");
//var getNumberofEstates = Console.ReadLine();

//Console.WriteLine("Please enter the number of Duchys: ");
//var getNumberofDuchys = Console.ReadLine();

//Console.WriteLine("Please enter the number of Provinces ");
//var getNumberofProvinces = Console.ReadLine();

//int numEstates = Convert.ToInt32(getNumberofEstates);
//int estateValue = estatePointValue * numEstates;
//Console.WriteLine($"Estate Point Value:{estateValue}");

//int numDuchy = Convert.ToInt32(getNumberofDuchys);
//int duchyValue = duchyPointValue * numDuchy;
//Console.WriteLine($"Duchy Point Value: {duchyValue}");

//int numProvince = Convert.ToInt32(getNumberofProvinces);
//int provinceValue = provincePointValue * numProvince;
//Console.WriteLine($"Province Point Value: {provinceValue}");

//int totalPoints = estateValue + duchyValue + provinceValue;
//Console.WriteLine($"The total point value calculated: {totalPoints}");

/* Level Eight- The Defense of Consolas */

//Console.Title = "The Defense of Consolas";
//Console.Beep(440, 500);
//Console.BackgroundColor = ConsoleColor.Magenta;

//Console.Write("Target Row: ");
//var getRow = Console.ReadLine();
//int targetRow = Convert.ToInt32(getRow);

//Console.Write("Target Column: ");
//var getColumn = Console.ReadLine();
//int targetColumn = Convert.ToInt32(getColumn);

//var soldierA = targetRow + "," + (targetColumn - 1);
//var soldierB = (targetRow + 1) + "," + targetColumn;
//var soldierC = targetRow + "," + (targetColumn + 1);
//var soldierD = (targetRow - 1) + "," + targetColumn;

//Console.WriteLine($"Deploy to:\n({soldierA})\n({soldierB})\n({soldierC})\n({soldierD})");

/* Level Nine - Repairing the Clocktower */

//Console.Write("Enter the hour: ");
//var getTime = Console.ReadLine();
//int curentTime = Convert.ToInt32(getTime);

//if (curentTime % 2 == 0)
//    Console.WriteLine("tick");
//else if (curentTime % 2 == 1)
//    Console.WriteLine("tock");
//else
//    Console.WriteLine("Please try again");
// I could be using better error handling here to make sure a number was entered rather than a letter or another character. 

/* Watchtower */

//Console.Write("Provide enemies x coordinate: ");
//var getXcoord = Console.ReadLine();
//Console.Write("Provide enemies y coordinate: ");
//var getycoord = Console.ReadLine();
//Console.WriteLine("Enemies Location: " + "(" + getXcoord + ", " + getycoord + ")");

//int xCoord = Convert.ToInt32(getXcoord);
//int yCoord = Convert.ToInt32(getycoord);


//if (xCoord > 0 && yCoord == 0)
//    Console.WriteLine("East");
//else if (xCoord > 0 && yCoord > 0)
//    Console.WriteLine("NE");
//else if (xCoord > 0 && yCoord < 0)
//    Console.WriteLine("SE");
//else if (xCoord < 0 && yCoord == 0)
//    Console.WriteLine("West");
//else if (xCoord < 0 && yCoord > 0)
//Console.WriteLine("NW");
//else if (xCoord < 0 && yCoord < 0)
//    Console.WriteLine("SW");
//else if (x == 0 && yCoord < 0)
//    Console.WriteLine("South");
//else if (xCoord == 0 && yCoord > 0)
//Console.WriteLine("North");
//else if (xCoord == 0 && yCoord == 0)
//    Console.WriteLine("Center");

/* Level Ten - Buying Inventory */

//Console.WriteLine("Please provide your name: ");
//var usersName = Console.ReadLine();
//Console.WriteLine($"Hello {usersName}");

//Console.WriteLine("The following items are available:");
//Console.WriteLine("1 - Rope");
//Console.WriteLine("2 - Torches");
//Console.WriteLine("3 - Climbing Equipment");
//Console.WriteLine("4 - Clean Water");
//Console.WriteLine("5 - Machete");
//Console.WriteLine("6 - Canoe");
//Console.WriteLine("7 - Food Supplies");
//Console.WriteLine("What number do you want to see the price of? ");

//int choice = Convert.ToInt32(Console.ReadLine());
//var maker = "Lauren";
//int rope = 10;
//float torche = 15;
//float climbing = 25;
//float water = 1;
//int machete = 20;
//int canoe = 200;
//float food = 1;

//switch (choice)
//{
//    case 1:
//        Console.WriteLine($"Rope = {rope} gold pieces");
//        if (usersName == maker)
//            Console.WriteLine("You received a 50% discount! Your cost will be " + rope / 2 + " gold");
//        break;
//    case 2:
//        Console.WriteLine($"Torches = {torche} gold pieces");
//        if (usersName == maker)
//            Console.WriteLine("You received a 50% discount! Your cost will be " + torche / 2 + " gold");
//        break;
//    case 3:
//        Console.WriteLine($"Climbing Equipment = {climbing} gold pieces");
//        if (usersName == maker)
//            Console.WriteLine("You received a 50% discount! Your cost will be " + climbing / 2 + " gold");
//        break;
//    case 4:
//        Console.WriteLine($"Clean Water = {water} gold piece");
//        if (usersName == maker)
//            Console.WriteLine("You received a 50% discount! Your cost will be " + water / 2 + " gold");
//        break;
//    case 5:
//        Console.WriteLine($"Machete = {machete} gold pieces");
//        if (usersName == maker)
//            Console.WriteLine("You received a 50% discount! Your cost will be " + machete / 2 + " gold");
//        break;
//    case 6:
//        Console.WriteLine($"Canoe = {canoe} gold pieces");
//        if (usersName == maker)
//            Console.WriteLine("You received a 50% discount! Your cost will be " + canoe / 2 + " gold");
//        break;
//    case 7:
//        Console.WriteLine($"Food Supplies = {food} gold piece");
//        if (usersName == maker)
//            Console.WriteLine("You received a 50% discount! Your cost will be " + food / 2 + " gold");
//        break;
//    default:
//        Console.WriteLine("Please try again");
//        break;
//}
/*Level 10 Discounted Inventory - Authors Solution*/

//string whichItem = choice switch
//{
//    1 => "Rope",
//    2 => "Torches",
//    3 => "Climbing Equipment",
//    4 => "Clean Water",
//    5 => "Machete",
//    6 => "Canoe",
//    7 => "Food Supplies",
//    _ => "Please try again"
//};

//float price = whichItem switch
//{
//    "Rope" => 10,
//    "Torches" => 15,
//    "Climbing Equipment" => 25,
//    "Clean Water" => 1,
//    "Machete" => 20,
//    "Canoe" => 200,
//    "Food Supplies" => 1,
//    _ => 0
//};

//if (usersName == maker) price /= 2;
//Console.WriteLine($"{whichItem} costs {price} gold");

/* Level 11 - The Prototype */

//int pilot;

//do
//{
//    Console.Write("Pilot please provide number: ");
//    var pilotNum = Console.ReadLine();
//    pilot = Convert.ToInt32(pilotNum);
//    if (pilot < 1)
//        Console.WriteLine($"{pilot} is too low.");
//    else if (pilot > 100)
//        Console.WriteLine($"{pilot} is too high.");
//    else
//        Console.WriteLine($"{pilot} has been recorded.");
//}
//while (pilot < 1 || pilot > 100);
//Console.Clear();


//int hunter;

//do
//{
//    Console.Write("Hunter please provide number: ");
//    var hunterNum = Console.ReadLine();
//    hunter = Convert.ToInt32(hunterNum);
//    if (hunter < 1)
//        Console.WriteLine($"{hunter} is too low.");
//    else if (hunter > 100)
//        Console.WriteLine($"{hunter} is too high.");
//    else
//        Console.WriteLine($"{hunter} has been recorded.");
//}
//while (hunter < 1 | hunter > 100);
//Console.Clear();

//Console.WriteLine($"Coordinates Provided: {pilot}, {hunter}");

/* Level 11 - The Magic Cannon */

//for (int num = 1; num < 101; num ++)
//{
//    if (num % 3 == 0 && num % 5 == 0)
//    {
//        Console.ForegroundColor = ConsoleColor.Blue;
//        Console.WriteLine($"{num}: Mega Blast");
//    }
//    else if (num % 5 == 0)
//    {
//        Console.ForegroundColor = ConsoleColor.Yellow;
//        Console.WriteLine($"{num}: Electric");
//    }
//    else if (num % 3 == 0)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine($"{num}:Fire");
//    }
//}