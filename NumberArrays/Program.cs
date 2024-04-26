int[] numbers = new int[10];
Random rdn = new Random();

int sum = 0;

//populating the array
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rdn.Next(1, numbers.Length + 1);
    sum = sum + numbers[i];
}

foreach (int number in numbers)
{
    Console.WriteLine(number);
}


Console.WriteLine($"Total: {sum}");