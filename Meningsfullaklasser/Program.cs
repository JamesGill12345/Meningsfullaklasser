

Console.WriteLine("Välkommen till affären, välj vad du vill lägga i varukorgen, skriv Checkout när du vill betala");
Console.WriteLine("Meny:");

List<groceries> Cart = new List<groceries>();

bool Done = false;

while (Done == false)
{
    Console.WriteLine("ägg, sallad, hamburgare");
    string answer = Console.ReadLine();

    if (answer == "ägg")
    {
        ägg ägg = new ägg ();
        Cart.Add (ägg);
    }

    else if (answer == "sallad")
    {
        sallad sallad = new sallad();
        Cart.Add (sallad);
    }

    else if (answer == "hamburgare")
    {
        hamburgare hamburgare = new hamburgare();
        Cart.Add (hamburgare);
    }
    
    string input  = Console.ReadLine();
    if (input == "Checkout")
    {
        Done = true;
    }
}

if (Done == true)
{
    Console.WriteLine("Skriv 1 för att kolla hur mycket dina varor väger och 2 för att kolla hur mycket allt kostade");
    string checkoutanswer = Console.ReadLine();

    if (checkoutanswer == "1")
    {
        
    }

    else if (checkoutanswer == "2")
    {
        
    }
}
//
