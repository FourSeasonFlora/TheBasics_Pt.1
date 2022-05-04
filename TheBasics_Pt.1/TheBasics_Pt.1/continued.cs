/* Level 12 - The Replicator of D'To */

int[] replicatorNum = new int[5];
for (int index = 0; index < 5 ; index++)
{
    Console.Write("Please provide a number: ");
    var userNum = Console.ReadLine();
    int num = Convert.ToInt32(userNum);
    replicatorNum[index] = num;
}

int[] replicator = new int[5];
for (int number = 0; number < 5; number++)
{
    replicator[number] = replicatorNum[number];
}

for (int number = 0; number < 5; number++)
{
    Console.WriteLine($"Old array {replicatorNum[number]} : New {replicator[number]}");
}