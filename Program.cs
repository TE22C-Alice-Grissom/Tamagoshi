Tamagotchi tama = new();

Console.WriteLine("Vad ska din Tamagoshi heta?");
tama.Name = Console.ReadLine();


while (tama.GetAlive() == true)
{
    Console.WriteLine($"Just nu är {tama.Name} stats på");
    tama.PrintStats();

    Console.WriteLine($"Vad vill du göra med {tama.Name}");
    Console.WriteLine("""
    1. Lära ord
    2. Mata
    3. Prata
    """);

    string choice =Console.ReadLine();
    if (choice == "1")
    {
        Console.WriteLine($"Vilket ord vill du lära {tama.Name}");
        string w = Console.ReadLine();
        tama.Teach(w);
    }

    else if (choice == "2")
    {
        tama.Feed();
        Console.WriteLine($"Du matade {tama.Name} sushi");
    }

    else if (choice == "3")
    {
        Console.WriteLine($"{tama.Name} säger,");
        tama.Hi();
    }


    tama.Tick();
    
}



tama.PrintStats();



// tama.Teach("Hej");
// tama.Teach("Hejdå");
// tama.Teach("kuk");
// tama.Teach("puss");
// tama.Hi();


Console.ReadLine();