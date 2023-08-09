Console.WriteLine("How many miles have you driven?");
string miles = Console.ReadLine();
Console.WriteLine("How manyh gallons of gas used?");
string gas = Console.ReadLine();
int milesPerGallon = int.Parse(miles) / int.Parse(gas);
Console.WriteLine("You averaged " +  milesPerGallon + " miles per gallon");