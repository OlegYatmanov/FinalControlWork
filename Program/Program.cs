using System;
using static System.Console;

string [] FirstArray = new string [5] {"Nizhnevartovsk", "Denmark", ":-", "-2", "12"};
string [] SecondArray = new string [FirstArray.Length];
SecondArrayResult (FirstArray, SecondArray);
PrintArray (SecondArray);


void SecondArrayResult (string [] FirstArray, string [] SecondArray)
{
    int count = 0;
    for ( int i = 0; i < FirstArray.Length; i ++)
    {
        if (FirstArray [i].Length <= 3)
        {
            SecondArray [count] = FirstArray [i];
            count ++;
        }
    }
}

void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Write ($"{array [i]} ");
    }
    WriteLine();
}