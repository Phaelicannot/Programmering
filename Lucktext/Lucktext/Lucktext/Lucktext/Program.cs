

Console.WriteLine("Type in your name:");
string name = Console.ReadLine();


Console.WriteLine("Type in something you are wondering about:");
string question = Console.ReadLine();
string lowerquestion = question.ToLower();

Console.WriteLine("Type in a single object:");
string objekt = Console.ReadLine();
string lowerobjekt = objekt.ToLower();

Console.WriteLine($"Hello {name}, I tried to find the answer to your question about {lowerquestion}. I climbed mountains, dove into the deepest seas, looked through the most dense of forests, traveled through space, looked under your bed and even under your {lowerobjekt}. But all I could find was that nobody asked.");
Console.ReadLine();
