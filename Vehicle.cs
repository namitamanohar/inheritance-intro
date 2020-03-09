using System;

namespace InheritanceIntro {
  public class Vehicle {

    public string MainColor { get; set; }

    public int MaxOccupancy { get; set; }

    // virtual gives permission to the child to overide this function if wanted 
    public virtual void Drive () {
      Console.WriteLine ("Vroom!");
    }

    public virtual void Turn (string direction) {
      Console.WriteLine ($"The vehicle carefully turns {direction} ");
    }

    public virtual void Stop () {
      Console.WriteLine ("Then vehicle gently rolls to a stop");
    }
  }
}