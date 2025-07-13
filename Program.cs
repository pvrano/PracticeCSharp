// See https://aka.ms/new-console-template for more information

string s = "Hello, World";
Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();

for(int i = 0; i < s.Length; i++)
{
    if (keyValuePairs.ContainsKey(s[i]))
    {
        keyValuePairs[s[i]]++;
    }
    else
    {
        keyValuePairs.Add(s[i], 1);
    }
}

foreach(KeyValuePair<char,int> pair in keyValuePairs)
{
    Console.WriteLine(pair);
}

Dictionary<string, List<string>> notes = new Dictionary<string, List<string>>();
notes.Add("Active", new List<string> { "go shopping", "dry vegetables" });
notes.Add("IsComplete", new List<string> { "ride a bike", "swim in a ocean" });

notes["Active"].Add("blow a torch");

Console.WriteLine(notes["IsComplete"][1]);

foreach(var note in notes)
{
    Console.WriteLine($"{note.Key} : " + string.Join(", ", note.Value));
}

