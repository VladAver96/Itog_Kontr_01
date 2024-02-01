
class Program
{
static void Main()
{
    Console.WriteLine("Введите элементы массива через запятую:");
    string[] inputArray = Console.ReadLine()?.Split(',') ?? Array.Empty<string>();

    string[] resultArray = FilterStrings(inputArray);

    Console.WriteLine("Результат: " + string.Join(", ", resultArray));
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (!string.IsNullOrEmpty(inputArray[i]) && inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];

        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (!string.IsNullOrEmpty(inputArray[i]) && inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }
}
