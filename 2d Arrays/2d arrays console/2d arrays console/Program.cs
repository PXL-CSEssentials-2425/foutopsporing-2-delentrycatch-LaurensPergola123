int[,] numbers = new int[3, 5]; // 3 rijen , 5 kolommen

Random randonNumber = new Random();
for (int col = 0; col < numbers.GetLength(1) -1; col++)
{
    numbers[0 , col] = randonNumber.Next(0, 11);
}

//Tweede rij opvullen met user input
Console.WriteLine($"Geef {numbers.GetLength(1)} getallen");
for (int col = 0;col < numbers.GetLength(1); col++)
{
    Console.Write($"Getal {col + 1}: ");
    numbers[1 ,col] = int.Parse(Console.ReadLine());
}

//Derde rij opvullen met de som van de eerste 2 rijen
for (int col = 0; col<numbers.GetLength(1);col++)
{
    numbers[2, col] = numbers[0 , col] + numbers[1 , col];
}

for (int row = 0; row < numbers.GetLength(0); row++)
{
    Console.Write($"rij {row + 1} ==>\t");

    for (int col = 0; col < numbers.GetLength(1); col++)
    {
        Console.Write($"{numbers[row, col]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Druk toets om af te sluiten");
Console.ReadKey();