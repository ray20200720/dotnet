using System.IO;

string filePath = "my_file.txt";
using (StreamReader reader = new StreamReader(filePath))
{
    // reads a single line of text from a text reader object. 
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
	Console.WriteLine(line);
    }

    // reads the entire content of a text file into a string. 
    string text = File.ReadAllText(filePath);
    Console.WriteLine(text);
}
