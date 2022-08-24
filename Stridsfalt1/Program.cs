Player p1 = new Player();
Player p2 = new Player();
Wall w1 = new Wall();

p1.name = "cringe";
p2.name = "bruh";

p1.nationality = "bulgarian";
p2.nationality = "armenian";

System.Console.WriteLine("(cringe) hits (bruh) causing 25 dmg!");

p2.hp -= 25;

System.Console.WriteLine("(bruh) hits (cringe) causing 90 dmg!");

p1.hp -= 90;

System.Console.WriteLine("(cringe) misses (bruh) hitting a wall instead!");

if (w1.destructible == false)
{
    System.Console.WriteLine("(wall) says Bruh...");
}

System.Console.WriteLine(p1.hp);
System.Console.WriteLine(p2.hp);

Console.ReadLine();
