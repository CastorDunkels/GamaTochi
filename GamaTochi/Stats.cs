using System;
public class Stats
{
    private int Hunger = 0;

    private int Boredom = 0;

    private List<string> Words = new();

    private bool isAlive = true;

    private Random generator = new(); 

    public string Name;

    public void Feed(){
        int rndFeed = generator.Next(3);
        Hunger -= rndFeed;
        if (Hunger <= 0){
            Hunger = 0;
        }
    }

    public void Hi(){
        int wordNum = generator.Next(Words.Count);
        Console.WriteLine($" {Name} says: {Words[wordNum]}");
        ReduceBoredom();
    }

    public void Teach(string word){
        if(!word.Contains(word)){
            Console.WriteLine($" {Name} learns: {word}");
            Words.Add(word);
            ReduceBoredom();
        }
        else{
            Console.WriteLine($"{Name} already knew that word");
        }
    }

    public void Tick(){
        Hunger ++;
        Boredom ++;
        if(Hunger >= 10 || Boredom >= 10){
            isAlive = false;
        }

    }

    public void PrintStats(){
        Console.WriteLine($"Name: {Name} || Hunger: {Hunger} || Boredom: {Boredom} || Vocabulary: {Words.Count} words");
    }

    public bool GetAlive(){
        return isAlive;
    }

    private void ReduceBoredom(){
        int rndBoredom = generator.Next(4);
        Boredom -= rndBoredom;
        if (Boredom < 0){
            Boredom = 0;
        }

    
    }


}
