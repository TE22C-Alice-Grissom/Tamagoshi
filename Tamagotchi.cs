public class Tamagotchi
{
    private int Hunger = 0;
    private int Boredom = 0;
    private List<string> words = new() {"Hej"};
    private bool isAlive = true;
    public string Name ="kawaii";
    public void Feed()
    {  
        Hunger -=3;
    }
    public void Hi()
    {
        int i = Random.Shared.Next(words.Count);
        Console.WriteLine(words[i]);
    }
    public void Teach(string word)
    {
        words.Add(word);
        ReduceBoredom();
    }
    public void Tick()
    {
        Boredom +=3;
        Hunger +=3;
        if (Boredom == 10 || Hunger == 10)
        {
            isAlive = false;
        }
    }
    public void PrintStats()
    {

        Console.WriteLine($"Hunger är på {Hunger}");
        Console.WriteLine($"Boredom är på {Boredom}");
        
        
        if (isAlive == true)
        {
            Console.WriteLine($"{Name} lever");
        }
        
        else
        {
            Console.WriteLine($"{Name} är död :(");
        }
    }
    public bool GetAlive()
    {
        return isAlive;
    }

    private void  ReduceBoredom()
    {
        Boredom -=3;
    }
}
