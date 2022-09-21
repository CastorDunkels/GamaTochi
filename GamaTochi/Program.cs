Console.WriteLine("Welcum to GamaTochi! Your new beast friend.");

Stats S = new Stats();

Console.WriteLine("Choose a new name for your new friend:");

S.Name = Console.ReadLine();
S.Name = S.Name.ToLower();
if (S.Name == "todd" || S.Name == "")
{
    S.Name = "Todd";
    Console.WriteLine($"{S.Name} is happy that you choose to leave its name as it was.");

}
else
{
    Console.WriteLine($"{S.Name} will not be happy with its new name.");

}
Console.ReadKey();

while(S.GetAlive() == true){

    Console.Clear();
    S.Tick();
    S.PrintStats();
    Console.WriteLine($"What do you want to do today? \nGive {S.Name} food: Type 1");
    Console.WriteLine($"Talk with {S.Name}: Type 2");
    Console.WriteLine($"Teach {S.Name} a new word: Type 3");
    string Action = Console.ReadLine();
    if(Action == "1"){
        S.Feed();
    }
    if(Action == "2"){
        S.Hi();
    }
    if(Action == "3"){
        Console.WriteLine("What word?");
        string word = Console.ReadLine();
        S.Teach(word);
    }
    else{
        Console.WriteLine("You chose to do nothing");
    }


}

Console.WriteLine($"This is so sad you let {S.Name} die!");
Console.WriteLine("Press any key to exit");
Console.ReadKey();
