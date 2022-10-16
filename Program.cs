string ReadString(string message)
{
    Console.WriteLine(message);
    string result = Console.ReadLine();
    while (result == String.Empty)
    {
        Console.WriteLine("Строка пустая! Попробуйте ещё раз:");
        result = Console.ReadLine();
    }
    return result;
}

string RemoveExcessSplittersAndSpaces(string input, char splitter)
{
    input = input.Trim(' ');
    for (int i = 0; i < input.Length; i++)
        if (input[i] == ' ' && input[i + 1] == ' ')
        {
            input = input.Remove(i, 1);
            i--;
        }
    input = input.Trim(splitter);
    for (int i = 0; i < input.Length; i++)
        if (input[i] == splitter && input[i + 1] == splitter)
        {
            input = input.Remove(i, 1);
            i--;
        }
    input = input.Trim(' ');
    return input;
}

int CountSplitters(string splitable, char splitter)
{
    int counter = 0;
    for (int i = 0; i < splitable.Length; i++)
    {
        if (splitable[i] == splitter)
            counter++;
    }
    return counter + 1;
}

void TrimElements(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = array[i].Trim(' ');
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"|{array[i]}| ");
    Console.WriteLine();
}

string[] GetArray(string input)
{
    input = RemoveExcessSplittersAndSpaces(input, ',');
    int size = CountSplitters(input, ',');
    string[] result = input.Split(',', size);
    TrimElements(result);
    return result;
}

int CountStringRequiredLength(string[] StringArray, int Required)
{
    int counter = 0;
    for (int i = 0; i < StringArray.Length; i++)
    {
        if (StringArray[i].Length <= Required)
            counter++;
    }
    return counter;
}

string[] FillNewArray(string[] Array, int Required)
{
    int j = 0;
    string[] newArray = new string[CountStringRequiredLength(Array,Required)];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= Required)
            {
                newArray[j] = Array[i];
                j++;
            }    
    }
    return newArray;
}


// как объединить 2 предыдущих метода в один? 
// string[] GetNewArray(string[] StringArray, int Required)
// {
//     int counter = 0;
//     for (int i = 0; i < StringArray.Length; i++)
//     {
//         if (StringArray[i].Length <= Required)
//             counter++;
//     }

//     // string[] result = new string[counter];
//     // int j = 0;

//     // for (int i = 0; i < StringArray.Length; i++)
//     // {
//     //     if (StringArray[i].Length <= Required)
//     //         {
//     //             result[j] = StringArray[i];
//     //             j++;
//     //         }    
//     // }
//     // return result;
// }

void PrintStringArray(string[] array)
{
   for (int i = 0; i < array.Length; i++)
     {
         Console.Write(array[i] + " ");
     }
   Console.WriteLine();
}



/*------------------MAIN-----------------------------*/
Console.Clear();

string input = ReadString("Введите элементы массива через запятую: ");
string[] inputArray = GetArray(input);
PrintArray(inputArray);
int RequiredLength = 3;
Console.WriteLine(CountStringRequiredLength(inputArray,RequiredLength));
PrintStringArray(FillNewArray(inputArray,RequiredLength));

// string[] newArray = new string[CountStringRequiredLength(inputArray,RequiredLength)];
// int j = 0;
// for (int i = 0; i < inputArray.Length; i++)
//     {
//         if (inputArray[i].Length <= RequiredLength)
//             {
//                 newArray[j] = inputArray[i];
//                 j++;
//             }    
//     }







// Console.WriteLine(GetNewArray(inputArray,RequiredLength).Length);
// string[] newArray = new string[GetNewArray(inputArray,RequiredLength).Length];
// for (int i = 0; i < newArray.Length; i++)
//      {
//          Console.Write(newArray[i] + " ");
//      }
//    Console.WriteLine();
// PrintStringArray(newArray);



// int j = 0;

// for (int i = 0; i < inputArray.Length; i++)
//     {
//         if (inputArray[i].Length <= RequiredLength)
//             {
//                 newArray[j] = inputArray[i];
//                 j++;
//             }    
//     }
  

// for (int i = 0; i < inputArray.Length; i++)
//     {
//         if (inputArray[i].Length <= RequiredLength)
//             {
//                 Console.Write(inputArray[i] + " ");
//             }    
//     }

// Console.WriteLine();


// for (int i = 0; i < newArray.Length; i++)
//     {
//         Console.Write(newArray[i] + " ");
//     }