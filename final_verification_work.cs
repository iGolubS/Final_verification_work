string[] stringArray = new string[4] { "Hello", ":)", "три", "четыре" };
string[] miniArray = new string[4];
int letter_counter = 0;
for (int j = 0; j < stringArray.Length; j++)
{
    string input = stringArray[j];
    
    for (int i = 0; i < input.Length; i++)
    {
        letter_counter++;
    }
   
    if (letter_counter <= 3)
    {
        miniArray[j] = stringArray[j];
    }
    letter_counter = 0;
}
Console.Write($"[{String.Join(" ", stringArray)}] -> ");
Console.Write($"[{String.Join(" ", miniArray)}]");
