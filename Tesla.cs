using System;
namespace InheritanceIntro {

  public class Tesla : Vehicle { // Electric car
    public double BatteryKWh { get; set; }

    public void ChargeBattery () { }

    public override void Drive () {
      // "The blue Ram drives past. RRrrrrrummbbble!"
      Console.WriteLine ($"The {MainColor} Tesla drives past.Rrrrrrumble!");
    }

    public override string ToString () {
      return "This is my tesla";
    }

    public override void Stop () {
      Console.WriteLine ($"The {MainColor} Tesla silently stops as if it never moved ");

    }
  }

}