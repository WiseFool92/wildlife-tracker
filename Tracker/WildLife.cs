using System;
using System.Collections.Generic;


namespace WildLife.Tracker
{
  public class Animal
  {
    private string _species;
    private string _age;

    public Animal(string species, string age)
    {
      _species = species;
      _age = age;
    }

    public string GetSpecies()
    {
      return _species;
    }

    public string GetAge()
    {
      return _age;
    }
  }
}