using System.IO;
using System.Text.Json;

string jsonText = "Abilities.json";
Abilities power = JsonSerializer.Deserialize<Abilities>(File.ReadAllText(jsonText));
Abilities powers = new Abilities();


SavingGrace();

void SavingGrace()
{
    Console.Clear();
    Console.WriteLine("Saving The Grace! \n1) Create your own skill\n2) Use beautiful existing skills");

    string action = Console.ReadLine();
    Console.Clear();

    if (action == "1")
    {
        Console.WriteLine("Choose a name for your skill");
        powers.Name = Console.ReadLine();

        Console.WriteLine("Choose a cost for your skill");
        powers.Cost = Console.ReadLine();

        Console.WriteLine("Choose how much damage your skill does");
        powers.Damage = Console.ReadLine();

        string json = JsonSerializer.Serialize<Abilities>(powers);
        File.WriteAllText(jsonText, json);
    }
    else if (action == "2")
    {
        if (power.Name != null && power.Cost != null && power.Damage != null)
        {
            Console.WriteLine($"Power name: {power.Name}\nPower cost: {power.Cost}\nPower damage: {power.Damage}");
        }
        else
        {
            SavingGrace();
        }
    }
    else
    {
        SavingGrace();
    }
}
Console.ReadLine();