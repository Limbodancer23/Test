#nullable disable
int StringNumber = StrNum("strings (>=3)");
// System.Console.WriteLine("Enter number of ");
string[] MyArray = CreateArray(StringNumber);
System.Console.WriteLine("[" + (String.Join(", ", MyArray)) + "]");

System.Console.WriteLine();

string[] ResArr = CutArr(0);
System.Console.WriteLine("[" + (String.Join(", ", ResArr)) + "]");

string[] CutArr(int count)
{
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i].Length < 4 && MyArray[i].Length > 0)
        {
            count++;
        }
    }
    string[] resArr = new string[count];
    int j = 0;
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i].Length < 4 && MyArray[i].Length > 0)
        {
            resArr[j] = MyArray[i];
            j++;
        }
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
