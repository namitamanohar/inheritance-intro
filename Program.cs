using System;

namespace InheritanceIntro {
    class Program {
        static void Main (string[] args) {

            var myBike = new Zero ();
            // I can still reference the inherited property
            myBike.MainColor = "Black";
            myBike.MaxOccupancy = 2;

            var myTesla = new Tesla ();
            myTesla.MainColor = "Midnight Silver";
            myTesla.MaxOccupancy = 6;

            var myRam = new Ram ();
            myRam.MainColor = "Green";
            myRam.MaxOccupancy = 5;

            var myCessna = new Cessna ();
            myCessna.MainColor = "Silver";

            myBike.Drive ();
            myBike.Turn ("right");
            myBike.Stop ();

            myTesla.Drive ();
            myTesla.Turn ("left");
            myTesla.Stop ();

            myCessna.Drive ();
            myCessna.Turn ("right");
            myCessna.Stop ();

            myRam.Drive ();
            myRam.Turn ("left");
            myRam.Stop ();
            // double price = 15.50;
            // Console.WriteLine (price.ToString ("C"));

        }
    }
}