using System;

namespace InheritanceIntro {
  public class Cessna : Vehicle { // Propellor light aircraft
    public double FuelCapacity { get; set; }

    public void RefuelTank () { }
    public override void Drive () {
      // "The blue Ram drives past. RRrrrrrummbbble!"
      Console.WriteLine ($"The {MainColor} Cessna drives past. Vroom!");
    }

    public override void Stop () {
      Console.WriteLine ($"The {MainColor} Cessna rolls to a stop after rolling a mile down the runway.");

    }
  }

}