class hamburgare : groceries
{

    public int price;
    public int weight;



    public hamburgare()
    {
        weight = 10;
        price = 100;
    }

// konstruktor som ändrar på hamburgarens vikt
// kolla om den är rutten, if sats i metod

    public bool GetSpoiled()
    {
        int age = Random.Shared.Next(6);
         
        bool spoiled = false;
        if (age > 3)
        {
            spoiled = true;
        }

        return spoiled;

    }


    public int Getweight()
    {
        return weight;
    }
}