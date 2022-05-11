/* Level 12 - The Replicator of D'To */

//int[] replicatorNum = new int[5];
//for (int index = 0; index < 5 ; index++)
//{
//    Console.Write("Please provide a number: ");
//    var userNum = Console.ReadLine();
//    int num = Convert.ToInt32(userNum);
//    replicatorNum[index] = num;
//}

//int[] replicator = new int[5];
//for (int number = 0; number < 5; number++)
//{
//    replicator[number] = replicatorNum[number];
//}

//for (int number = 0; number < 5; number++)
//{
//    Console.WriteLine($"Old array {replicatorNum[number]} : New {replicator[number]}");
//}

/* The Laws of Freach */
int[] ourNumbers = new int[] { 4, 51, 10, 1, 80 };

int curentSmallest = int.MaxValue;
foreach (int minVal in ourNumbers)
{
    if (minVal < curentSmallest)
        curentSmallest = minVal;
}
Console.WriteLine(curentSmallest);

int total = 0;
foreach(int numtotal in ourNumbers)
{
    total += numtotal;
}
//float sum = (float)total;
float average = (float)total / ourNumbers.Length;
Console.WriteLine(average);