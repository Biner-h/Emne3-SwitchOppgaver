
void run()
{
    Console.WriteLine("Hvilken dag er de ulike tallene?");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("Det er mandag!");
            break;
        case "2":
            Console.WriteLine("Det er tirsdag!");
            break;
        case "3":
            Console.WriteLine("Det er onsdag!");
            break;
        case "4":
            Console.WriteLine("Det er torsdag!");
            break;
        case "5":
            Console.WriteLine("Det er fredag!");
            break;
        case "6":
            Console.WriteLine("Det er lørdag!");
            break;
        case "7":
            Console.WriteLine("Det er søndag!");
            break;
        default:
            run();
            break;
    }
}

run();