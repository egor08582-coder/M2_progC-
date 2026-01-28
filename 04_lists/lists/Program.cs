
class Program
{
    static void Main(string[] args)
    {
        Program app = new Program();
        app.Run();
    }

    void Run()
    {
        /*01 - LIST MAKEN
         * 
         * 
         * 
         * 
        string[] characters =
        {
            "Pac-Man",
            "Samus",
            "Crash Bandicoot",
            "Spyro the Dragon",
            "Donkey Kong",
            "Mario",
            "Luigi",
            "Astro",
            "Solid Snake",
            "Master Chief",
            "Kratos",
            "Sonic the Hedgehog",
            "Link"
        };

        List<string> characterList = new List<string>();

        characterList.Add("HIER JE CHARACTER");

        foreach (string character in characters)
        {
            characterList.Add(character);
        }

        Console.WriteLine("FOR");
        Console.WriteLine("");
        for (int i = 0; i < characterList.Count; i++)
        {
            Console.WriteLine(characterList[i]);
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("FOREACH");
        Console.WriteLine("");
        foreach (string character in characterList)
        {
            Console.WriteLine(character);
        }
        */

        /*02 - REMOVE
         * 
         *
         * 
         * 
        List<double> reviews = new List<double>()
        {
            9.99,
            4.68,
            342.97,
            12.2
        };

        Console.WriteLine("Before remove:");
        foreach (double r in reviews)
        {
            Console.WriteLine(r);
        }

        reviews.Remove(342.97);

        reviews.RemoveAt(0);

        Console.WriteLine();
        Console.WriteLine("After remove:");
        foreach (double r in reviews)
        {
            Console.WriteLine(r);
        }
        */

        /*03 remove in loop
         * 
         *
         * 
         * 
        List<Pickup> pickups = new List<Pickup>();

        for (int i = 0; i < 10; i++)
        {
            Pickup pickup = new Pickup()
            {
                x = i,
                y = 0
            };

            pickups.Add(pickup);
        }

        for (int i = pickups.Count - 1; i >= 0; i--)
        {
            if (pickups[i].x == 4)
            {
                pickups.RemoveAt(i);
                Console.WriteLine("removed pickup 4");
            }
            else
            {
                Console.WriteLine($"pickup {pickups[i].x} is still there");
            }
        }
    */

        List<Mob> mobs = new List<Mob>()
        {
            new Mob(),
            new Mob(),
            new Mob()
        };

        Random rand = new Random();

        for (int i = 0; i < 100; i++)
        {
            foreach (Mob mob in mobs)
            {
                int chance = rand.Next(100);

                if (!mob.isDead && chance < 30)
                {
                    mob.TakeDamage(1);
                }
            }
        }

        List<Mob> defeated = mobs.Where(mob => mob.isDead).ToList();

        Console.WriteLine("Defeated mobs:");

        foreach (Mob mob in defeated)
        {
            Console.WriteLine($"Mob defeated, hp = {mob.hp}");
        }

    }

}

/*03 remove in loop
 * 
 * 
 * 
 * 
class Pickup()
{
    internal int x;
    internal int y;
}
*/
 
class Mob
{
    internal bool isDead;
    internal int hp = 10;

    internal void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            isDead = true;
        }
    }
}


