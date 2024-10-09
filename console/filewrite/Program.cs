using System.IO;

string text = "Hello, world!\nHow are you?\n";
string filePath = "new_file.txt";

using(StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine(text);
}

// writes the specified text to a file. If the file already exists, it overwrites its contents.
text = "Some new contents here.\nDo you know what happen?\n";
File.WriteAllText(filePath, text); 

// append text to a file.
text = "Append some text.";
using(StreamWriter writer = File.AppendText(filePath))
{
    writer.WriteLine(text);
}
    
