using System;
namespace InheritanceIntro {

  public class Zero : Vehicle { // Electric motorcycle
    public double BatteryKWh { get; set; }
    public void ChargeBattery () { }

    public override void Drive () {
      // "The blue Ram drives past. RRrrrrrummbbble!"
      Console.WriteLine ($"The {MainColor} Zero drives past. Rrrrrr!");
    }

  }

}