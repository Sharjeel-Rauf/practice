string originalString = "Hello, world!";

// Character to remove
char charToRemove = 'o';

// Find the index of the character
int indexOfChar = originalString.IndexOf(charToRemove);

// Check if the character is found
if (indexOfChar != -1)
{
    // Remove the character
    string modifiedString = originalString.Remove(indexOfChar, 1);

    // Display the modified string
    Console.WriteLine("Original String: " + originalString);
    Console.WriteLine("Modified String: " + modifiedString);
}
else
{
    Console.WriteLine("Character not found in the original string.");
}