string[] stringArray = new string[4] { "Hello", ":)", "три", "четыре" };
string[] miniArray = new string[stringArray.Length];
int letter_counter = 0;
int size = 3;
for (int i = 0; i<stringArray.Length; i++)
{
    if (stringArray[i].Length <=size)
    {
        miniArray[letter_counter]=stringArray[i];  
        letter_counter++;   
    }
}
Console.Write($"[{String.Join(" ", stringArray)}] -> ");
Console.Write($"[{String.Join(" ", miniArray)}]");