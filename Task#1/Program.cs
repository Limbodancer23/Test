#nullable disable
int StringNumber = StrNum("strings (>=3)");
// System.Console.WriteLine("Enter number of ");
string[] MyArray = CreateArray(StringNumber);
System.Console.WriteLine("[" + (String.Join(", ", MyArray)) + "]");
string[] ResArr = CutArr(MyArray);
System.Console.WriteLine("[" + (String.Join(", ", ResArr)) + "]");

string[] CutArr(string[] arr)
{
    string[] resArr = new string[new Random().Next(0, 4)];
    for (int i = 0; i < resArr.Length; i++)
    {
        resArr[i] = arr[new Random().Next(0, arr.Length)];
    }
    return resArr;
}

int StrNum(string numberStr)
{
    int num = 0;
    while (true)
    {
        if (num < 3 || num > 8)
        {
            System.Console.WriteLine($"Enter number of {numberStr}");
            num = Convert.ToInt32(Console.ReadLine());
        }
        else break;
    }
    return num;
}

string[] CreateArray(int Lenght)
{
    string[] arr = new string[Lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"Enter symbol  №{i + 1}");
        arr[i] = Console.ReadLine();
    }
    return arr;
}
