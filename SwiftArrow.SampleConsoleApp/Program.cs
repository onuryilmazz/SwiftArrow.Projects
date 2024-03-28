using SwiftArrow.Common;

for (int i = 0; i < 10; i++)
{
    var result = GetRandomEvenNumber();

    if (result.IsSuccess)
    {
        Console.WriteLine($"Random number: {result.Value}");
    }
    else
    {
        Console.WriteLine($"Error: {result.Error}");
    }
}

Console.ReadLine();

static Result<int> GetRandomEvenNumber()
{
    Random random = new Random();
    var randomNumber = random.Next(10);

    if (randomNumber % 2 == 0)
    {
        return Result.Success(randomNumber);
    }
    else
    {
        return Result.Failure<int>(new Error("NotEvenNumber", "The generated random number is not even!"));
    }
}
