using System;

namespace InheritanceIntro {

  public class Ram : Vehicle { // Gas powered truck
    public double FuelCapacity { get; set; }

    public void RefuelTank () { }

    public override void Drive () {
      // "The blue Ram drives past. RRrrrrrummbbble!"
      Console.WriteLine ($"The {MainColor} Ram drives past. Scrrrrrr!");
    }
  }

}