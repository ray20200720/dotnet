using System.IO;

string filePath = "my_file.txt";
using (StreamReader reader = new StreamReader(filePath))
{
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
	Console.WriteLine(line);
    }
}
