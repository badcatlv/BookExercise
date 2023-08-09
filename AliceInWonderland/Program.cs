using System.Diagnostics.Tracing;

string qoute = "Alice was beginning to get very tired of sitting by her sister on the\r\nbank, and of having nothing to do: once or twice she had peeped into the\r\nbook her sister was reading, but it had no pictures or conversations in\r\nit, 'and what is the use of a book,' thought Alice 'without pictures or\r\nconversation?'";
Console.WriteLine(qoute);
Console.WriteLine("Choose a term from the qoute.");
string term = Console.ReadLine();
string searchTerm = term.ToLower();
string searchQoute = qoute.ToLower();

if (searchQoute.IndexOf(searchTerm, 0) != -1)
{
    Console.WriteLine("true");
} 
else 
{ 
    Console.WriteLine("false"); 
}

Console.WriteLine("Your term is at index " + (searchQoute.IndexOf(searchTerm)+1) + " and has the length of " + searchTerm.Length);
string[] newQoute = searchQoute.Split(searchTerm);
Console.WriteLine($"{newQoute.Length}");

foreach (var word in newQoute)
{ Console.WriteLine($"<{word}>"); }

