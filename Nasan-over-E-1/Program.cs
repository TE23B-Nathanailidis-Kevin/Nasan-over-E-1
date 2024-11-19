// if (6 >= 3)
//{
//    Console.WriteLine("Hello World");
//}

//Console.ReadLine();

//Console.WriteLine("Type in username");
//string name = Console.ReadLine();
//if (name == "kalleanka");
// {
//     Console.WriteLine("Welcome!");
// }
// Console.ReadLine();

// Console.WriteLine("Type in username");
// string name = Console.ReadLine();

// if  (name == "noname")
// {
//     Console.WriteLine("Type in password");
//     string pass = Console.ReadLine();
//     if  (pass == "nopass")
//     {
//         Console.WriteLine("Welcome");
//     }
//     else
//     {
//         Console.WriteLine("Try again");
//     }
// }
// else
// {
//     Console.WriteLine("try again!");
// }
// Console.ReadLine();

// for (int hello = 0; hello < 32; hello++)
// {
//     Console. WriteLine("Hello, world");
// }
// Console.ReadLine(); 


// string lösenord = "";
// while (lösenord != "Apelsin")
// {
//     Console.WriteLine("Testa igen");
//     lösenord = Console.ReadLine();
// } 
// Console.ReadLine();



//for (int hello = 0; hello < 5; hello++)
//{
//    Console.WriteLine("Skriv ett tal");
//    string tal = Console.ReadLine();
//int n = 0;
//  bool success = int.TryParse(tal, out n);
//   if (n > 5)
//   {
//       Console.WriteLine("Högre än fem!");
//    }
//}
//Console.ReadLine();

// int n = 0;
// bool success = false;
// while (success != true)
// {
//     string talKanske = Console.ReadLine();
//     success = int.TryParse(talKanske, out n);
// }

// int n = 8;
// bool success = false;
// while (success != true)
// {
//     string talKanske = Console.ReadLine();
//     success = int.TryParse(talKanske, out n);
// }

int hemligtTal = Random.Shared.Next(1,11);
int gissning = -1;

Console.WriteLine("Välkommen till Gissa Siffran! Jag har valt ett tal mellan 1 och 10.");

while (gissning != hemligtTal)
{
    Console.Write("Skriv in din gissning: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out gissning))
    {
        if (gissning < hemligtTal)
        {
            Console.WriteLine("För lågt numner!");
        }
        else if (gissning > hemligtTal)
        {
            Console.WriteLine("För högt nummer!");
        }
        else
        {
            Console.WriteLine("Rätt svar!");
            Console.ReadLine();
        }
    }
    else
    {
        Console.WriteLine("Det är inte ett nummer!!");
    }
} 
