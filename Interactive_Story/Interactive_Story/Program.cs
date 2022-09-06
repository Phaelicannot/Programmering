Console.WriteLine("Välkommen. Vill du spela?");
string janej = Console.ReadLine();
string lowerjanej = janej.ToLower();

if (janej == "ja")
{
    Console.WriteLine($"Ok. Du vaknar upp i ett tomt rum med två dörrar; en röd och en blå. Det verkar inte finnas någon annan utväg. Vilken dörr vill du öppna? Skriv 'röd' eller 'blå'.");
    string dörr = Console.ReadLine();
    string lowerdörr = dörr.ToLower();
    if (lowerdörr == "röd")
    {
        Console.WriteLine("Du öppnar den röda dörren. Bakom den finns ännu ett tomt rum, och du går in. När du är inne i rummet ser du att det finns tre dörrar till; en gul, en grön, och en lila. Vilken dörr vill du öppna? Skriv 'gul', 'grön', eller 'lila'.");
        string dörr2 = Console.ReadLine();
        string lowerdörr2 = dörr2.ToLower();
        if (lowerdörr2 == "gul")
        {
            Console.WriteLine("Du öppnar den gula dörren. Det är helt bäcksvart. Men du hör en massa jamanden, det här rummet måste vara fyllt av katter. Dörren låser sig bakom dig, och lamporna tänds. Jupp, det här rummet är fyllt av katter. Du sätter dig ner och börjar klappa några av katterna, innan du kommer ihåg att du har en dödlig kattallergi. Du dör en lycklig död bland mängder av fluffiga små dödsmaskiner.");
            Console.ReadLine();
        }
        else if (lowerdörr2 == "grön")
        {
            Console.WriteLine("Du öppnar den gröna dörren. Bakom den finns frihet. Grattis, du hittade vägen ut, och är nu fri.");
            Console.ReadLine();
        }
        else if (lowerdörr2 == "lila")
        {
            Console.WriteLine("Du öppnar den lila dörren. Bakom den finns det ett tomt rum, och när du går in låser dörren sig bakom dig. En högtalare börjar spela någonting. Du börjar gråta okontrollerat när du inser vad du har för öde framför dig. Du ruttnar långsamt bort till dålig hissmusik.");
            Console.ReadLine();
        }
        else 
        {
            Console.WriteLine("Din inkapabilitet till att stava rätt lämnar dig funderande, och du slutar upp med att aldrig öppna någon av dörrarna. Du ruttnar långsamt bort i rummet medan du sitter och funderar på dina misstag.");
            Console.ReadLine();
        }
    }
    else if (lowerdörr == "blå")
    {
        Console.WriteLine("Du öppnar den blåa dörren. Bakom den står en stor, överdrivet muskulös man med en välkammad mustasch. Bakom mannen finns det en lång korridor, med en dörr i slutet. Du måste ta dig förbi honom. I ditt huvud dyker det upp tre val; spring, slå till honom eller dra i hans mustasch. Skriv 'spring' för att springa, 'slå' för att slå till honom, eller 'dra' för att dra i hans mustasch.");
        string action = Console.ReadLine();
        string loweraction = action.ToLower();
        if (loweraction == "spring")
        {
            Console.WriteLine("Du börjar springa, men du tänker inte på vart du springer. Du råkar springa rakt in i den muskulösa mannen, och dör när du kolliderar med honom. Livet är tufft ibland.");
            Console.ReadLine();
        }
        else if (loweraction == "slå")
        {
            Console.WriteLine("Du slår till den muskulösa mannen i ansiktet. Han rör sig inte en millimeter. Den muskulösa mannen rynkar på ögonbrynen och drämmer till dig på ett ovanligt graciöst sätt. 'Jag borde ha ansträngt mig under gympalektionerna mer', tänker du medan allting svartnar till. Du är död.");
            Console.ReadLine();
        }
        else if (loweraction == "dra")
        {
            Console.WriteLine("Du drar i mannens mustasch. Han står blickstilla, men du ser hur en tår formas i hans ena öga. Några sekunder senare springer han iväg gråtandes, hans långa, vältrimmade mustasch fladdrande i vinden. Han öppnar dörren i slutet av korridoren, och du ser att den leder ut till friheten. Du går ut genom dörren. Du är nu fri, grattis.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Din inkapabilitet till att stava rätt lämnar dig till att stå kvar. Du stirrar på mannens mustasch, mållös. Mannen blir milt obekväm, och drämmer till dig i respons. Medan du faller till marken far tankar om hur man möjligen kan ha en så där makalös mustasch. Sen slocknar allt. Du är död.");
            Console.ReadLine();
        }

    }
    else
    {
        Console.WriteLine("Din inkapabilitet till att stava ett tre-bokstavigt långt ord lämnar dig funderande, och du slutar upp med att aldrig öppna någon av dörrarna. Du ruttnar långsamt bort i rummet medan du sitter och funderar på dina misstag.");
        Console.ReadLine();
    }
}
else if (janej == "nej")
{
    Console.WriteLine("Jaha ok, hejdå då din odugliga unge");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Lär dig svara på en fråga");
    Console.ReadLine();
}