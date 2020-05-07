using System;
using System.Collections.Generic;
using WildLife.Tracker;

namespace WildLife
{
  public class Program
  {
    public static List<Animal> fluffyFriends = new List<Animal>();
    
    public static void Main()
    {
      Console.WriteLine("Hello Park Host, what new animals do you have for me today?");
      Tracker();
    }
    public static void Tracker()
    {
      Console.WriteLine("Type y to create another animal, show to show animals, or n to end: ");       
      string another = (Console.ReadLine().ToLower());
      
      if(another == "y")
      {
        Console.WriteLine("Type in the animal's species: ");
        string _species = Console.ReadLine();

        Console.WriteLine("Type in the animal's age: ");
        string _age = Console.ReadLine();

        Animal newAnimal = new Animal(_species,_age);
        fluffyFriends.Add(newAnimal);

        Console.WriteLine(fluffyFriends); 
        Tracker();
      }
      else if (another == "show") 
      {
        foreach(Animal an in fluffyFriends)
        {
          Console.WriteLine("Species: " + an.GetSpecies() + " Age: " + an.GetAge());
        }
      }
      else 
      {
        Console.WriteLine("Hasta Luego!");
      }
    }
  }
}