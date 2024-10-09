using System.IO;

string text = "Hello, world!";
string filePath = "new_file.txt";

using(StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine(text);
}

