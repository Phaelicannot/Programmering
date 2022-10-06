// See https://aka.ms/new-console-template for more information
Random generator = new Random();

Console.WriteLine("Välkommen! Vill du köra? \nJa/Nej");
string janej = Console.ReadLine();
string lowerjanej = janej.ToLower();

if (lowerjanej == "ja" || lowerjanej == "j")
{
    Console.WriteLine("Ok, nice! \nVad vill du att din karaktär ska heta?");
    string char1 = Console.ReadLine();
    Console.WriteLine("Och din fiende?");
    string char2 = Console.ReadLine();
    
    Console.WriteLine("Ok, spelet börjar.");

    int hp1 = 200;
    int hp2 = 200;
    int round = 0;

    while (hp1 > 0 && hp2 > 0)
    {
        round = round + 1;
        Console.WriteLine($"\n-----Runda {round}:-----");
        Console.WriteLine($"\n{char1}: {hp1} HP \n{char2}: {hp2} HP \n");
        Console.WriteLine("--Tryck på valfri knapp för att starta rundan--");
        Console.ReadLine();

        string attack = "o";
        while (attack != "1" && attack != "2" && attack != "3")
        {
           Console.WriteLine("Välj attack: \n1: Slå \n2: Sparka \n3: Nyp"); 
           attack = Console.ReadLine();
           if (attack != "1" && attack != "2" && attack != "3")
           {
            Console.WriteLine("Du verkar ha valt något annat än det som fanns i listan, ajabaja. Välj igen, tack.");
           }
        }
        
        if (attack == "1")
        {
            int dmg11 = generator.Next(50,70);
            hp2 -= dmg11;
            hp2 = Math.Max(0, hp2);
            Console.WriteLine($"{char1} slår {char2}.");
            Thread.Sleep(1500);
            if (dmg11 >= 65)
            {
                Console.WriteLine("!!Kritiskt slag!!");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{char2} tar {dmg11} skada, och har {hp2} HP kvar. \n");
            Thread.Sleep(2000);
        }
        else if (attack == "2")
        {
            int dmg12 = generator.Next(20,80);
            hp2 -= dmg12;
            hp2 = Math.Max(0, hp2);
            Console.WriteLine($"{char1} sparkar {char2}.");
            Thread.Sleep(1500);
            if (dmg12 >= 65)
            {
                Console.WriteLine("!!Kritiskt slag!!");
                Thread.Sleep(1000);
            }
            else if (dmg12 <= 20)
            {
                Console.WriteLine("...Det var svagt...");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{char2} tar {dmg12} skada, och har {hp2} HP kvar. \n");
            Thread.Sleep(2000);  
        }
        else if (attack == "3")
        {
            int dmg13 = generator.Next(1,5);
            hp2 -= dmg13;
            hp2 = Math.Max(0, hp2);
            Console.WriteLine($"{char1} nyper {char2}. Det var ett riktigt dåligt val, vem lärde hen att nypa gör skada??");
            Thread.Sleep(1500);
            Console.WriteLine($"{char2} tar endast {dmg13} skada, och har {hp2} HP kvar. \n");
            Thread.Sleep(2000);  
        }
   
    

        if (hp2 > 0)
        {
            int dmg2 = generator.Next(30,100);
            hp1 -= dmg2;
            hp1 = Math.Max(0, hp1);
            Console.WriteLine($"{char2} sparkar {char1}s knä (Det är den enda attacken hen känner till...).");
            Thread.Sleep(1500);
            if (dmg2 >= 85)
            {
                Console.WriteLine("!!Kritiskt slag!!");
                Thread.Sleep(1000);
            }
            else if (dmg2 <= 40)
            {
                Console.WriteLine("...Det var svagt...");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{char1} tar {dmg2} skada, och har {hp1} HP kvar. \n");
            Thread.Sleep(1500);
        }

    }

    Console.WriteLine("-----Striden är över!-----");

    if (hp1 == 0)
    {
        Console.WriteLine($"{char1} dog. Ajajaj, du förlorade...");
    }
    else if (hp2 == 0)
    {
        Console.WriteLine($"{char2} dog. Grattis, du vann!");
    }
    Console.WriteLine("--Tryck på valfri knapp för att avsluta--");
    Console.ReadLine();
}

else if (lowerjanej == "nej" || lowerjanej == "n")
{
    Console.WriteLine("Jaha, vad synd. Hejdå!");
    Thread.Sleep(3000);
}
else
{
    Console.WriteLine("Sorry, jag fattade inte riktigt. Jag tar det som ett nej, hejdå!");
    Thread.Sleep(3000);
}
