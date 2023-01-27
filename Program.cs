﻿int readInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


string[] enterMassive(int n)
{
    string[] arrOfString = new string[n];
    for(int i = 0; i < arrOfString.Length; i++)
    {
        Console.WriteLine("Enter string:");
        arrOfString[i] = Console.ReadLine()!;
    }
    return arrOfString;
}

void showArr(string[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

string[] solutionCycle (string[] arr)
{
    int i = 0;
    int j = 0;
    string[] newArr = new string [arr.Length];
    while(i < arr.Length)
    {
        if((arr[i].ToCharArray().Length) <= 3)
        {
            newArr[j] = arr[i];
            j += 1;
        }
        i += 1;
    }
    return newArr;
}

int lengthOfStringArr = readInt("Enter length of arr:");

string[] enteredArr = enterMassive(lengthOfStringArr);


Console.WriteLine("Entered arr:");
showArr(enteredArr);

string[] solutionArr= solutionCycle(enteredArr);

Console.Write("=> ");
showArr(solutionArr);
Console.WriteLine();