string inputString = "Hello";

// Convert the string to a char array
char[] charArray = inputString.ToCharArray();

// Process each character and return as a separate string
foreach (char c in charArray)
{
    string resultString = c.ToString();
    Console.WriteLine(resultString);
}