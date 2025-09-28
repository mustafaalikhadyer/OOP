using System;

class Program
{
    static void Main(string[] args)
    {
        // Skapa två cirkel-objekt
        Circle circle1 = new Circle(5); // Radie 5
        Circle circle2 = new Circle(6); // Radie 6

        // Räkna ut och skriv ut arean
        Console.WriteLine("Arean av cirkel 1 (radie 5): " + circle1.GetArea()); // Använder GetArea-metoden från Circle-klassen
        Console.WriteLine("Arean av cirkel 2 (radie 6): " + circle2.GetArea()); // Använder GetArea-metoden från Circle-klassen

        // Vänta på att användaren trycker på en tangent (så konsolen inte stängs direkt)
        Console.ReadKey();
    }
}