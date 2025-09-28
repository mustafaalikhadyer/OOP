using System;

public class Circle // Klass för att representera en cirkel
{
    private double radius; // Radie

    // Konstruktor
    public Circle(double radius) // Tar radien som parameter
    {
        this.radius = radius; // Sätter radien
    }

    // Metod för att räkna ut arean
    public double GetArea() // Returnerar arean
    {
        return Math.PI * radius * radius; 
    }
}